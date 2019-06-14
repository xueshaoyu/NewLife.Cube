using System;
using System.Collections.Generic;
using System.ComponentModel;
using XCode;
using XCode.Configuration;
using XCode.DataAccessLayer;

namespace Pig.Repository.Entity
{
    /// <summary>用户消息记录</summary>
    [Serializable]
    [DataObject]
    [Description("用户消息记录")]
    [BindTable("UserMsg", Description = "用户消息记录", ConnName = "Pig", DbType = DatabaseType.SqlServer)]
    public partial class UserMsg : IUserMsg
    {
        #region 属性
        private Int32 _Id;
        /// <summary>编号</summary>
        [DisplayName("编号")]
        [Description("编号")]
        [DataObjectField(true, true, false, 0)]
        [BindColumn("Id", "编号", "int")]
        public Int32 Id { get { return _Id; } set { if (OnPropertyChanging(__.Id, value)) { _Id = value; OnPropertyChanged(__.Id); } } }

        private Int32 _MsgType;
        /// <summary>消息类型</summary>
        [DisplayName("消息类型")]
        [Description("消息类型")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("MsgType", "消息类型", "int")]
        public Int32 MsgType { get { return _MsgType; } set { if (OnPropertyChanging(__.MsgType, value)) { _MsgType = value; OnPropertyChanged(__.MsgType); } } }

        private Int32 _EventId;
        /// <summary>事件ID</summary>
        [DisplayName("事件ID")]
        [Description("事件ID")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("EventId", "事件ID", "int")]
        public Int32 EventId { get { return _EventId; } set { if (OnPropertyChanging(__.EventId, value)) { _EventId = value; OnPropertyChanged(__.EventId); } } }

        private String _Content;
        /// <summary>内容</summary>
        [DisplayName("内容")]
        [Description("内容")]
        [DataObjectField(false, false, true, 700)]
        [BindColumn("Content", "内容", "nvarchar(700)")]
        public String Content { get { return _Content; } set { if (OnPropertyChanging(__.Content, value)) { _Content = value; OnPropertyChanged(__.Content); } } }

        private Int32 _State;
        /// <summary>状态</summary>
        [DisplayName("状态")]
        [Description("状态")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("State", "状态", "int")]
        public Int32 State { get { return _State; } set { if (OnPropertyChanging(__.State, value)) { _State = value; OnPropertyChanged(__.State); } } }

        private Int32 _ReState;
        /// <summary>回复状态</summary>
        [DisplayName("回复状态")]
        [Description("回复状态")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("ReState", "回复状态", "int")]
        public Int32 ReState { get { return _ReState; } set { if (OnPropertyChanging(__.ReState, value)) { _ReState = value; OnPropertyChanged(__.ReState); } } }

        private Int32 _WxMsgId;
        /// <summary>微信消息ID</summary>
        [DisplayName("微信消息ID")]
        [Description("微信消息ID")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("WxMsgId", "微信消息ID", "int")]
        public Int32 WxMsgId { get { return _WxMsgId; } set { if (OnPropertyChanging(__.WxMsgId, value)) { _WxMsgId = value; OnPropertyChanged(__.WxMsgId); } } }

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

        private DateTime _CreateTime;
        /// <summary>创建时间</summary>
        [DisplayName("创建时间")]
        [Description("创建时间")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("CreateTime", "创建时间", "datetime")]
        public DateTime CreateTime { get { return _CreateTime; } set { if (OnPropertyChanging(__.CreateTime, value)) { _CreateTime = value; OnPropertyChanged(__.CreateTime); } } }
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
                    case __.MsgType : return _MsgType;
                    case __.EventId : return _EventId;
                    case __.Content : return _Content;
                    case __.State : return _State;
                    case __.ReState : return _ReState;
                    case __.WxMsgId : return _WxMsgId;
                    case __.OpenId : return _OpenId;
                    case __.UserId : return _UserId;
                    case __.CreateTime : return _CreateTime;
                    default: return base[name];
                }
            }
            set
            {
                switch (name)
                {
                    case __.Id : _Id = Convert.ToInt32(value); break;
                    case __.MsgType : _MsgType = Convert.ToInt32(value); break;
                    case __.EventId : _EventId = Convert.ToInt32(value); break;
                    case __.Content : _Content = Convert.ToString(value); break;
                    case __.State : _State = Convert.ToInt32(value); break;
                    case __.ReState : _ReState = Convert.ToInt32(value); break;
                    case __.WxMsgId : _WxMsgId = Convert.ToInt32(value); break;
                    case __.OpenId : _OpenId = Convert.ToString(value); break;
                    case __.UserId : _UserId = Convert.ToInt32(value); break;
                    case __.CreateTime : _CreateTime = Convert.ToDateTime(value); break;
                    default: base[name] = value; break;
                }
            }
        }
        #endregion

        #region 字段名
        /// <summary>取得用户消息记录字段信息的快捷方式</summary>
        public partial class _
        {
            /// <summary>编号</summary>
            public static readonly Field Id = FindByName(__.Id);

            /// <summary>消息类型</summary>
            public static readonly Field MsgType = FindByName(__.MsgType);

            /// <summary>事件ID</summary>
            public static readonly Field EventId = FindByName(__.EventId);

            /// <summary>内容</summary>
            public static readonly Field Content = FindByName(__.Content);

            /// <summary>状态</summary>
            public static readonly Field State = FindByName(__.State);

            /// <summary>回复状态</summary>
            public static readonly Field ReState = FindByName(__.ReState);

            /// <summary>微信消息ID</summary>
            public static readonly Field WxMsgId = FindByName(__.WxMsgId);

            /// <summary>OpenId</summary>
            public static readonly Field OpenId = FindByName(__.OpenId);

            /// <summary>用户编号</summary>
            public static readonly Field UserId = FindByName(__.UserId);

            /// <summary>创建时间</summary>
            public static readonly Field CreateTime = FindByName(__.CreateTime);

            static Field FindByName(String name) { return Meta.Table.FindByName(name); }
        }

        /// <summary>取得用户消息记录字段名称的快捷方式</summary>
        public partial class __
        {
            /// <summary>编号</summary>
            public const String Id = "Id";

            /// <summary>消息类型</summary>
            public const String MsgType = "MsgType";

            /// <summary>事件ID</summary>
            public const String EventId = "EventId";

            /// <summary>内容</summary>
            public const String Content = "Content";

            /// <summary>状态</summary>
            public const String State = "State";

            /// <summary>回复状态</summary>
            public const String ReState = "ReState";

            /// <summary>微信消息ID</summary>
            public const String WxMsgId = "WxMsgId";

            /// <summary>OpenId</summary>
            public const String OpenId = "OpenId";

            /// <summary>用户编号</summary>
            public const String UserId = "UserId";

            /// <summary>创建时间</summary>
            public const String CreateTime = "CreateTime";
        }
        #endregion
    }

    /// <summary>用户消息记录接口</summary>
    public partial interface IUserMsg
    {
        #region 属性
        /// <summary>编号</summary>
        Int32 Id { get; set; }

        /// <summary>消息类型</summary>
        Int32 MsgType { get; set; }

        /// <summary>事件ID</summary>
        Int32 EventId { get; set; }

        /// <summary>内容</summary>
        String Content { get; set; }

        /// <summary>状态</summary>
        Int32 State { get; set; }

        /// <summary>回复状态</summary>
        Int32 ReState { get; set; }

        /// <summary>微信消息ID</summary>
        Int32 WxMsgId { get; set; }

        /// <summary>OpenId</summary>
        String OpenId { get; set; }

        /// <summary>用户编号</summary>
        Int32 UserId { get; set; }

        /// <summary>创建时间</summary>
        DateTime CreateTime { get; set; }
        #endregion

        #region 获取/设置 字段值
        /// <summary>获取/设置 字段值</summary>
        /// <param name="name">字段名</param>
        /// <returns></returns>
        Object this[String name] { get; set; }
        #endregion
    }
}