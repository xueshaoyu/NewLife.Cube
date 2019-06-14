using System;
using System.Collections.Generic;
using System.ComponentModel;
using XCode;
using XCode.Configuration;
using XCode.DataAccessLayer;

namespace Pig.Repository.Entity
{
    /// <summary>自定义菜单表</summary>
    [Serializable]
    [DataObject]
    [Description("自定义菜单表")]
    [BindTable("PersonalMenu", Description = "自定义菜单表", ConnName = "Pig", DbType = DatabaseType.SqlServer)]
    public partial class PersonalMenu : IPersonalMenu
    {
        #region 属性
        private Int32 _Id;
        /// <summary>编号</summary>
        [DisplayName("编号")]
        [Description("编号")]
        [DataObjectField(true, true, false, 0)]
        [BindColumn("Id", "编号", "int")]
        public Int32 Id { get { return _Id; } set { if (OnPropertyChanging(__.Id, value)) { _Id = value; OnPropertyChanged(__.Id); } } }

        private String _Name;
        /// <summary>名称</summary>
        [DisplayName("名称")]
        [Description("名称")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("Name", "名称", "nvarchar(50)", Master = true)]
        public String Name { get { return _Name; } set { if (OnPropertyChanging(__.Name, value)) { _Name = value; OnPropertyChanged(__.Name); } } }

        private Int32 _Type;
        /// <summary>类型</summary>
        [DisplayName("类型")]
        [Description("类型")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("Type", "类型", "int")]
        public Int32 Type { get { return _Type; } set { if (OnPropertyChanging(__.Type, value)) { _Type = value; OnPropertyChanged(__.Type); } } }

        private Int32 _ParentId;
        /// <summary>父级菜单</summary>
        [DisplayName("父菜单")]
        [Description("父菜单")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("ParentId", "父菜单", "int")]
        public Int32 ParentId { get { return _ParentId; } set { if (OnPropertyChanging(__.ParentId, value)) { _ParentId = value; OnPropertyChanged(__.ParentId); } } }

        private Int32 _IndexLevel;
        /// <summary>当前级别</summary>
        [DisplayName("当前级别")]
        [Description("当前级别")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("IndexLevel", "当前级别", "int")]
        public Int32 IndexLevel { get { return _IndexLevel; } set { if (OnPropertyChanging(__.IndexLevel, value)) { _IndexLevel = value; OnPropertyChanged(__.IndexLevel); } } }

        private Int32 _State;
        /// <summary>状态</summary>
        [DisplayName("状态")]
        [Description("状态")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("State", "状态", "int")]
        public Int32 State { get { return _State; } set { if (OnPropertyChanging(__.State, value)) { _State = value; OnPropertyChanged(__.State); } } }

        private String _LinkUrl;
        /// <summary>链接地址</summary>
        [DisplayName("链接地址")]
        [Description("链接地址")]
        [DataObjectField(false, false, true, 250)]
        [BindColumn("LinkUrl", "链接地址", "nvarchar(250)")]
        public String LinkUrl { get { return _LinkUrl; } set { if (OnPropertyChanging(__.LinkUrl, value)) { _LinkUrl = value; OnPropertyChanged(__.LinkUrl); } } }

        private Int32 _SOrder;
        /// <summary>排序</summary>
        [DisplayName("排序")]
        [Description("排序")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("SOrder", "排序", "int")]
        public Int32 SOrder { get { return _SOrder; } set { if (OnPropertyChanging(__.SOrder, value)) { _SOrder = value; OnPropertyChanged(__.SOrder); } } }

        private String _Remark;
        /// <summary>备注</summary>
        [DisplayName("备注")]
        [Description("备注")]
        [DataObjectField(false, false, true, 200)]
        [BindColumn("Remark", "备注", "nvarchar(200)")]
        public String Remark { get { return _Remark; } set { if (OnPropertyChanging(__.Remark, value)) { _Remark = value; OnPropertyChanged(__.Remark); } } }

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
                    case __.Name : return _Name;
                    case __.Type : return _Type;
                    case __.ParentId : return _ParentId;
                    case __.IndexLevel : return _IndexLevel;
                    case __.State : return _State;
                    case __.LinkUrl : return _LinkUrl;
                    case __.SOrder : return _SOrder;
                    case __.Remark : return _Remark;
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
                    case __.Name : _Name = Convert.ToString(value); break;
                    case __.Type : _Type = Convert.ToInt32(value); break;
                    case __.ParentId : _ParentId = Convert.ToInt32(value); break;
                    case __.IndexLevel : _IndexLevel = Convert.ToInt32(value); break;
                    case __.State : _State = Convert.ToInt32(value); break;
                    case __.LinkUrl : _LinkUrl = Convert.ToString(value); break;
                    case __.SOrder : _SOrder = Convert.ToInt32(value); break;
                    case __.Remark : _Remark = Convert.ToString(value); break;
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
        /// <summary>取得自定义菜单表字段信息的快捷方式</summary>
        public partial class _
        {
            /// <summary>编号</summary>
            public static readonly Field Id = FindByName(__.Id);

            /// <summary>名称</summary>
            public static readonly Field Name = FindByName(__.Name);

            /// <summary>类型</summary>
            public static readonly Field Type = FindByName(__.Type);

            /// <summary>父级菜单</summary>
            public static readonly Field ParentId = FindByName(__.ParentId);

            /// <summary>当前级别</summary>
            public static readonly Field IndexLevel = FindByName(__.IndexLevel);

            /// <summary>状态</summary>
            public static readonly Field State = FindByName(__.State);

            /// <summary>链接地址</summary>
            public static readonly Field LinkUrl = FindByName(__.LinkUrl);

            /// <summary>排序</summary>
            public static readonly Field SOrder = FindByName(__.SOrder);

            /// <summary>备注</summary>
            public static readonly Field Remark = FindByName(__.Remark);

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

        /// <summary>取得自定义菜单表字段名称的快捷方式</summary>
        public partial class __
        {
            /// <summary>编号</summary>
            public const String Id = "Id";

            /// <summary>名称</summary>
            public const String Name = "Name";

            /// <summary>类型</summary>
            public const String Type = "Type";

            /// <summary>父级菜单</summary>
            public const String ParentId = "ParentId";

            /// <summary>当前级别</summary>
            public const String IndexLevel = "IndexLevel";

            /// <summary>状态</summary>
            public const String State = "State";

            /// <summary>链接地址</summary>
            public const String LinkUrl = "LinkUrl";

            /// <summary>排序</summary>
            public const String SOrder = "SOrder";

            /// <summary>备注</summary>
            public const String Remark = "Remark";

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

    /// <summary>自定义菜单表接口</summary>
    public partial interface IPersonalMenu
    {
        #region 属性
        /// <summary>编号</summary>
        Int32 Id { get; set; }

        /// <summary>名称</summary>
        String Name { get; set; }

        /// <summary>类型</summary>
        Int32 Type { get; set; }

        /// <summary>父级菜单</summary>
        Int32 ParentId { get; set; }

        /// <summary>当前级别</summary>
        Int32 IndexLevel { get; set; }

        /// <summary>状态</summary>
        Int32 State { get; set; }

        /// <summary>链接地址</summary>
        String LinkUrl { get; set; }

        /// <summary>排序</summary>
        Int32 SOrder { get; set; }

        /// <summary>备注</summary>
        String Remark { get; set; }

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