using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using CubeApi;
using Microsoft.AspNetCore.Mvc;
using NewLife.Cube;
using NewLife.Web;
using Pig.Repository.Entity;
using XCode.Membership;

namespace WebTest.Areas.Pig.Controllers
{
    public class SellerController : ApiBaseController<Seller>
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