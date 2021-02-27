﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NewLife.Http;

namespace NewLife.Web.OAuth
{
    /// <summary>微软身份验证提供者</summary>
    /// <remarks>
    /// 参考文档 https://docs.microsoft.com/zh-cn/azure/active-directory/develop/v2-oauth2-auth-code-flow
    /// </remarks>
    public class MicrosoftClient : OAuthClient
    {
        #region 属性
        /// <summary>租户。默认common</summary>
        /// <remarks>
        /// 请求路径中的 {tenant} 值可用于控制哪些用户可以登录应用程序。 可以使用的值包括 common、organizations、consumers 和租户标识符。
        /// </remarks>
        public String Tenant { get; set; } = "common";
        #endregion

        /// <summary>实例化</summary>
        public MicrosoftClient()
        {
            Server = "https://login.microsoftonline.com/{tenant}/oauth2/v2.0/";

            AuthUrl = "authorize?response_type={response_type}&client_id={key}&redirect_uri={redirect}&state={state}&scope={scope}";
            AccessUrl = "token?grant_type=authorization_code&client_id={key}&client_secret={secret}&code={code}&state={state}&redirect_uri={redirect}";

            //Scope = HttpUtility.UrlEncode("https://graph.microsoft.com/user.read");
            //Scope = "https%3A%2F%2Fgraph.microsoft.com%2Fmail.read%20api%3A%2F%2F";
            Scope = "openid profile email";
        }

        /// <summary>应用参数</summary>
        /// <param name="mi"></param>
        public override void Apply(NewLife.Cube.Entity.OAuthConfig mi)
        {
            base.Apply(mi);

            SetMode(Scope);
        }

        /// <summary>设置工作模式</summary>
        /// <param name="mode"></param>
        public virtual void SetMode(String mode)
        {
            switch (mode)
            {
                // 扫码登录
                case "snsapi_login":
                    AuthUrl = "qrconnect?response_type={response_type}&appid={key}&redirect_uri={redirect}&state={state}&scope={scope}";
                    Scope = mode;
                    break;
                // 静默授权，用户无感知
                case "snsapi_base":
                    AuthUrl = "authorize?response_type={response_type}&appid={key}&redirect_uri={redirect}&state={state}&scope={scope}#wechat_redirect";
                    Scope = mode;
                    break;
                // 授权需要用户手动同意
                case "snsapi_userinfo":
                    AuthUrl = "authorize?response_type={response_type}&appid={key}&redirect_uri={redirect}&state={state}&scope={scope}#wechat_redirect";
                    Scope = mode;
                    break;
            }
        }

        /// <summary>是否支持指定用户端，也就是判断是否在特定应用内打开，例如QQ/DingDing/WeiXin</summary>
        /// <param name="userAgent"></param>
        /// <returns></returns>
        public override Boolean Support(String userAgent) =>
            !userAgent.IsNullOrEmpty() &&
            (userAgent.Contains(" MicroMessenger/") || userAgent.Contains(" MICROMESSENGER/")) &&
            (userAgent.Contains(" WeChat/") || userAgent.Contains(" Weixin/") || userAgent.Contains("WINDOWS PHONE"));

        /// <summary>针对指定客户端进行初始化</summary>
        /// <param name="userAgent"></param>
        public override void Init(String userAgent)
        {
            // 应用内打开时，自动切换为应用内免登
            if (Support(userAgent))
            {
                Scope = "snsapi_userinfo";
                SetMode(Scope);
            }
        }

        /// <summary>发起请求，获取内容</summary>
        /// <param name="action"></param>
        /// <param name="url"></param>
        /// <returns></returns>
        protected override String GetHtml(String action, String url)
        {
            if (action == nameof(GetAccessToken))
            {
                var p = url.IndexOf('?');
                var dic = url.Substring(p + 1).SplitAsDictionary("=", "&").ToDictionary(e => e.Key, e => HttpUtility.UrlDecode(e.Value));
                url = url.Substring(0, p);

                var client = GetClient();
                var html = client.PostFormAsync(url, dic).Result;
                if (html.IsNullOrEmpty()) return null;

                html = html.Trim();
                if (Log != null && Log.Enable) WriteLog(html);

                return html;
            }

            return base.GetHtml(action, url);
        }

        /// <summary>从响应数据中获取信息</summary>
        /// <param name="dic"></param>
        protected override void OnGetInfo(IDictionary<String, String> dic)
        {
            base.OnGetInfo(dic);

            if (dic.TryGetValue("headimgurl", out var str)) Avatar = str.Trim();
        }

        /// <summary>获取Url，替换变量</summary>
        /// <param name="url"></param>
        /// <returns></returns>
        protected override String GetUrl(String url) => base.GetUrl(url).Replace("{tenant}", Tenant);
    }
}