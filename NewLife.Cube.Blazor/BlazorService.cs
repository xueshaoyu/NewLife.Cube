﻿using System.Reflection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Options;
using NewLife.Cube.Extensions;

namespace NewLife.Cube
{
    /// <summary>Tabler服务</summary>
    public static class BlazorService
    {
        /// <summary>使用魔方UI</summary>
        /// <param name="app"></param>
        /// <param name="env"></param>
        /// <returns></returns>
        public static IApplicationBuilder UseBlazor(this IApplicationBuilder app, IWebHostEnvironment env)
        {
            // 独立静态文件设置，魔方自己的静态资源内嵌在程序集里面
            var options = new StaticFileOptions();
            {
                var embeddedProvider = new CubeEmbeddedFileProvider(Assembly.GetExecutingAssembly(), "NewLife.Cube.Blazor.wwwroot");
                options.FileProvider = embeddedProvider;
            }
            app.UseStaticFiles(options);

            app.UseEndpoints(endpoint =>
            {
                // Razor路由方案
                endpoint.MapRazorPages();
                // Blazor通信方案
                endpoint.MapBlazorHub();
            });

            return app;
        }
    }
}