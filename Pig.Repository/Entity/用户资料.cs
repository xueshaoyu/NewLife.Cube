using System;
using System.Collections.Generic;
using System.ComponentModel;
using XCode;
using XCode.Configuration;
using XCode.DataAccessLayer;

namespace Pig.Repository.Entity
{
    /// <summary>用户资料</summary>
    [Serializable]
    [DataObject]
    [Description("用户资料")]
    [BindTable("UserData", Description = "用户资料", ConnName = "Pig", DbType = DatabaseType.SqlServer)]
    public partial class UserData : IUserData
    {
        #region 属性
        private Int32 _Id;
        /// <summary>编号</summary>
        [DisplayName("编号")]
        [Description("编号")]
        [DataObjectField(true, true, false, 0)]
        [BindColumn("Id", "编号", "int")]
        public Int32 Id { get { return _Id; } set { if (OnPropertyChanging(__.Id, value)) { _Id = value; OnPropertyChanged(__.Id); } } }

        private Int32 _UserId;
        /// <summary>用户编号</summary>
        [DisplayName("用户编号")]
        [Description("用户编号")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("UserId", "用户编号", "int")]
        public Int32 UserId { get { return _UserId; } set { if (OnPropertyChanging(__.UserId, value)) { _UserId = value; OnPropertyChanged(__.UserId); } } }

        private Int32 _Sex;
        /// <summary>性别</summary>
        [DisplayName("性别")]
        [Description("性别")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("Sex", "性别", "int")]
        public Int32 Sex { get { return _Sex; } set { if (OnPropertyChanging(__.Sex, value)) { _Sex = value; OnPropertyChanged(__.Sex); } } }

        private String _City;
        /// <summary>城市</summary>
        [DisplayName("城市")]
        [Description("城市")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("City", "城市", "nvarchar(50)")]
        public String City { get { return _City; } set { if (OnPropertyChanging(__.City, value)) { _City = value; OnPropertyChanged(__.City); } } }

        private String _Country;
        /// <summary>国家</summary>
        [DisplayName("国家")]
        [Description("国家")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("Country", "国家", "nvarchar(50)")]
        public String Country { get { return _Country; } set { if (OnPropertyChanging(__.Country, value)) { _Country = value; OnPropertyChanged(__.Country); } } }

        private String _Province;
        /// <summary>省份</summary>
        [DisplayName("省份")]
        [Description("省份")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("Province", "省份", "nvarchar(50)")]
        public String Province { get { return _Province; } set { if (OnPropertyChanging(__.Province, value)) { _Province = value; OnPropertyChanged(__.Province); } } }

        private DateTime _Language;
        /// <summary>语言</summary>
        [DisplayName("语言")]
        [Description("语言")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("Language", "语言", "datetime")]
        public DateTime Language { get { return _Language; } set { if (OnPropertyChanging(__.Language, value)) { _Language = value; OnPropertyChanged(__.Language); } } }

        private String _Avatar;
        /// <summary>头像</summary>
        [DisplayName("头像")]
        [Description("头像")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("Avatar", "头像", "nvarchar(50)")]
        public String Avatar { get { return _Avatar; } set { if (OnPropertyChanging(__.Avatar, value)) { _Avatar = value; OnPropertyChanged(__.Avatar); } } }

        private DateTime _CreateTime;
        /// <summary>创建时间</summary>
        [DisplayName("创建时间")]
        [Description("创建时间")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("CreateTime", "创建时间", "datetime")]
        public DateTime CreateTime { get { return _CreateTime; } set { if (OnPropertyChanging(__.CreateTime, value)) { _CreateTime = value; OnPropertyChanged(__.CreateTime); } } }

        private DateTime _UpdateTime;
        /// <summary>更新时间</summary>
        [DisplayName("更新时间")]
        [Description("更新时间")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("UpdateTime", "更新时间", "datetime")]
        public DateTime UpdateTime { get { return _UpdateTime; } set { if (OnPropertyChanging(__.UpdateTime, value)) { _UpdateTime = value; OnPropertyChanged(__.UpdateTime); } } }

        private String _Remark;
        /// <summary>备注</summary>
        [DisplayName("备注")]
        [Description("备注")]
        [DataObjectField(false, false, true, 200)]
        [BindColumn("Remark", "备注", "nvarchar(200)")]
        public String Remark { get { return _Remark; } set { if (OnPropertyChanging(__.Remark, value)) { _Remark = value; OnPropertyChanged(__.Remark); } } }
        #endregion

        #region 获取/设置 字段值
        /// <summary>获取/设置 字段值</summary>
        /// <param name="name">字段名</param>
        /// <returns></returns>
        public override Object this[String name]
        {
            get
            {
                switch (name)
                {
                    case __.Id : return _Id;
                    case __.UserId : return _UserId;
                    case __.Sex : return _Sex;
                    case __.City : return _City;
                    case __.Country : return _Country;
                    case __.Province : return _Province;
                    case __.Language : return _Language;
                    case __.Avatar : return _Avatar;
                    case __.CreateTime : return _CreateTime;
                    case __.UpdateTime : return _UpdateTime;
                    case __.Remark : return _Remark;
                    default: return base[name];
                }
            }
            set
            {
                switch (name)
                {
                    case __.Id : _Id = Convert.ToInt32(value); break;
                    case __.UserId : _UserId = Convert.ToInt32(value); break;
                    case __.Sex : _Sex = Convert.ToInt32(value); break;
                    case __.City : _City = Convert.ToString(value); break;
                    case __.Country : _Country = Convert.ToString(value); break;
                    case __.Province : _Province = Convert.ToString(value); break;
                    case __.Language : _Language = Convert.ToDateTime(value); break;
                    case __.Avatar : _Avatar = Convert.ToString(value); break;
                    case __.CreateTime : _CreateTime = Convert.ToDateTime(value); break;
                    case __.UpdateTime : _UpdateTime = Convert.ToDateTime(value); break;
                    case __.Remark : _Remark = Convert.ToString(value); break;
                    default: base[name] = value; break;
                }
            }
        }
        #endregion

        #region 字段名
        /// <summary>取得用户资料字段信息的快捷方式</summary>
        public partial class _
        {
            /// <summary>编号</summary>
            public static readonly Field Id = FindByName(__.Id);

            /// <summary>用户编号</summary>
            public static readonly Field UserId = FindByName(__.UserId);

            /// <summary>性别</summary>
            public static readonly Field Sex = FindByName(__.Sex);

            /// <summary>城市</summary>
            public static readonly Field City = FindByName(__.City);

            /// <summary>国家</summary>
            public static readonly Field Country = FindByName(__.Country);

            /// <summary>省份</summary>
            public static readonly Field Province = FindByName(__.Province);

            /// <summary>语言</summary>
            public static readonly Field Language = FindByName(__.Language);

            /// <summary>头像</summary>
            public static readonly Field Avatar = FindByName(__.Avatar);

            /// <summary>创建时间</summary>
            public static readonly Field CreateTime = FindByName(__.CreateTime);

            /// <summary>更新时间</summary>
            public static readonly Field UpdateTime = FindByName(__.UpdateTime);

            /// <summary>备注</summary>
            public static readonly Field Remark = FindByName(__.Remark);

            static Field FindByName(String name) { return Meta.Table.FindByName(name); }
        }

        /// <summary>取得用户资料字段名称的快捷方式</summary>
        public partial class __
        {
            /// <summary>编号</summary>
            public const String Id = "Id";

            /// <summary>用户编号</summary>
            public const String UserId = "UserId";

            /// <summary>性别</summary>
            public const String Sex = "Sex";

            /// <summary>城市</summary>
            public const String City = "City";

            /// <summary>国家</summary>
            public const String Country = "Country";

            /// <summary>省份</summary>
            public const String Province = "Province";

            /// <summary>语言</summary>
            public const String Language = "Language";

            /// <summary>头像</summary>
            public const String Avatar = "Avatar";

            /// <summary>创建时间</summary>
            public const String CreateTime = "CreateTime";

            /// <summary>更新时间</summary>
            public const String UpdateTime = "UpdateTime";

            /// <summary>备注</summary>
            public const String Remark = "Remark";
        }
        #endregion
    }

    /// <summary>用户资料接口</summary>
    public partial interface IUserData
    {
        #region 属性
        /// <summary>编号</summary>
        Int32 Id { get; set; }

        /// <summary>用户编号</summary>
        Int32 UserId { get; set; }

        /// <summary>性别</summary>
        Int32 Sex { get; set; }

        /// <summary>城市</summary>
        String City { get; set; }

        /// <summary>国家</summary>
        String Country { get; set; }

        /// <summary>省份</summary>
        String Province { get; set; }

        /// <summary>语言</summary>
        DateTime Language { get; set; }

        /// <summary>头像</summary>
        String Avatar { get; set; }

        /// <summary>创建时间</summary>
        DateTime CreateTime { get; set; }

        /// <summary>更新时间</summary>
        DateTime UpdateTime { get; set; }

        /// <summary>备注</summary>
        String Remark { get; set; }
        #endregion

        #region 获取/设置 字段值
        /// <summary>获取/设置 字段值</summary>
        /// <param name="name">字段名</param>
        /// <returns></returns>
        Object this[String name] { get; set; }
        #endregion
    }
}