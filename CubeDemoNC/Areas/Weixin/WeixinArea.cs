using System;
using System.ComponentModel;
using NewLife.Cube;

namespace WebTest.Areas.Weixin
{
    [DisplayName("微信管理系统")]
    public class WeixinArea : AreaBase
    {
        public WeixinArea() : base(nameof(WeixinArea).TrimEnd("Area")) { }

        static WeixinArea() => RegisterArea<WeixinArea>();
    }
}