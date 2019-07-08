using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using NewLife.Cube;
using Senparc.Weixin;
using Senparc.Weixin.MP.AdvancedAPIs;

namespace CubeApi.Controllers
{

    [Route("api/[controller]")]
    [EnableCors("AllowSpecificOrigin")]
    public class WxPicturesController : Controller
    {
        private IHostingEnvironment hostingEnv;

        string[] pictureFormatArray =
            {"png", "jpg", "jpeg", "bmp", "gif", "ico", "PNG", "JPG", "JPEG", "BMP", "GIF", "ICO"};

        public WxPicturesController(IHostingEnvironment env)
        {
            this.hostingEnv = env;
        }

        public IActionResult Get()
        {
            return Json(ReturnHelper.SuccessMsgDataDCountHttpCode("接口已开启"));
        }
        [HttpPost]
        public IActionResult Post()
        {
          var  mediaId = Request.Form["mediaId"];

            var picType = Request.Form["picType"];

            string upLoadPath =Path.Combine( hostingEnv.WebRootPath, "wximg/");
            var path= MediaApi.Get(Config.SenparcWeixinSetting.WeixinAppId, mediaId, upLoadPath);
            path="/wximg/"+ Path.GetFileName(path);
            return Json(ReturnHelper.SuccessMsgDataDCountHttpCode("success", path));
        }

    }
}
