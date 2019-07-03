using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using CubeApi;
using CubeDemoNC;
using Microsoft.AspNetCore.Mvc;
using NewLife.Cube;
using NewLife.Serialization;
using NewLife.Web;
using Pig.Repository.Entity;
using XCode.Membership;

namespace WebTest.Areas.Pig.Controllers
{
    [PigArea]
    [DisplayName("用户管理")]
    public class UserController : WeiXinController<User>
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

        public ActionResult FindByOpenId(string openId)
        {
            var user = FindCurrentUser(openId);
            if(user!=null)
            return Json(ReturnHelper.SuccessMsgDataDCountHttpCode("Success", user));
            return Json(ReturnHelper.ErrorMsgEcodeElevelHttpCode("User is not exitst"));
        }
        public override ActionResult AddJson(String openId, User entity)
        {
            if (openId.IsNullOrEmpty())
            {
                return Json(ReturnHelper.ErrorMsgEcodeElevelHttpCode("OpenId is null"));
            }
            var user = FindCurrentUser(openId);
            if (user == null)
            {
                entity.Insert();
            }
            else
            {
                entity.Id = user.Id;
                entity.UpdateTime = DateTime.Now;
                entity.Update();
            }

            return Json(ReturnHelper.SuccessMsgDataDCountHttpCode("Success"));
        }
    }
}