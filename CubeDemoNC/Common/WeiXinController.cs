using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NewLife.Cube;
using NewLife.Cube.Entity;
using Pig.Repository.Entity;
using XCode;

namespace CubeDemoNC
{
    public class WeiXinController<TEntity> : EntityController<TEntity> where TEntity : Entity<TEntity>, new()
    {
        /// <summary>
        /// 新增用户
        /// </summary>
        /// <param name="openId"></param>
        /// <returns></returns>
        protected User CreateUser(string openId)
        {
            var user = new User();
            user.OpenId = openId;
            user.CreateTime = DateTime.Now;
            user.UpdateTime = DateTime.Now;
            user.Insert();
            return user;
        }
        /// <summary>
        /// 根据OpenId查找当前用户
        /// </summary>
        /// <param name="openId"></param>
        /// <returns></returns>
        protected User FindCurrentUser(string openId)
        {

            var whereExpression = new WhereExpression();
            var field = Entity<User>.Meta.Table.FindByName("OpenId");
            whereExpression &= field == openId;
            var user = Entity<User>.Find(whereExpression);
            return user;
        }
        /// <summary>
        /// 添加实体
        /// </summary>
        /// <param name="openId"></param>
        /// <param name="entity"></param>
        /// <returns></returns>
        [HttpPost]
        [AllowAnonymous]
        [DisplayName("JsonAdd接口")]
        public virtual ActionResult AddJson(string openId, TEntity entity)
        {
            try
            {

                //   entity[""] = v; 
                entity.Insert();

                return JsonOK(entity);
            }

            catch (Exception ex)
            {
                return JsonError(ex.GetTrue());
            }

        }
    }
}
