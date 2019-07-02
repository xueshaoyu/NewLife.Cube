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
    [DisplayName("收购信息管理")]
    public class BuyInfoController : WeiXinController<BuyInfo>
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
        public override ActionResult AddJson(String openId, Buyer entity)
        {
            if (openId.IsNullOrEmpty())
            {
                return Json(ReturnHelper.ErrorMsgEcodeElevelHttpCode("OpenId is null"));
            }
            var user = FindCurrentUser(openId);
            if (user == null)
            {
                user = CreateUser(openId);
            }
            entity.OpenId = openId;
            entity.UserId = user.Id;
            entity.CreateUserID = user.Id;
            entity.UpdateUserID = user.Id;
            entity.CreateTime = DateTime.Now;
            entity.UpdateTime = DateTime.Now;
            return base.AddJson(openId, entity);
        }
    }
}