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
        [BindColumn("OpenId", "关注者OpenId", "nvarchar(50)", Master = true)]
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

        private Int32 _IsFollow;
        /// <summary>是否关注</summary>
        [DisplayName("是否关注")]
        [Description("是否关注")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("IsFollow", "是否关注", "int")]
        public Int32 IsFollow { get { return _IsFollow; } set { if (OnPropertyChanging(__.IsFollow, value)) { _IsFollow = value; OnPropertyChanged(__.IsFollow); } } }

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
                    case __.IsFollow : return _IsFollow;
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
                    case __.IsFollow : _IsFollow = Convert.ToInt32(value); break;
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

            /// <summary>是否关注</summary>
            public static readonly Field IsFollow = FindByName(__.IsFollow);

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

            /// <summary>是否关注</summary>
            public const String IsFollow = "IsFollow";

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

        /// <summary>是否关注</summary>
        Int32 IsFollow { get; set; }

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