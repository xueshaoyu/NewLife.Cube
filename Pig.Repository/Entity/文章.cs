using System;
using System.Collections.Generic;
using System.ComponentModel;
using XCode;
using XCode.Configuration;
using XCode.DataAccessLayer;

namespace Pig.Repository.Entity
{
    /// <summary>文章</summary>
    [Serializable]
    [DataObject]
    [Description("文章")]
    [BindTable("Article", Description = "文章", ConnName = "Pig", DbType = DatabaseType.SqlServer)]
    public partial class Article : IArticle
    {
        #region 属性
        private Int32 _Id;
        /// <summary>编号</summary>
        [DisplayName("编号")]
        [Description("编号")]
        [DataObjectField(true, true, false, 0)]
        [BindColumn("Id", "编号", "int")]
        public Int32 Id { get { return _Id; } set { if (OnPropertyChanging(__.Id, value)) { _Id = value; OnPropertyChanged(__.Id); } } }

        private Int32 _ArtSortId;
        /// <summary>文章分类</summary>
        [DisplayName("文章分类")]
        [Description("文章分类")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("ArtSortId", "文章分类", "int")]
        public Int32 ArtSortId { get { return _ArtSortId; } set { if (OnPropertyChanging(__.ArtSortId, value)) { _ArtSortId = value; OnPropertyChanged(__.ArtSortId); } } }

        private String _Title;
        /// <summary>名称</summary>
        [DisplayName("名称")]
        [Description("名称")]
        [DataObjectField(false, false, true, 100)]
        [BindColumn("Title", "名称", "nvarchar(100)", Master = true)]
        public String Title { get { return _Title; } set { if (OnPropertyChanging(__.Title, value)) { _Title = value; OnPropertyChanged(__.Title); } } }

        private String _Keyword;
        /// <summary>关键字</summary>
        [DisplayName("关键字")]
        [Description("关键字")]
        [DataObjectField(false, false, true, 100)]
        [BindColumn("Keyword", "关键字", "nvarchar(100)")]
        public String Keyword { get { return _Keyword; } set { if (OnPropertyChanging(__.Keyword, value)) { _Keyword = value; OnPropertyChanged(__.Keyword); } } }

        private String _Summary;
        /// <summary>简介</summary>
        [DisplayName("简介")]
        [Description("简介")]
        [DataObjectField(false, false, true, 680)]
        [BindColumn("Summary", "简介", "nvarchar(680)")]
        public String Summary { get { return _Summary; } set { if (OnPropertyChanging(__.Summary, value)) { _Summary = value; OnPropertyChanged(__.Summary); } } }

        private String _Content;
        /// <summary>内容</summary>
        [DisplayName("内容")]
        [Description("内容")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("Content", "内容", "nvarchar(50)")]
        public String Content { get { return _Content; } set { if (OnPropertyChanging(__.Content, value)) { _Content = value; OnPropertyChanged(__.Content); } } }

        private String _MiniImg;
        /// <summary>缩略图</summary>
        [DisplayName("缩略图")]
        [Description("缩略图")]
        [DataObjectField(false, false, true, 300)]
        [BindColumn("MiniImg", "缩略图", "nvarchar(300)")]
        public String MiniImg { get { return _MiniImg; } set { if (OnPropertyChanging(__.MiniImg, value)) { _MiniImg = value; OnPropertyChanged(__.MiniImg); } } }

        private String _Source;
        /// <summary>来源</summary>
        [DisplayName("来源")]
        [Description("来源")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("Source", "来源", "nvarchar(50)")]
        public String Source { get { return _Source; } set { if (OnPropertyChanging(__.Source, value)) { _Source = value; OnPropertyChanged(__.Source); } } }

        private Int32 _IsTop;
        /// <summary>是否置顶</summary>
        [DisplayName("是否置顶")]
        [Description("是否置顶")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("IsTop", "是否置顶", "int")]
        public Int32 IsTop { get { return _IsTop; } set { if (OnPropertyChanging(__.IsTop, value)) { _IsTop = value; OnPropertyChanged(__.IsTop); } } }

        private DateTime _TopStartTime;
        /// <summary>置顶开始时间</summary>
        [DisplayName("置顶开始时间")]
        [Description("置顶开始时间")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("TopStartTime", "置顶开始时间", "datetime")]
        public DateTime TopStartTime { get { return _TopStartTime; } set { if (OnPropertyChanging(__.TopStartTime, value)) { _TopStartTime = value; OnPropertyChanged(__.TopStartTime); } } }

        private DateTime _TopEndTime;
        /// <summary>置顶结束时间</summary>
        [DisplayName("置顶结束时间")]
        [Description("置顶结束时间")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("TopEndTime", "置顶结束时间", "datetime")]
        public DateTime TopEndTime { get { return _TopEndTime; } set { if (OnPropertyChanging(__.TopEndTime, value)) { _TopEndTime = value; OnPropertyChanged(__.TopEndTime); } } }

        private Int32 _SOrder;
        /// <summary>排序</summary>
        [DisplayName("排序")]
        [Description("排序")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("SOrder", "排序", "int")]
        public Int32 SOrder { get { return _SOrder; } set { if (OnPropertyChanging(__.SOrder, value)) { _SOrder = value; OnPropertyChanged(__.SOrder); } } }

        private Int32 _State;
        /// <summary>状态</summary>
        [DisplayName("状态")]
        [Description("状态")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("State", "状态", "int")]
        public Int32 State { get { return _State; } set { if (OnPropertyChanging(__.State, value)) { _State = value; OnPropertyChanged(__.State); } } }

        private DateTime _PubTime;
        /// <summary>发布时间</summary>
        [DisplayName("发布时间")]
        [Description("发布时间")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("PubTime", "发布时间", "datetime")]
        public DateTime PubTime { get { return _PubTime; } set { if (OnPropertyChanging(__.PubTime, value)) { _PubTime = value; OnPropertyChanged(__.PubTime); } } }

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
                    case __.ArtSortId : return _ArtSortId;
                    case __.Title : return _Title;
                    case __.Keyword : return _Keyword;
                    case __.Summary : return _Summary;
                    case __.Content : return _Content;
                    case __.MiniImg : return _MiniImg;
                    case __.Source : return _Source;
                    case __.IsTop : return _IsTop;
                    case __.TopStartTime : return _TopStartTime;
                    case __.TopEndTime : return _TopEndTime;
                    case __.SOrder : return _SOrder;
                    case __.State : return _State;
                    case __.PubTime : return _PubTime;
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
                    case __.ArtSortId : _ArtSortId = Convert.ToInt32(value); break;
                    case __.Title : _Title = Convert.ToString(value); break;
                    case __.Keyword : _Keyword = Convert.ToString(value); break;
                    case __.Summary : _Summary = Convert.ToString(value); break;
                    case __.Content : _Content = Convert.ToString(value); break;
                    case __.MiniImg : _MiniImg = Convert.ToString(value); break;
                    case __.Source : _Source = Convert.ToString(value); break;
                    case __.IsTop : _IsTop = Convert.ToInt32(value); break;
                    case __.TopStartTime : _TopStartTime = Convert.ToDateTime(value); break;
                    case __.TopEndTime : _TopEndTime = Convert.ToDateTime(value); break;
                    case __.SOrder : _SOrder = Convert.ToInt32(value); break;
                    case __.State : _State = Convert.ToInt32(value); break;
                    case __.PubTime : _PubTime = Convert.ToDateTime(value); break;
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
        /// <summary>取得文章字段信息的快捷方式</summary>
        public partial class _
        {
            /// <summary>编号</summary>
            public static readonly Field Id = FindByName(__.Id);

            /// <summary>文章分类</summary>
            public static readonly Field ArtSortId = FindByName(__.ArtSortId);

            /// <summary>名称</summary>
            public static readonly Field Title = FindByName(__.Title);

            /// <summary>关键字</summary>
            public static readonly Field Keyword = FindByName(__.Keyword);

            /// <summary>简介</summary>
            public static readonly Field Summary = FindByName(__.Summary);

            /// <summary>内容</summary>
            public static readonly Field Content = FindByName(__.Content);

            /// <summary>缩略图</summary>
            public static readonly Field MiniImg = FindByName(__.MiniImg);

            /// <summary>来源</summary>
            public static readonly Field Source = FindByName(__.Source);

            /// <summary>是否置顶</summary>
            public static readonly Field IsTop = FindByName(__.IsTop);

            /// <summary>置顶开始时间</summary>
            public static readonly Field TopStartTime = FindByName(__.TopStartTime);

            /// <summary>置顶结束时间</summary>
            public static readonly Field TopEndTime = FindByName(__.TopEndTime);

            /// <summary>排序</summary>
            public static readonly Field SOrder = FindByName(__.SOrder);

            /// <summary>状态</summary>
            public static readonly Field State = FindByName(__.State);

            /// <summary>发布时间</summary>
            public static readonly Field PubTime = FindByName(__.PubTime);

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

        /// <summary>取得文章字段名称的快捷方式</summary>
        public partial class __
        {
            /// <summary>编号</summary>
            public const String Id = "Id";

            /// <summary>文章分类</summary>
            public const String ArtSortId = "ArtSortId";

            /// <summary>名称</summary>
            public const String Title = "Title";

            /// <summary>关键字</summary>
            public const String Keyword = "Keyword";

            /// <summary>简介</summary>
            public const String Summary = "Summary";

            /// <summary>内容</summary>
            public const String Content = "Content";

            /// <summary>缩略图</summary>
            public const String MiniImg = "MiniImg";

            /// <summary>来源</summary>
            public const String Source = "Source";

            /// <summary>是否置顶</summary>
            public const String IsTop = "IsTop";

            /// <summary>置顶开始时间</summary>
            public const String TopStartTime = "TopStartTime";

            /// <summary>置顶结束时间</summary>
            public const String TopEndTime = "TopEndTime";

            /// <summary>排序</summary>
            public const String SOrder = "SOrder";

            /// <summary>状态</summary>
            public const String State = "State";

            /// <summary>发布时间</summary>
            public const String PubTime = "PubTime";

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

    /// <summary>文章接口</summary>
    public partial interface IArticle
    {
        #region 属性
        /// <summary>编号</summary>
        Int32 Id { get; set; }

        /// <summary>文章分类</summary>
        Int32 ArtSortId { get; set; }

        /// <summary>名称</summary>
        String Title { get; set; }

        /// <summary>关键字</summary>
        String Keyword { get; set; }

        /// <summary>简介</summary>
        String Summary { get; set; }

        /// <summary>内容</summary>
        String Content { get; set; }

        /// <summary>缩略图</summary>
        String MiniImg { get; set; }

        /// <summary>来源</summary>
        String Source { get; set; }

        /// <summary>是否置顶</summary>
        Int32 IsTop { get; set; }

        /// <summary>置顶开始时间</summary>
        DateTime TopStartTime { get; set; }

        /// <summary>置顶结束时间</summary>
        DateTime TopEndTime { get; set; }

        /// <summary>排序</summary>
        Int32 SOrder { get; set; }

        /// <summary>状态</summary>
        Int32 State { get; set; }

        /// <summary>发布时间</summary>
        DateTime PubTime { get; set; }

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