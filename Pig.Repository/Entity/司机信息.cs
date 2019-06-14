using System;
using System.Collections.Generic;
using System.ComponentModel;
using XCode;
using XCode.Configuration;
using XCode.DataAccessLayer;

namespace Pig.Repository.Entity
{
    /// <summary>司机信息</summary>
    [Serializable]
    [DataObject]
    [Description("司机信息")]
    [BindIndex("IX_Driver_Name", false, "Name")]
    [BindTable("Driver", Description = "司机信息", ConnName = "Pig", DbType = DatabaseType.SqlServer)]
    public partial class Driver : IDriver
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

        private String _Name;
        /// <summary>名称</summary>
        [DisplayName("名称")]
        [Description("名称")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("Name", "名称", "nvarchar(50)", Master = true)]
        public String Name { get { return _Name; } set { if (OnPropertyChanging(__.Name, value)) { _Name = value; OnPropertyChanged(__.Name); } } }

        private String _Introduce;
        /// <summary>司机介绍</summary>
        [DisplayName("司机介绍")]
        [Description("司机介绍")]
        [DataObjectField(false, false, true, 500)]
        [BindColumn("Introduce", "司机介绍", "nvarchar(500)")]
        public String Introduce { get { return _Introduce; } set { if (OnPropertyChanging(__.Introduce, value)) { _Introduce = value; OnPropertyChanged(__.Introduce); } } }

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

        private Int32 _CreateUserID;
        /// <summary>创建者</summary>
        [DisplayName("创建者")]
        [Description("创建者")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("CreateUserID", "创建者", "int")]
        public Int32 CreateUserID { get { return _CreateUserID; } set { if (OnPropertyChanging(__.CreateUserID, value)) { _CreateUserID = value; OnPropertyChanged(__.CreateUserID); } } }

        private DateTime _CreateTime;
        /// <summary>创建时间</summary>
        [DisplayName("创建时间")]
        [Description("创建时间")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("CreateTime", "创建时间", "datetime")]
        public DateTime CreateTime { get { return _CreateTime; } set { if (OnPropertyChanging(__.CreateTime, value)) { _CreateTime = value; OnPropertyChanged(__.CreateTime); } } }

        private String _CreateIP;
        /// <summary>创建地址</summary>
        [DisplayName("创建地址")]
        [Description("创建地址")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("CreateIP", "创建地址", "nvarchar(50)")]
        public String CreateIP { get { return _CreateIP; } set { if (OnPropertyChanging(__.CreateIP, value)) { _CreateIP = value; OnPropertyChanged(__.CreateIP); } } }

        private Int32 _UpdateUserID;
        /// <summary>更新者</summary>
        [DisplayName("更新者")]
        [Description("更新者")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("UpdateUserID", "更新者", "int")]
        public Int32 UpdateUserID { get { return _UpdateUserID; } set { if (OnPropertyChanging(__.UpdateUserID, value)) { _UpdateUserID = value; OnPropertyChanged(__.UpdateUserID); } } }

        private DateTime _UpdateTime;
        /// <summary>更新时间</summary>
        [DisplayName("更新时间")]
        [Description("更新时间")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("UpdateTime", "更新时间", "datetime")]
        public DateTime UpdateTime { get { return _UpdateTime; } set { if (OnPropertyChanging(__.UpdateTime, value)) { _UpdateTime = value; OnPropertyChanged(__.UpdateTime); } } }

        private String _UpdateIP;
        /// <summary>更新地址</summary>
        [DisplayName("更新地址")]
        [Description("更新地址")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("UpdateIP", "更新地址", "nvarchar(50)")]
        public String UpdateIP { get { return _UpdateIP; } set { if (OnPropertyChanging(__.UpdateIP, value)) { _UpdateIP = value; OnPropertyChanged(__.UpdateIP); } } }
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
                    case __.Name : return _Name;
                    case __.Introduce : return _Introduce;
                    case __.Mobile : return _Mobile;
                    case __.Contacts : return _Contacts;
                    case __.Address : return _Address;
                    case __.State : return _State;
                    case __.CreateUserID : return _CreateUserID;
                    case __.CreateTime : return _CreateTime;
                    case __.CreateIP : return _CreateIP;
                    case __.UpdateUserID : return _UpdateUserID;
                    case __.UpdateTime : return _UpdateTime;
                    case __.UpdateIP : return _UpdateIP;
                    default: return base[name];
                }
            }
            set
            {
                switch (name)
                {
                    case __.Id : _Id = Convert.ToInt32(value); break;
                    case __.OpenId : _OpenId = Convert.ToString(value); break;
                    case __.Name : _Name = Convert.ToString(value); break;
                    case __.Introduce : _Introduce = Convert.ToString(value); break;
                    case __.Mobile : _Mobile = Convert.ToString(value); break;
                    case __.Contacts : _Contacts = Convert.ToString(value); break;
                    case __.Address : _Address = Convert.ToString(value); break;
                    case __.State : _State = Convert.ToInt32(value); break;
                    case __.CreateUserID : _CreateUserID = Convert.ToInt32(value); break;
                    case __.CreateTime : _CreateTime = Convert.ToDateTime(value); break;
                    case __.CreateIP : _CreateIP = Convert.ToString(value); break;
                    case __.UpdateUserID : _UpdateUserID = Convert.ToInt32(value); break;
                    case __.UpdateTime : _UpdateTime = Convert.ToDateTime(value); break;
                    case __.UpdateIP : _UpdateIP = Convert.ToString(value); break;
                    default: base[name] = value; break;
                }
            }
        }
        #endregion

        #region 字段名
        /// <summary>取得司机信息字段信息的快捷方式</summary>
        public partial class _
        {
            /// <summary>编号</summary>
            public static readonly Field Id = FindByName(__.Id);

            /// <summary>关注者OpenId</summary>
            public static readonly Field OpenId = FindByName(__.OpenId);

            /// <summary>名称</summary>
            public static readonly Field Name = FindByName(__.Name);

            /// <summary>司机介绍</summary>
            public static readonly Field Introduce = FindByName(__.Introduce);

            /// <summary>手机</summary>
            public static readonly Field Mobile = FindByName(__.Mobile);

            /// <summary>联系人</summary>
            public static readonly Field Contacts = FindByName(__.Contacts);

            /// <summary>地址</summary>
            public static readonly Field Address = FindByName(__.Address);

            /// <summary>状态</summary>
            public static readonly Field State = FindByName(__.State);

            /// <summary>创建者</summary>
            public static readonly Field CreateUserID = FindByName(__.CreateUserID);

            /// <summary>创建时间</summary>
            public static readonly Field CreateTime = FindByName(__.CreateTime);

            /// <summary>创建地址</summary>
            public static readonly Field CreateIP = FindByName(__.CreateIP);

            /// <summary>更新者</summary>
            public static readonly Field UpdateUserID = FindByName(__.UpdateUserID);

            /// <summary>更新时间</summary>
            public static readonly Field UpdateTime = FindByName(__.UpdateTime);

            /// <summary>更新地址</summary>
            public static readonly Field UpdateIP = FindByName(__.UpdateIP);

            static Field FindByName(String name) { return Meta.Table.FindByName(name); }
        }

        /// <summary>取得司机信息字段名称的快捷方式</summary>
        public partial class __
        {
            /// <summary>编号</summary>
            public const String Id = "Id";

            /// <summary>关注者OpenId</summary>
            public const String OpenId = "OpenId";

            /// <summary>名称</summary>
            public const String Name = "Name";

            /// <summary>司机介绍</summary>
            public const String Introduce = "Introduce";

            /// <summary>手机</summary>
            public const String Mobile = "Mobile";

            /// <summary>联系人</summary>
            public const String Contacts = "Contacts";

            /// <summary>地址</summary>
            public const String Address = "Address";

            /// <summary>状态</summary>
            public const String State = "State";

            /// <summary>创建者</summary>
            public const String CreateUserID = "CreateUserID";

            /// <summary>创建时间</summary>
            public const String CreateTime = "CreateTime";

            /// <summary>创建地址</summary>
            public const String CreateIP = "CreateIP";

            /// <summary>更新者</summary>
            public const String UpdateUserID = "UpdateUserID";

            /// <summary>更新时间</summary>
            public const String UpdateTime = "UpdateTime";

            /// <summary>更新地址</summary>
            public const String UpdateIP = "UpdateIP";
        }
        #endregion
    }

    /// <summary>司机信息接口</summary>
    public partial interface IDriver
    {
        #region 属性
        /// <summary>编号</summary>
        Int32 Id { get; set; }

        /// <summary>关注者OpenId</summary>
        String OpenId { get; set; }

        /// <summary>名称</summary>
        String Name { get; set; }

        /// <summary>司机介绍</summary>
        String Introduce { get; set; }

        /// <summary>手机</summary>
        String Mobile { get; set; }

        /// <summary>联系人</summary>
        String Contacts { get; set; }

        /// <summary>地址</summary>
        String Address { get; set; }

        /// <summary>状态</summary>
        Int32 State { get; set; }

        /// <summary>创建者</summary>
        Int32 CreateUserID { get; set; }

        /// <summary>创建时间</summary>
        DateTime CreateTime { get; set; }

        /// <summary>创建地址</summary>
        String CreateIP { get; set; }

        /// <summary>更新者</summary>
        Int32 UpdateUserID { get; set; }

        /// <summary>更新时间</summary>
        DateTime UpdateTime { get; set; }

        /// <summary>更新地址</summary>
        String UpdateIP { get; set; }
        #endregion

        #region 获取/设置 字段值
        /// <summary>获取/设置 字段值</summary>
        /// <param name="name">字段名</param>
        /// <returns></returns>
        Object this[String name] { get; set; }
        #endregion
    }
}