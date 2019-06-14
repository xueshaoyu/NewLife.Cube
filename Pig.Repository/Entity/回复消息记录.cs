using System;
using System.Collections.Generic;
using System.ComponentModel;
using XCode;
using XCode.Configuration;
using XCode.DataAccessLayer;

namespace Pig.Repository.Entity
{
    /// <summary>回复消息记录</summary>
    [Serializable]
    [DataObject]
    [Description("回复消息记录")]
    [BindTable("ReplyMsg", Description = "回复消息记录", ConnName = "Pig", DbType = DatabaseType.SqlServer)]
    public partial class ReplyMsg : IReplyMsg
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
        /// <summary>OpenId</summary>
        [DisplayName("OpenId")]
        [Description("OpenId")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("OpenId", "OpenId", "nvarchar(50)")]
        public String OpenId { get { return _OpenId; } set { if (OnPropertyChanging(__.OpenId, value)) { _OpenId = value; OnPropertyChanged(__.OpenId); } } }

        private Int32 _UserId;
        /// <summary>用户编号</summary>
        [DisplayName("用户编号")]
        [Description("用户编号")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("UserId", "用户编号", "int")]
        public Int32 UserId { get { return _UserId; } set { if (OnPropertyChanging(__.UserId, value)) { _UserId = value; OnPropertyChanged(__.UserId); } } }

        private Int32 _MsgId;
        /// <summary>消息编号</summary>
        [DisplayName("消息编号")]
        [Description("消息编号")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("MsgId", "消息编号", "int")]
        public Int32 MsgId { get { return _MsgId; } set { if (OnPropertyChanging(__.MsgId, value)) { _MsgId = value; OnPropertyChanged(__.MsgId); } } }

        private Int32 _ReType;
        /// <summary>回复类型</summary>
        [DisplayName("回复类型")]
        [Description("回复类型")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("ReType", "回复类型", "int")]
        public Int32 ReType { get { return _ReType; } set { if (OnPropertyChanging(__.ReType, value)) { _ReType = value; OnPropertyChanged(__.ReType); } } }

        private Int32 _ReFrom;
        /// <summary>回复点</summary>
        [DisplayName("回复点")]
        [Description("回复点")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("ReFrom", "回复点", "int")]
        public Int32 ReFrom { get { return _ReFrom; } set { if (OnPropertyChanging(__.ReFrom, value)) { _ReFrom = value; OnPropertyChanged(__.ReFrom); } } }

        private Int32 _ReContentId;
        /// <summary>回复的内容Id串</summary>
        [DisplayName("回复的内容Id串")]
        [Description("回复的内容Id串")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("ReContentId", "回复的内容Id串", "int")]
        public Int32 ReContentId { get { return _ReContentId; } set { if (OnPropertyChanging(__.ReContentId, value)) { _ReContentId = value; OnPropertyChanged(__.ReContentId); } } }

        private DateTime _ReplyTime;
        /// <summary>创建时间</summary>
        [DisplayName("创建时间")]
        [Description("创建时间")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("ReplyTime", "创建时间", "datetime")]
        public DateTime ReplyTime { get { return _ReplyTime; } set { if (OnPropertyChanging(__.ReplyTime, value)) { _ReplyTime = value; OnPropertyChanged(__.ReplyTime); } } }
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
                    case __.UserId : return _UserId;
                    case __.MsgId : return _MsgId;
                    case __.ReType : return _ReType;
                    case __.ReFrom : return _ReFrom;
                    case __.ReContentId : return _ReContentId;
                    case __.ReplyTime : return _ReplyTime;
                    default: return base[name];
                }
            }
            set
            {
                switch (name)
                {
                    case __.Id : _Id = Convert.ToInt32(value); break;
                    case __.OpenId : _OpenId = Convert.ToString(value); break;
                    case __.UserId : _UserId = Convert.ToInt32(value); break;
                    case __.MsgId : _MsgId = Convert.ToInt32(value); break;
                    case __.ReType : _ReType = Convert.ToInt32(value); break;
                    case __.ReFrom : _ReFrom = Convert.ToInt32(value); break;
                    case __.ReContentId : _ReContentId = Convert.ToInt32(value); break;
                    case __.ReplyTime : _ReplyTime = Convert.ToDateTime(value); break;
                    default: base[name] = value; break;
                }
            }
        }
        #endregion

        #region 字段名
        /// <summary>取得回复消息记录字段信息的快捷方式</summary>
        public partial class _
        {
            /// <summary>编号</summary>
            public static readonly Field Id = FindByName(__.Id);

            /// <summary>OpenId</summary>
            public static readonly Field OpenId = FindByName(__.OpenId);

            /// <summary>用户编号</summary>
            public static readonly Field UserId = FindByName(__.UserId);

            /// <summary>消息编号</summary>
            public static readonly Field MsgId = FindByName(__.MsgId);

            /// <summary>回复类型</summary>
            public static readonly Field ReType = FindByName(__.ReType);

            /// <summary>回复点</summary>
            public static readonly Field ReFrom = FindByName(__.ReFrom);

            /// <summary>回复的内容Id串</summary>
            public static readonly Field ReContentId = FindByName(__.ReContentId);

            /// <summary>创建时间</summary>
            public static readonly Field ReplyTime = FindByName(__.ReplyTime);

            static Field FindByName(String name) { return Meta.Table.FindByName(name); }
        }

        /// <summary>取得回复消息记录字段名称的快捷方式</summary>
        public partial class __
        {
            /// <summary>编号</summary>
            public const String Id = "Id";

            /// <summary>OpenId</summary>
            public const String OpenId = "OpenId";

            /// <summary>用户编号</summary>
            public const String UserId = "UserId";

            /// <summary>消息编号</summary>
            public const String MsgId = "MsgId";

            /// <summary>回复类型</summary>
            public const String ReType = "ReType";

            /// <summary>回复点</summary>
            public const String ReFrom = "ReFrom";

            /// <summary>回复的内容Id串</summary>
            public const String ReContentId = "ReContentId";

            /// <summary>创建时间</summary>
            public const String ReplyTime = "ReplyTime";
        }
        #endregion
    }

    /// <summary>回复消息记录接口</summary>
    public partial interface IReplyMsg
    {
        #region 属性
        /// <summary>编号</summary>
        Int32 Id { get; set; }

        /// <summary>OpenId</summary>
        String OpenId { get; set; }

        /// <summary>用户编号</summary>
        Int32 UserId { get; set; }

        /// <summary>消息编号</summary>
        Int32 MsgId { get; set; }

        /// <summary>回复类型</summary>
        Int32 ReType { get; set; }

        /// <summary>回复点</summary>
        Int32 ReFrom { get; set; }

        /// <summary>回复的内容Id串</summary>
        Int32 ReContentId { get; set; }

        /// <summary>创建时间</summary>
        DateTime ReplyTime { get; set; }
        #endregion

        #region 获取/设置 字段值
        /// <summary>获取/设置 字段值</summary>
        /// <param name="name">字段名</param>
        /// <returns></returns>
        Object this[String name] { get; set; }
        #endregion
    }
}