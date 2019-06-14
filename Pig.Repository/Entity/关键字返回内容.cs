using System;
using System.Collections.Generic;
using System.ComponentModel;
using XCode;
using XCode.Configuration;
using XCode.DataAccessLayer;

namespace Pig.Repository.Entity
{
    /// <summary>关键字返回内容</summary>
    [Serializable]
    [DataObject]
    [Description("关键字返回内容")]
    [BindTable("KeyContent", Description = "关键字返回内容", ConnName = "Pig", DbType = DatabaseType.SqlServer)]
    public partial class KeyContent : IKeyContent
    {
        #region 属性
        private Int32 _Id;
        /// <summary>编号</summary>
        [DisplayName("编号")]
        [Description("编号")]
        [DataObjectField(true, true, false, 0)]
        [BindColumn("Id", "编号", "int")]
        public Int32 Id { get { return _Id; } set { if (OnPropertyChanging(__.Id, value)) { _Id = value; OnPropertyChanged(__.Id); } } }

        private String _Title;
        /// <summary>标题</summary>
        [DisplayName("标题")]
        [Description("标题")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("Title", "标题", "nvarchar(50)", Master = true)]
        public String Title { get { return _Title; } set { if (OnPropertyChanging(__.Title, value)) { _Title = value; OnPropertyChanged(__.Title); } } }

        private String _Content;
        /// <summary>内容</summary>
        [DisplayName("内容")]
        [Description("内容")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("Content", "内容", "nvarchar(50)")]
        public String Content { get { return _Content; } set { if (OnPropertyChanging(__.Content, value)) { _Content = value; OnPropertyChanged(__.Content); } } }

        private Int32 _KeywordId;
        /// <summary>关键字</summary>
        [DisplayName("关键字")]
        [Description("关键字")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("KeywordId", "关键字", "int")]
        public Int32 KeywordId { get { return _KeywordId; } set { if (OnPropertyChanging(__.KeywordId, value)) { _KeywordId = value; OnPropertyChanged(__.KeywordId); } } }

        private String _MiniImg;
        /// <summary>缩略图</summary>
        [DisplayName("缩略图")]
        [Description("缩略图")]
        [DataObjectField(false, false, true, 300)]
        [BindColumn("MiniImg", "缩略图", "nvarchar(300)")]
        public String MiniImg { get { return _MiniImg; } set { if (OnPropertyChanging(__.MiniImg, value)) { _MiniImg = value; OnPropertyChanged(__.MiniImg); } } }

        private Int32 _Type;
        /// <summary>回复消息类型</summary>
        [DisplayName("回复消息类型")]
        [Description("回复消息类型")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("Type", "回复消息类型", "int")]
        public Int32 Type { get { return _Type; } set { if (OnPropertyChanging(__.Type, value)) { _Type = value; OnPropertyChanged(__.Type); } } }

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
                    case __.Title : return _Title;
                    case __.Content : return _Content;
                    case __.KeywordId : return _KeywordId;
                    case __.MiniImg : return _MiniImg;
                    case __.Type : return _Type;
                    case __.State : return _State;
                    case __.LinkUrl : return _LinkUrl;
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
                    case __.Title : _Title = Convert.ToString(value); break;
                    case __.Content : _Content = Convert.ToString(value); break;
                    case __.KeywordId : _KeywordId = Convert.ToInt32(value); break;
                    case __.MiniImg : _MiniImg = Convert.ToString(value); break;
                    case __.Type : _Type = Convert.ToInt32(value); break;
                    case __.State : _State = Convert.ToInt32(value); break;
                    case __.LinkUrl : _LinkUrl = Convert.ToString(value); break;
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
        /// <summary>取得关键字返回内容字段信息的快捷方式</summary>
        public partial class _
        {
            /// <summary>编号</summary>
            public static readonly Field Id = FindByName(__.Id);

            /// <summary>标题</summary>
            public static readonly Field Title = FindByName(__.Title);

            /// <summary>内容</summary>
            public static readonly Field Content = FindByName(__.Content);

            /// <summary>关键字</summary>
            public static readonly Field KeywordId = FindByName(__.KeywordId);

            /// <summary>缩略图</summary>
            public static readonly Field MiniImg = FindByName(__.MiniImg);

            /// <summary>回复消息类型</summary>
            public static readonly Field Type = FindByName(__.Type);

            /// <summary>状态</summary>
            public static readonly Field State = FindByName(__.State);

            /// <summary>链接地址</summary>
            public static readonly Field LinkUrl = FindByName(__.LinkUrl);

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

        /// <summary>取得关键字返回内容字段名称的快捷方式</summary>
        public partial class __
        {
            /// <summary>编号</summary>
            public const String Id = "Id";

            /// <summary>标题</summary>
            public const String Title = "Title";

            /// <summary>内容</summary>
            public const String Content = "Content";

            /// <summary>关键字</summary>
            public const String KeywordId = "KeywordId";

            /// <summary>缩略图</summary>
            public const String MiniImg = "MiniImg";

            /// <summary>回复消息类型</summary>
            public const String Type = "Type";

            /// <summary>状态</summary>
            public const String State = "State";

            /// <summary>链接地址</summary>
            public const String LinkUrl = "LinkUrl";

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

    /// <summary>关键字返回内容接口</summary>
    public partial interface IKeyContent
    {
        #region 属性
        /// <summary>编号</summary>
        Int32 Id { get; set; }

        /// <summary>标题</summary>
        String Title { get; set; }

        /// <summary>内容</summary>
        String Content { get; set; }

        /// <summary>关键字</summary>
        Int32 KeywordId { get; set; }

        /// <summary>缩略图</summary>
        String MiniImg { get; set; }

        /// <summary>回复消息类型</summary>
        Int32 Type { get; set; }

        /// <summary>状态</summary>
        Int32 State { get; set; }

        /// <summary>链接地址</summary>
        String LinkUrl { get; set; }

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