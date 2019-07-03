using System;
using System.Collections.Generic;
using System.ComponentModel;
using XCode;
using XCode.Configuration;
using XCode.DataAccessLayer;

namespace Pig.Repository.Entity
{
    /// <summary>关注用户信息</summary>
    [Serializable]
    [DataObject]
    [Description("关注用户信息")]
    [BindIndex("IX_User_OpenId", false, "OpenId")]
    [BindTable("User", Description = "关注用户信息", ConnName = "Pig", DbType = DatabaseType.SqlServer)]
    public partial class User : IUser
    {
        #region 属性
        private Int32 _Id;
        /// <summary>编号</summary>
        [DisplayName("编号")]
        [Description("编号")]
        [DataObjectField(true, true, false, 0)]
        [BindColumn("Id", "编号", "int")]
        public Int32 Id { get { return _Id; } set { if (OnPropertyChanging(__.Id, value)) { _Id = value; OnPropertyChanged(__.Id); } } }

        private String _OpenId;
        /// <summary>关注者OpenId</summary>
        [DisplayName("关注者OpenId")]
        [Description("关注者OpenId")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("OpenId", "关注者OpenId", "nvarchar(50)")]
        public String OpenId { get { return _OpenId; } set { if (OnPropertyChanging(__.OpenId, value)) { _OpenId = value; OnPropertyChanged(__.OpenId); } } }

        private String _NickName;
        /// <summary>昵称</summary>
        [DisplayName("昵称")]
        [Description("昵称")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("NickName", "昵称", "nvarchar(50)")]
        public String NickName { get { return _NickName; } set { if (OnPropertyChanging(__.NickName, value)) { _NickName = value; OnPropertyChanged(__.NickName); } } }

        private Int32 _GroupId;
        /// <summary>分组编号</summary>
        [DisplayName("分组编号")]
        [Description("分组编号")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("GroupId", "分组编号", "int")]
        public Int32 GroupId { get { return _GroupId; } set { if (OnPropertyChanging(__.GroupId, value)) { _GroupId = value; OnPropertyChanged(__.GroupId); } } }

        private Int32 _Role;
        /// <summary>用户角色，屠宰场、运输、养殖户、</summary>
        [DisplayName("用户角色")]
        [Description("用户角色，屠宰场、运输、养殖户、")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("Role", "用户角色，屠宰场、运输、养殖户、", "int")]
        public Int32 Role { get { return _Role; } set { if (OnPropertyChanging(__.Role, value)) { _Role = value; OnPropertyChanged(__.Role); } } }

        private Int32 _IsFollow;
        /// <summary>是否关注</summary>
        [DisplayName("是否关注")]
        [Description("是否关注")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("IsFollow", "是否关注", "int")]
        public Int32 IsFollow { get { return _IsFollow; } set { if (OnPropertyChanging(__.IsFollow, value)) { _IsFollow = value; OnPropertyChanged(__.IsFollow); } } }

        private String _Name;
        /// <summary>名称</summary>
        [DisplayName("名称")]
        [Description("名称")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("Name", "名称", "nvarchar(50)", Master = true)]
        public String Name { get { return _Name; } set { if (OnPropertyChanging(__.Name, value)) { _Name = value; OnPropertyChanged(__.Name); } } }

        private String _Introduce;
        /// <summary>简介</summary>
        [DisplayName("简介")]
        [Description("简介")]
        [DataObjectField(false, false, true, 500)]
        [BindColumn("Introduce", "简介", "nvarchar(500)")]
        public String Introduce { get { return _Introduce; } set { if (OnPropertyChanging(__.Introduce, value)) { _Introduce = value; OnPropertyChanged(__.Introduce); } } }

        private String _MiniImg;
        /// <summary>缩略图</summary>
        [DisplayName("缩略图")]
        [Description("缩略图")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("MiniImg", "缩略图", "nvarchar(50)")]
        public String MiniImg { get { return _MiniImg; } set { if (OnPropertyChanging(__.MiniImg, value)) { _MiniImg = value; OnPropertyChanged(__.MiniImg); } } }

        private String _Mobile;
        /// <summary>手机</summary>
        [DisplayName("手机")]
        [Description("手机")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("Mobile", "手机", "nvarchar(50)")]
        public String Mobile { get { return _Mobile; } set { if (OnPropertyChanging(__.Mobile, value)) { _Mobile = value; OnPropertyChanged(__.Mobile); } } }

        private String _Contacts;
        /// <summary>联系人</summary>
        [DisplayName("联系人")]
        [Description("联系人")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("Contacts", "联系人", "nvarchar(50)")]
        public String Contacts { get { return _Contacts; } set { if (OnPropertyChanging(__.Contacts, value)) { _Contacts = value; OnPropertyChanged(__.Contacts); } } }

        private String _Address;
        /// <summary>地址</summary>
        [DisplayName("地址")]
        [Description("地址")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("Address", "地址", "nvarchar(50)")]
        public String Address { get { return _Address; } set { if (OnPropertyChanging(__.Address, value)) { _Address = value; OnPropertyChanged(__.Address); } } }

        private Int32 _State;
        /// <summary>状态</summary>
        [DisplayName("状态")]
        [Description("状态")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("State", "状态", "int")]
        public Int32 State { get { return _State; } set { if (OnPropertyChanging(__.State, value)) { _State = value; OnPropertyChanged(__.State); } } }

        private String _Password;
        /// <summary>密码</summary>
        [DisplayName("密码")]
        [Description("密码")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("Password", "密码", "nvarchar(50)")]
        public String Password { get { return _Password; } set { if (OnPropertyChanging(__.Password, value)) { _Password = value; OnPropertyChanged(__.Password); } } }

        private DateTime _FirstSubTime;
        /// <summary>首次关注时间</summary>
        [DisplayName("首次关注时间")]
        [Description("首次关注时间")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("FirstSubTime", "首次关注时间", "datetime")]
        public DateTime FirstSubTime { get { return _FirstSubTime; } set { if (OnPropertyChanging(__.FirstSubTime, value)) { _FirstSubTime = value; OnPropertyChanged(__.FirstSubTime); } } }

        private DateTime _LastSubTime;
        /// <summary>最近关注时间</summary>
        [DisplayName("最近关注时间")]
        [Description("最近关注时间")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("LastSubTime", "最近关注时间", "datetime")]
        public DateTime LastSubTime { get { return _LastSubTime; } set { if (OnPropertyChanging(__.LastSubTime, value)) { _LastSubTime = value; OnPropertyChanged(__.LastSubTime); } } }

        private DateTime _UnSubTime;
        /// <summary>最近取注时间</summary>
        [DisplayName("最近取注时间")]
        [Description("最近取注时间")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("UnSubTime", "最近取注时间", "datetime")]
        public DateTime UnSubTime { get { return _UnSubTime; } set { if (OnPropertyChanging(__.UnSubTime, value)) { _UnSubTime = value; OnPropertyChanged(__.UnSubTime); } } }

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

        private String _Tag;
        /// <summary>标签</summary>
        [DisplayName("标签")]
        [Description("标签")]
        [DataObjectField(false, false, true, 200)]
        [BindColumn("Tag", "标签", "nvarchar(200)")]
        public String Tag { get { return _Tag; } set { if (OnPropertyChanging(__.Tag, value)) { _Tag = value; OnPropertyChanged(__.Tag); } } }
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
                    case __.OpenId : return _OpenId;
                    case __.NickName : return _NickName;
                    case __.GroupId : return _GroupId;
                    case __.Role : return _Role;
                    case __.IsFollow : return _IsFollow;
                    case __.Name : return _Name;
                    case __.Introduce : return _Introduce;
                    case __.MiniImg : return _MiniImg;
                    case __.Mobile : return _Mobile;
                    case __.Contacts : return _Contacts;
                    case __.Address : return _Address;
                    case __.State : return _State;
                    case __.Password : return _Password;
                    case __.FirstSubTime : return _FirstSubTime;
                    case __.LastSubTime : return _LastSubTime;
                    case __.UnSubTime : return _UnSubTime;
                    case __.CreateTime : return _CreateTime;
                    case __.UpdateTime : return _UpdateTime;
                    case __.Tag : return _Tag;
                    default: return base[name];
                }
            }
            set
            {
                switch (name)
                {
                    case __.Id : _Id = Convert.ToInt32(value); break;
                    case __.OpenId : _OpenId = Convert.ToString(value); break;
                    case __.NickName : _NickName = Convert.ToString(value); break;
                    case __.GroupId : _GroupId = Convert.ToInt32(value); break;
                    case __.Role : _Role = Convert.ToInt32(value); break;
                    case __.IsFollow : _IsFollow = Convert.ToInt32(value); break;
                    case __.Name : _Name = Convert.ToString(value); break;
                    case __.Introduce : _Introduce = Convert.ToString(value); break;
                    case __.MiniImg : _MiniImg = Convert.ToString(value); break;
                    case __.Mobile : _Mobile = Convert.ToString(value); break;
                    case __.Contacts : _Contacts = Convert.ToString(value); break;
                    case __.Address : _Address = Convert.ToString(value); break;
                    case __.State : _State = Convert.ToInt32(value); break;
                    case __.Password : _Password = Convert.ToString(value); break;
                    case __.FirstSubTime : _FirstSubTime = Convert.ToDateTime(value); break;
                    case __.LastSubTime : _LastSubTime = Convert.ToDateTime(value); break;
                    case __.UnSubTime : _UnSubTime = Convert.ToDateTime(value); break;
                    case __.CreateTime : _CreateTime = Convert.ToDateTime(value); break;
                    case __.UpdateTime : _UpdateTime = Convert.ToDateTime(value); break;
                    case __.Tag : _Tag = Convert.ToString(value); break;
                    default: base[name] = value; break;
                }
            }
        }
        #endregion

        #region 字段名
        /// <summary>取得关注用户信息字段信息的快捷方式</summary>
        public partial class _
        {
            /// <summary>编号</summary>
            public static readonly Field Id = FindByName(__.Id);

            /// <summary>关注者OpenId</summary>
            public static readonly Field OpenId = FindByName(__.OpenId);

            /// <summary>昵称</summary>
            public static readonly Field NickName = FindByName(__.NickName);

            /// <summary>分组编号</summary>
            public static readonly Field GroupId = FindByName(__.GroupId);

            /// <summary>用户角色，屠宰场、运输、养殖户、</summary>
            public static readonly Field Role = FindByName(__.Role);

            /// <summary>是否关注</summary>
            public static readonly Field IsFollow = FindByName(__.IsFollow);

            /// <summary>名称</summary>
            public static readonly Field Name = FindByName(__.Name);

            /// <summary>简介</summary>
            public static readonly Field Introduce = FindByName(__.Introduce);

            /// <summary>缩略图</summary>
            public static readonly Field MiniImg = FindByName(__.MiniImg);

            /// <summary>手机</summary>
            public static readonly Field Mobile = FindByName(__.Mobile);

            /// <summary>联系人</summary>
            public static readonly Field Contacts = FindByName(__.Contacts);

            /// <summary>地址</summary>
            public static readonly Field Address = FindByName(__.Address);

            /// <summary>状态</summary>
            public static readonly Field State = FindByName(__.State);

            /// <summary>密码</summary>
            public static readonly Field Password = FindByName(__.Password);

            /// <summary>首次关注时间</summary>
            public static readonly Field FirstSubTime = FindByName(__.FirstSubTime);

            /// <summary>最近关注时间</summary>
            public static readonly Field LastSubTime = FindByName(__.LastSubTime);

            /// <summary>最近取注时间</summary>
            public static readonly Field UnSubTime = FindByName(__.UnSubTime);

            /// <summary>创建时间</summary>
            public static readonly Field CreateTime = FindByName(__.CreateTime);

            /// <summary>更新时间</summary>
            public static readonly Field UpdateTime = FindByName(__.UpdateTime);

            /// <summary>标签</summary>
            public static readonly Field Tag = FindByName(__.Tag);

            static Field FindByName(String name) { return Meta.Table.FindByName(name); }
        }

        /// <summary>取得关注用户信息字段名称的快捷方式</summary>
        public partial class __
        {
            /// <summary>编号</summary>
            public const String Id = "Id";

            /// <summary>关注者OpenId</summary>
            public const String OpenId = "OpenId";

            /// <summary>昵称</summary>
            public const String NickName = "NickName";

            /// <summary>分组编号</summary>
            public const String GroupId = "GroupId";

            /// <summary>用户角色，屠宰场、运输、养殖户、</summary>
            public const String Role = "Role";

            /// <summary>是否关注</summary>
            public const String IsFollow = "IsFollow";

            /// <summary>名称</summary>
            public const String Name = "Name";

            /// <summary>简介</summary>
            public const String Introduce = "Introduce";

            /// <summary>缩略图</summary>
            public const String MiniImg = "MiniImg";

            /// <summary>手机</summary>
            public const String Mobile = "Mobile";

            /// <summary>联系人</summary>
            public const String Contacts = "Contacts";

            /// <summary>地址</summary>
            public const String Address = "Address";

            /// <summary>状态</summary>
            public const String State = "State";

            /// <summary>密码</summary>
            public const String Password = "Password";

            /// <summary>首次关注时间</summary>
            public const String FirstSubTime = "FirstSubTime";

            /// <summary>最近关注时间</summary>
            public const String LastSubTime = "LastSubTime";

            /// <summary>最近取注时间</summary>
            public const String UnSubTime = "UnSubTime";

            /// <summary>创建时间</summary>
            public const String CreateTime = "CreateTime";

            /// <summary>更新时间</summary>
            public const String UpdateTime = "UpdateTime";

            /// <summary>标签</summary>
            public const String Tag = "Tag";
        }
        #endregion
    }

    /// <summary>关注用户信息接口</summary>
    public partial interface IUser
    {
        #region 属性
        /// <summary>编号</summary>
        Int32 Id { get; set; }

        /// <summary>关注者OpenId</summary>
        String OpenId { get; set; }

        /// <summary>昵称</summary>
        String NickName { get; set; }

        /// <summary>分组编号</summary>
        Int32 GroupId { get; set; }

        /// <summary>用户角色，屠宰场、运输、养殖户、</summary>
        Int32 Role { get; set; }

        /// <summary>是否关注</summary>
        Int32 IsFollow { get; set; }

        /// <summary>名称</summary>
        String Name { get; set; }

        /// <summary>简介</summary>
        String Introduce { get; set; }

        /// <summary>缩略图</summary>
        String MiniImg { get; set; }

        /// <summary>手机</summary>
        String Mobile { get; set; }

        /// <summary>联系人</summary>
        String Contacts { get; set; }

        /// <summary>地址</summary>
        String Address { get; set; }

        /// <summary>状态</summary>
        Int32 State { get; set; }

        /// <summary>密码</summary>
        String Password { get; set; }

        /// <summary>首次关注时间</summary>
        DateTime FirstSubTime { get; set; }

        /// <summary>最近关注时间</summary>
        DateTime LastSubTime { get; set; }

        /// <summary>最近取注时间</summary>
        DateTime UnSubTime { get; set; }

        /// <summary>创建时间</summary>
        DateTime CreateTime { get; set; }

        /// <summary>更新时间</summary>
        DateTime UpdateTime { get; set; }

        /// <summary>标签</summary>
        String Tag { get; set; }
        #endregion

        #region 获取/设置 字段值
        /// <summary>获取/设置 字段值</summary>
        /// <param name="name">字段名</param>
        /// <returns></returns>
        Object this[String name] { get; set; }
        #endregion
    }
}