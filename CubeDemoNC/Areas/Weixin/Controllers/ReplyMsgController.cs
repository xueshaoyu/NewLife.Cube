using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NewLife.Cube;
using NewLife.School.Entity;
using NewLife.Web;
using Pig.Repository.Entity;
using WebTest.Areas.School;
using XCode.Membership;

namespace WebTest.Areas.Weixin.Controllers
{
    [WeixinArea]
    [DisplayName("回复管理")]
    public class ReplyMsgController : EntityController<ReplyMsg>
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
    }
}