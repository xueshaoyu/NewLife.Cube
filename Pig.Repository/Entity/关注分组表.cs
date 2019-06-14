using System;
using System.Collections.Generic;
using System.ComponentModel;
using XCode;
using XCode.Configuration;
using XCode.DataAccessLayer;

namespace Pig.Repository.Entity
{
    /// <summary>关注分组表</summary>
    [Serializable]
    [DataObject]
    [Description("关注分组表")]
    [BindTable("UserGroup", Description = "关注分组表", ConnName = "Pig", DbType = DatabaseType.SqlServer)]
    public partial class UserGroup : IUserGroup
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
        /// <summary>分组名-本地</summary>
        [DisplayName("分组名-本地")]
        [Description("分组名-本地")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("Name", "分组名-本地", "nvarchar(50)", Master = true)]
        public String Name { get { return _Name; } set { if (OnPropertyChanging(__.Name, value)) { _Name = value; OnPropertyChanged(__.Name); } } }

        private String _WxId;
        /// <summary>分组编号-微信</summary>
        [DisplayName("分组编号-微信")]
        [Description("分组编号-微信")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("WxId", "分组编号-微信", "nvarchar(50)")]
        public String WxId { get { return _WxId; } set { if (OnPropertyChanging(__.WxId, value)) { _WxId = value; OnPropertyChanged(__.WxId); } } }

        private String _WxName;
        /// <summary>分组名-微信</summary>
        [DisplayName("分组名-微信")]
        [Description("分组名-微信")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("WxName", "分组名-微信", "nvarchar(50)")]
        public String WxName { get { return _WxName; } set { if (OnPropertyChanging(__.WxName, value)) { _WxName = value; OnPropertyChanged(__.WxName); } } }

        private Int32 _GroupId;
        /// <summary>分组</summary>
        [DisplayName("分组")]
        [Description("分组")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("GroupId", "分组", "int")]
        public Int32 GroupId { get { return _GroupId; } set { if (OnPropertyChanging(__.GroupId, value)) { _GroupId = value; OnPropertyChanged(__.GroupId); } } }

        private Int32 _State;
        /// <summary>状态</summary>
        [DisplayName("状态")]
        [Description("状态")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("State", "状态", "int")]
        public Int32 State { get { return _State; } set { if (OnPropertyChanging(__.State, value)) { _State = value; OnPropertyChanged(__.State); } } }

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
                    case __.Name : return _Name;
                    case __.WxId : return _WxId;
                    case __.WxName : return _WxName;
                    case __.GroupId : return _GroupId;
                    case __.State : return _State;
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
                    case __.Name : _Name = Convert.ToString(value); break;
                    case __.WxId : _WxId = Convert.ToString(value); break;
                    case __.WxName : _WxName = Convert.ToString(value); break;
                    case __.GroupId : _GroupId = Convert.ToInt32(value); break;
                    case __.State : _State = Convert.ToInt32(value); break;
                    case __.CreateTime : _CreateTime = Convert.ToDateTime(value); break;
                    case __.UpdateTime : _UpdateTime = Convert.ToDateTime(value); break;
                    case __.Remark : _Remark = Convert.ToString(value); break;
                    default: base[name] = value; break;
                }
            }
        }
        #endregion

        #region 字段名
        /// <summary>取得关注分组表字段信息的快捷方式</summary>
        public partial class _
        {
            /// <summary>编号</summary>
            public static readonly Field Id = FindByName(__.Id);

            /// <summary>分组名-本地</summary>
            public static readonly Field Name = FindByName(__.Name);

            /// <summary>分组编号-微信</summary>
            public static readonly Field WxId = FindByName(__.WxId);

            /// <summary>分组名-微信</summary>
            public static readonly Field WxName = FindByName(__.WxName);

            /// <summary>分组</summary>
            public static readonly Field GroupId = FindByName(__.GroupId);

            /// <summary>状态</summary>
            public static readonly Field State = FindByName(__.State);

            /// <summary>创建时间</summary>
            public static readonly Field CreateTime = FindByName(__.CreateTime);

            /// <summary>更新时间</summary>
            public static readonly Field UpdateTime = FindByName(__.UpdateTime);

            /// <summary>备注</summary>
            public static readonly Field Remark = FindByName(__.Remark);

            static Field FindByName(String name) { return Meta.Table.FindByName(name); }
        }

        /// <summary>取得关注分组表字段名称的快捷方式</summary>
        public partial class __
        {
            /// <summary>编号</summary>
            public const String Id = "Id";

            /// <summary>分组名-本地</summary>
            public const String Name = "Name";

            /// <summary>分组编号-微信</summary>
            public const String WxId = "WxId";

            /// <summary>分组名-微信</summary>
            public const String WxName = "WxName";

            /// <summary>分组</summary>
            public const String GroupId = "GroupId";

            /// <summary>状态</summary>
            public const String State = "State";

            /// <summary>创建时间</summary>
            public const String CreateTime = "CreateTime";

            /// <summary>更新时间</summary>
            public const String UpdateTime = "UpdateTime";

            /// <summary>备注</summary>
            public const String Remark = "Remark";
        }
        #endregion
    }

    /// <summary>关注分组表接口</summary>
    public partial interface IUserGroup
    {
        #region 属性
        /// <summary>编号</summary>
        Int32 Id { get; set; }

        /// <summary>分组名-本地</summary>
        String Name { get; set; }

        /// <summary>分组编号-微信</summary>
        String WxId { get; set; }

        /// <summary>分组名-微信</summary>
        String WxName { get; set; }

        /// <summary>分组</summary>
        Int32 GroupId { get; set; }

        /// <summary>状态</summary>
        Int32 State { get; set; }

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