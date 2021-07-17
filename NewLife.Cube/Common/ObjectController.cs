﻿using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using NewLife.Reflection;
using XCode.Membership;
using System.Collections.Generic;
using NewLife.Cube.Common;
using NewLife.Cube.ViewModels;
using NewLife.Web;
#if __CORE__
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using NewLife.Cube.Extensions;
#else
using System.Web.Mvc;
#endif

namespace NewLife.Cube
{
    /// <summary>对象控制器</summary>
    public abstract class ObjectController<TObject> : ControllerBaseX
    {
        /// <summary>要展现和修改的对象</summary>
        protected abstract TObject Value { get; set; }

        /// <summary>菜单顺序。扫描时会反射读取</summary>
        protected static Int32 MenuOrder { get; set; }

        /// <summary>动作执行前</summary>
        /// <param name="filterContext"></param>
#if __CORE__
        public override void OnActionExecuting(ActionExecutingContext filterContext)
#else
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
#endif
        {
            base.OnActionExecuting(filterContext);

            // 显示名和描述
            var name = GetType().GetDisplayName() ?? typeof(TObject).GetDisplayName() ?? typeof(TObject).Name;
            var des = GetType().GetDescription() ?? typeof(TObject).GetDescription();

            ViewBag.Title = name;
            ViewBag.HeaderTitle = name;

            var txt = "";
            if (txt.IsNullOrEmpty()) txt = (ViewBag.Menu as IMenu)?.Remark;
            if (txt.IsNullOrEmpty()) txt = (HttpContext.Items["CurrentMenu"] as IMenu)?.Remark;
            if (txt.IsNullOrEmpty()) txt = des;
            ViewBag.HeaderContent = txt;
        }

        /// <summary>执行后</summary>
        /// <param name="filterContext"></param>
#if __CORE__
        public override void OnActionExecuted(ActionExecutedContext filterContext)
#else
        protected override void OnActionExecuted(ActionExecutedContext filterContext)
#endif
        {
            base.OnActionExecuted(filterContext);

            var title = ViewBag.Title + "";
            HttpContext.Items["Title"] = title;
        }

        /// <summary>显示对象</summary>
        /// <param name="formatType">0-小驼峰，1-小写，2-保持默认</param>
        /// <returns></returns>
        [EntityAuthorize(PermissionFlags.Detail)]
        public ActionResult Index(FormatType formatType = FormatType.CamelCase)
        {
            var model = new ObjectModel { Value = Value };

            if (Value != null)
            {
                var pis = GetMembers(Value);
                var dic = new Dictionary<String, List<CubePropertyInfo>>();
                foreach (var pi in pis)
                {
                    var cat = pi.GetCustomAttribute<CategoryAttribute>();
                    var category = cat?.Category ?? "";
                    if (!dic.TryGetValue(category, out var list)) dic[category] = list = new List<CubePropertyInfo>();

                    var dis = pi.GetDisplayName();
                    var des = pi.GetDescription();
                    if (dis.IsNullOrEmpty() && !des.IsNullOrEmpty()) { dis = des; des = null; }
                    if (!dis.IsNullOrEmpty() && des.IsNullOrEmpty() && dis.Contains("。"))
                    {
                        des = dis.Substring("。");
                        dis = dis.Substring(null, "。");
                    }

                    var cpi = new CubePropertyInfo
                    {
                        Name = pi.Name,
                        DisplayName = dis ?? pi.Name,
                        Description = des,
                        PropertyType = pi.PropertyType,
                        TypeStr = pi.PropertyType.Name
                    };

                    list.Add(cpi);
                }
                model.Properties = dic;
            }

            if (!IsJsonRequest) return View("ObjectForm", model);

            foreach (var property in model.Properties)
            {
                foreach (var item in property.Value)
                {
                    item.FormatType = formatType;
                }
            }

            return Ok(data: model);
        }

        /// <summary>保存对象</summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        //[HttpPost]
        //[DisplayName("修改")]
        [EntityAuthorize(PermissionFlags.Update)]
        public ActionResult Update(TObject obj)
        {
            WriteLog(obj, UserHost);

            // 反射处理内部复杂成员
#if __CORE__
            var keys = WebHelper.Params.Keys;
#else
            var keys = Request.Form.AllKeys;
#endif
            foreach (var item in obj.GetType().GetProperties(true))
            {
                if (Type.GetTypeCode(item.PropertyType) == TypeCode.Object)
                {
                    var pv = obj.GetValue(item);
                    foreach (var pi in item.PropertyType.GetProperties(true))
                    {
                        if (keys.Contains(pi.Name))
                        {
                            var v = (Object)Request.GetRequestValue(pi.Name);
                            if (pi.PropertyType == typeof(Boolean)) v = GetBool(pi.Name);

                            pv.SetValue(pi, v);
                        }
                    }
                }
            }

            Value = obj;

            if (IsJsonRequest)
                return Ok("保存成功");
            else
                return Redirect("Index");
        }

        Boolean GetBool(String name)
        {
#if __CORE__
            var v = Request.GetRequestValue(name);
#else
            var v = Request[name];
#endif
            if (v.IsNullOrEmpty()) return false;

            v = v.Split(",")[0];

            if (!v.EqualIgnoreCase("true", "false")) throw new XException("非法布尔值Request[{0}]={1}", name, v);

            return v.ToBoolean();
        }

        /// <summary>写日志</summary>
        /// <param name="obj"></param>
        /// <param name="ip"></param>
        protected virtual void WriteLog(TObject obj, String ip = null)
        {
            // 构造修改日志
            var sb = new StringBuilder();
            var cfg = Value;
            foreach (var pi in obj.GetType().GetProperties(true))
            {
                if (!pi.CanWrite) continue;

                var v1 = obj.GetValue(pi);
                var v2 = cfg.GetValue(pi);
                if (!Equals(v1, v2) && (pi.PropertyType != typeof(String) || v1 + "" != v2 + ""))
                {
                    if (sb.Length > 0) sb.Append(", ");

                    var name = pi.GetDisplayName();
                    if (name.IsNullOrEmpty()) name = pi.Name;
                    sb.AppendFormat("{0}:{1}=>{2}", name, v2, v1);
                }
            }
            WriteLog("修改", true, sb.ToString());
        }

        /// <summary>获取要显示编辑的成员</summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        protected virtual PropertyInfo[] GetMembers(Object obj)
        {
            var type = Value as Type;
            if (type == null) type = obj.GetType();

            var pis = type.GetProperties(true);
            //pis = pis.Where(pi => pi.CanWrite && pi.GetIndexParameters().Length == 0 && pi.GetCustomAttribute<XmlIgnoreAttribute>() == null).ToArray();
            return pis.ToArray();
        }
    }
}