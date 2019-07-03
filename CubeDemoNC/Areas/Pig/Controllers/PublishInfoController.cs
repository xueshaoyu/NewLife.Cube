using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using CubeApi;
using CubeDemoNC;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NewLife.Cube;
using NewLife.Cube.Entity;
using NewLife.Data;
using NewLife.Serialization;
using NewLife.Web;
using Pig.Repository.Entity;
using XCode;
using XCode.Configuration;
using XCode.Membership;

namespace WebTest.Areas.Pig.Controllers
{
    [PigArea]
    [DisplayName("信息发布管理")]
    public class PublishInfoController : WeiXinController<PublishInfo>
    {
        public override ActionResult Index(Pager p = null)
        {
            return base.Index(p);
        }

        protected override IDictionary<MethodInfo, Int32> ScanActionMenu(IMenu menu)
        {
            menu.Visible = true;
            return base.ScanActionMenu(menu);
        }
        public override ActionResult AddJson(String openId, PublishInfo entity)
        {
            if (entity.OpenId.IsNullOrEmpty())
            {
                return Json(ReturnHelper.ErrorMsgEcodeElevelHttpCode("OpenId is null"));
            }
            var user = FindCurrentUser(entity.OpenId);
            if (user == null)
            {
                return Json(ReturnHelper.ErrorMsgEcodeElevelHttpCode("this user is not valid"));
            }
            else
            {
                PublishInfo.Update("Publish=0", "OpenId='" + openId + "'");
                entity.CreateUserID = user.Id;
                entity.UpdateUserID = user.Id;
                entity.CreateTime = DateTime.Now;
                entity.UpdateTime = DateTime.Now;
                entity.Publish = 1;
                entity.UserId = user.Id;
                entity.Insert();
            }

            return Json(ReturnHelper.SuccessMsgDataDCountHttpCode("Success"));
        }

        private WhereExpression Search(DateTime start, DateTime end, string key, PageParameter page,int role)
        {
            WhereExpression whereExpression = Entity<PublishInfo>.SearchWhereByKeys(key, (FieldItem[])null, (Func<string, FieldItem[], WhereExpression>)null);
            if (start > DateTime.MinValue || end > DateTime.MinValue)
            {
                FieldItem masterTime = Entity<PublishInfo>.Meta.Factory.MasterTime;
                if (masterTime != null)
                    whereExpression = (Expression)whereExpression & masterTime.Between(start, end);
            }
            whereExpression &= PublishInfo._.Role.Equal(role);
            return whereExpression;
        }
        [AllowAnonymous]
        [DisplayName("List接口")]
        public ActionResult List(PublishSearInfo  searInfo, Pager p)
        {
            if (searInfo.Id.IsNullOrEmpty()) searInfo.Id = GetRequest("token");
            if (searInfo.Id.IsNullOrEmpty()) searInfo.Id = GetRequest("key");

            try
            {
                //var user = UserToken.Valid(id);
                var app = App.Valid(searInfo.Id);

                // 需要总记录数来分页
                p.RetrieveTotalCount = true;
                var expression= Search(p["dtStart"].ToDateTime(), p["dtEnd"].ToDateTime(), p["Q"], p, searInfo.Role);
                var list = Entity<PublishInfo>.FindAll(expression);
               // var list1 = Search(p);
                // Json输出
                return Json(ReturnHelper.SuccessMsgDataDCountHttpCode("success", new
                {
                    list = list,
                    pager = p
                }));
            }
            catch (Exception ex)
            {
                return Json(ReturnHelper.ErrorMsgEcodeElevelHttpCode("error"));
            }
           
        }
    }


    public class PublishSearInfo
    {
        public string Id { get; set; }
        public int Role { get; set; }
    }
}