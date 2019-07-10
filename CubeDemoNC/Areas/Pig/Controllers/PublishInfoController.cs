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
                if (entity.Id == 0)
                {
                    //新增
                    PublishInfo.Update("Publish=0", "OpenId='" + openId + "'");
                    entity.CreateUserID = user.Id;
                    entity.UpdateUserID = user.Id;
                    entity.CreateTime = DateTime.Now;
                    entity.UpdateTime = DateTime.Now;
                    entity.PubTime = DateTime.Now;
                    entity.Publish = 1;
                    entity.UserId = user.Id;
                    entity.Insert();
                }
                else
                {
                    //编辑
                  var old=  PublishInfo.FindById(entity.Id);
                    if (old != null)
                    {
                        old.UpdateUserID = user.Id;
                        old.UpdateTime = DateTime.Now;
                        old.Title = entity.Title;
                        old.Description = entity.Description;
                        old.Number= entity.Number;
                        old.Imgs = entity.Imgs;
                        old.Publish = 1;
                        old.Price = entity.Price;
                        old.OpenId = openId;
                        old.Update();
                    }
                    else
                    {
                        return Json(ReturnHelper.ErrorMsgEcodeElevelHttpCode("this data is not exist"));
                    }
                }
            }

            return Json(ReturnHelper.SuccessMsgDataDCountHttpCode("Success"));
        }

        private WhereExpression Search(DateTime start, DateTime end, string key, PageParameter page, int role)
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
        public ActionResult List(PublishSearInfo searInfo, Pager p)
        {
            if (searInfo.Token.IsNullOrEmpty()) searInfo.Token = GetRequest("token");
            if (searInfo.Token.IsNullOrEmpty()) searInfo.Token = GetRequest("key");

            try
            {
                //var user = UserToken.Valid(id);
                var app = App.Valid(searInfo.Token);

                // 需要总记录数来分页
                p.RetrieveTotalCount = true;
                var expression = Search(p["dtStart"].ToDateTime(), p["dtEnd"].ToDateTime(), p["Q"], p, searInfo.Role);
                expression &= PublishInfo._.Publish.Equal(1);
                var list = PublishInfo.FindAll(expression,p);
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


        [AllowAnonymous]
        [DisplayName("GetList接口")]
        public ActionResult GetList(PublishSearInfo searInfo, Pager p)
        {
            if (searInfo.Token.IsNullOrEmpty()) searInfo.Token = GetRequest("token");
            if (searInfo.Token.IsNullOrEmpty()) searInfo.Token = GetRequest("key");
            var openId = GetRequest("openid");
            if (openId.IsNullOrEmpty())
            {
                return Json(ReturnHelper.ErrorMsgEcodeElevelHttpCode("OpenId is null"));
            }
            try
            {
                //var user = UserToken.Valid(id);
                var app = App.Valid(searInfo.Token);
                var user = FindCurrentUser(openId);
                if (user == null)
                {
                    return Json(ReturnHelper.ErrorMsgEcodeElevelHttpCode("this user is not valid"));
                }
                // 需要总记录数来分页
                p.RetrieveTotalCount = true;
                var expression = Search(p["dtStart"].ToDateTime(), p["dtEnd"].ToDateTime(), p["Q"], p, user.Role);
                expression &= PublishInfo._.OpenId.Equal(openId);
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
        [AllowAnonymous]
        [DisplayName("取消发布接口")]
        public ActionResult CancelPub(string openId, string token, int id)
        {
            if (openId.IsNullOrEmpty())
            {
                return Json(ReturnHelper.ErrorMsgEcodeElevelHttpCode("OpenId is null"));
            }

            try
            {
                //var user = UserToken.Valid(id);
                var app = App.Valid(token);
                var user = FindCurrentUser(openId);
                if (user == null)
                {
                    return Json(ReturnHelper.ErrorMsgEcodeElevelHttpCode("this user is not valid"));
                }

                var data = Find(id);
                if(data!=null)
                {
                    data.Publish = 0;
                    data.UpdateTime = DateTime.Now;
                    data.UpdateUserID = user.Id;
                    data.Update();
                }
                return Json(ReturnHelper.SuccessMsgDataDCountHttpCode("Success"));
            }
            catch
            {
                return Json(ReturnHelper.ErrorMsgEcodeElevelHttpCode("error"));
            }
        }

        [AllowAnonymous]
        [DisplayName("JsonGet接口")]
        public virtual ActionResult GetJson(string openId, string token, int id)
        {
            if (openId.IsNullOrEmpty())
            {
                return Json(ReturnHelper.ErrorMsgEcodeElevelHttpCode("OpenId is null"));
            }

            try
            {
                //var user = UserToken.Valid(id);
                var app = App.Valid(token);
                var user = FindCurrentUser(openId);
                if (user == null)
                {
                    return Json(ReturnHelper.ErrorMsgEcodeElevelHttpCode("this user is not valid"));
                }

                var data = Find(id);
                return Json(ReturnHelper.SuccessMsgDataDCountHttpCode("Success", new {data}));
            }
            catch
            {
                return Json(ReturnHelper.ErrorMsgEcodeElevelHttpCode("error"));
            }
        }
    }


    public class PublishSearInfo
    {
        public string Token { get; set; }
        public int Role { get; set; }
    }
}