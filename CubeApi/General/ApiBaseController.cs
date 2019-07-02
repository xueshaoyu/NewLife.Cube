using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using NewLife.Cube;
using NewLife.Web;
using Pig.Repository.Entity;
using XCode;

namespace CubeApi
{
   // [Route("api/[controller]")]
    [EnableCors("AllowSpecificOrigin")]
    public abstract class ApiBaseController<TEntity> : EntityController<TEntity> where TEntity: Entity<TEntity>, new()
    {
        public ActionResult List(Pager p)
        {
            return base.Index(p);
        }
       
    }
}
