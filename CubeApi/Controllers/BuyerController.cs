using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using CubeApi;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using NewLife.Web;
using Pig.Repository.Entity;
using XCode.Membership;

namespace WebTest.Areas.Pig.Controllers
{
    public class BuyerController : ApiBaseController<Buyer>
    {
       
        protected override IDictionary<MethodInfo, Int32> ScanActionMenu(IMenu menu)
        {
            menu.Visible = true;
            return base.ScanActionMenu(menu);
        }
        public IActionResult Get()
        {
            return Json(ReturnHelper.SuccessMsgDataDCountHttpCode("接口已开启"));
        }
    }
}