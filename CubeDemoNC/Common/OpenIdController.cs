using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CubeApi;
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
using Senparc.Weixin.MP.Entities.Request;
using Senparc.Weixin.MP.MvcExtension;

namespace CubeDemoNC.Common
{
    [Route("api/[controller]")]
    [EnableCors("AllowSpecificOrigin")]
    public class OpenIdController : Controller
    {
        public static readonly string Token = Config.SenparcWeixinSetting.Token; //与微信公众账号后台的Token设置保持一致，区分大小写。

        public static readonly string
            EncodingAESKey = Config.SenparcWeixinSetting.EncodingAESKey; //与微信公众账号后台的EncodingAESKey设置保持一致，区分大小写。

        public static readonly string AppId = Config.SenparcWeixinSetting.WeixinAppId; //与微信公众账号后台的AppId设置保持一致，区分大小写。
        public static readonly string AppSecret = Config.SenparcWeixinSetting.WeixinAppSecret; //与微信公众账号后台的AppId设置保持一致，区分大小写。

        readonly Func<string> _getRandomFileName = () =>
            SystemTime.Now.ToString("yyyyMMdd-HHmmss") + Guid.NewGuid().ToString("n").Substring(0, 6);

        SenparcWeixinSetting _senparcWeixinSetting;

        public OpenIdController(IOptions<SenparcWeixinSetting> senparcWeixinSetting)
        {
            _senparcWeixinSetting = senparcWeixinSetting.Value;
        }

        [HttpPost]
        public ActionResult Post(string code)
        {
            try
            {
                var result = OAuthApi.GetAccessToken(AppId, AppSecret, code);
                return Json(ReturnHelper.IsSuccessMsgDataHttpCode(true, "Successed", result));
            }
            catch
            {
                return Json(ReturnHelper.ErrorMsgEcodeElevelHttpCode("Failed"));
            }
        }

      
    }
}