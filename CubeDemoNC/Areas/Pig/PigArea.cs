using System;
using System.ComponentModel;
using NewLife.Cube;

namespace WebTest.Areas.Pig
{
    [DisplayName("后台管理系统")]
    public class PigArea : AreaBase
    {
        public PigArea() : base(nameof(PigArea).TrimEnd("Area")) { }

        static PigArea() => RegisterArea<PigArea>();
    }
}