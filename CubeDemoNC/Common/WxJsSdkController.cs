using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using NewLife.Cube;
using Senparc.CO2NET.HttpUtility;
using Senparc.CO2NET.Utilities;
using Senparc.Weixin;
using Senparc.Weixin.Entities;
using Senparc.Weixin.MP;
using Senparc.Weixin.MP.AdvancedAPIs;
using Senparc.Weixin.MP.Containers;
using Senparc.Weixin.MP.Entities.Request;
using Senparc.Weixin.MP.Helpers;
using Senparc.Weixin.MP.MvcExtension;

namespace CubeDemoNC.Common
{
    [Route("api/[controller]")]
    [EnableCors("AllowSpecificOrigin")]
    public class WxJsSdkController : Controller
    {
        public static readonly string Token = Config.SenparcWeixinSetting.Token; //与微信公众账号后台的Token设置保持一致，区分大小写。

        public static readonly string
            EncodingAESKey = Config.SenparcWeixinSetting.EncodingAESKey; //与微信公众账号后台的EncodingAESKey设置保持一致，区分大小写。

        public static readonly string AppId = Config.SenparcWeixinSetting.WeixinAppId; //与微信公众账号后台的AppId设置保持一致，区分大小写。

      
        SenparcWeixinSetting _senparcWeixinSetting;

        public WxJsSdkController(IOptions<SenparcWeixinSetting> senparcWeixinSetting)
        {
            _senparcWeixinSetting = senparcWeixinSetting.Value;
        }

        /// <summary>
        /// 微信后台验证地址（使用Get），微信后台的“接口配置信息”的Url填写如：http://sdk.weixin.senparc.com/weixin
        /// </summary>
        [HttpGet]
        [ActionName("Index")]
        public  ActionResult Get()
        {
         
            var timestamp = JSSDKHelper.GetTimestamp();
            //获取随机码
            var nonceStr = JSSDKHelper.GetNoncestr();
            var ticket = JsApiTicketContainer.TryGetJsApiTicket(AppId, Config.SenparcWeixinSetting.WeixinAppSecret);
            //获取签名
            var signature = JSSDKHelper.GetSignature(ticket, nonceStr, timestamp, Request.Headers["Referer"].ToString());
          
            //var HeaderFrom = Request.Headers["HeaderFrom"].ToString();
            //var HeaderRefer = Request.Headers["HeaderReferer"].ToString();
            return Json(ReturnHelper.IsSuccessMsgDataHttpCode(true, "Successed", new {
                timestamp= timestamp,
                nonceStr= nonceStr,
                ticket= ticket,
                signature= signature,
                HeaderFrom = Request.Headers["From"].ToString(),
                HeaderRefer = Request.Headers["Referer"].ToString()
            }));
        }
    }
}