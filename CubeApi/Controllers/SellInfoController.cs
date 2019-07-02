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
    public class SellInfoController : ApiBaseController<SellInfo>
    {
        public override  ActionResult Index(Pager p = null)
        {
            return base.Index(p);
        }

     
    }
}