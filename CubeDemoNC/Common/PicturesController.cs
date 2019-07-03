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

namespace CubeApi.Controllers
{

    [Route("api/[controller]")]
    [EnableCors("AllowSpecificOrigin")]
    public class PicturesController : Controller
    {
        private IHostingEnvironment hostingEnv;

        string[] pictureFormatArray =
            {"png", "jpg", "jpeg", "bmp", "gif", "ico", "PNG", "JPG", "JPEG", "BMP", "GIF", "ICO"};

        public PicturesController(IHostingEnvironment env)
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
            var files = Request.Form.Files;
            long size = files.Sum(f => f.Length);

            //size > 100MB refuse upload !
            if (size > 104857600)
            {
                return Json(
                    ReturnHelper.ErrorMsgEcodeElevelHttpCode("pictures total size > 100MB , server refused !"));
            }

            List<string> filePathResultList = new List<string>();

            foreach (var file in files)
            {
                var fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');

                string filePath = hostingEnv.WebRootPath + $@"\Files\Pictures\";

                if (!Directory.Exists(filePath))
                {
                    Directory.CreateDirectory(filePath);
                }

                string suffix = fileName.Split('.')[1];

                if (!pictureFormatArray.Contains(suffix))
                {
                    return Json(ReturnHelper.ErrorMsgEcodeElevelHttpCode(
                        "the picture format not support ! you must upload files that suffix like 'png','jpg','jpeg','bmp','gif','ico'."));
                }

                fileName = Guid.NewGuid() + "." + suffix;

                string fileFullName = filePath + fileName;

                using (FileStream fs = System.IO.File.Create(fileFullName))
                {
                    file.CopyTo(fs);
                    fs.Flush();
                }

                filePathResultList.Add($"/src/Pictures/{fileName}");
            }

            string message = $"{files.Count} file(s) /{size} bytes uploaded successfully!";

            return Json(ReturnHelper.SuccessMsgDataDCountHttpCode(message, filePathResultList,
                filePathResultList.Count));
        }

    }
}
