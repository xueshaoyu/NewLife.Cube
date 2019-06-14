using System;
using System.Collections.Generic;
using System.ComponentModel;
using XCode;
using XCode.Configuration;
using XCode.DataAccessLayer;

namespace Pig.Repository.Entity
{
    /// <summary>出售信息</summary>
    [Serializable]
    [DataObject]
    [Description("出售信息")]
    [BindIndex("IX_SellInfo_PubTime", false, "PubTime")]
    [BindTable("SellInfo", Description = "出售信息", ConnName = "Pig", DbType = DatabaseType.SqlServer)]
    public partial class SellInfo : ISellInfo
    {
        #region 属性
        private Int32 _Id;
        /// <summary>编号</summary>
        [DisplayName("编号")]
        [Description("编号")]
        [DataObjectField(true, true, false, 0)]
        [BindColumn("Id", "编号", "int")]
        public Int32 Id { get { return _Id; } set { if (OnPropertyChanging(__.Id, value)) { _Id = value; OnPropertyChanged(__.Id); } } }

        private Int32 _SellerId;
        /// <summary>养殖户</summary>
        [DisplayName("养殖户")]
        [Description("养殖户")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("SellerId", "养殖户", "int")]
        public Int32 SellerId { get { return _SellerId; } set { if (OnPropertyChanging(__.SellerId, value)) { _SellerId = value; OnPropertyChanged(__.SellerId); } } }

        private String _PubTime;
        /// <summary>信息发布时间</summary>
        [DisplayName("信息发布时间")]
        [Description("信息发布时间")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("PubTime", "信息发布时间", "nvarchar(50)")]
        public String PubTime { get { return _PubTime; } set { if (OnPropertyChanging(__.PubTime, value)) { _PubTime = value; OnPropertyChanged(__.PubTime); } } }

        private Int32 _SellNumber;
        /// <summary>出售数量</summary>
        [DisplayName("出售数量")]
        [Description("出售数量")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("SellNumber", "出售数量", "int")]
        public Int32 SellNumber { get { return _SellNumber; } set { if (OnPropertyChanging(__.SellNumber, value)) { _SellNumber = value; OnPropertyChanged(__.SellNumber); } } }

        private String _Description;
        /// <summary>出售需求描述</summary>
        [DisplayName("出售需求描述")]
        [Description("出售需求描述")]
        [DataObjectField(false, false, true, 500)]
        [BindColumn("Description", "出售需求描述", "nvarchar(500)")]
        public String Description { get { return _Description; } set { if (OnPropertyChanging(__.Description, value)) { _Description = value; OnPropertyChanged(__.Description); } } }

        private String _MinPrice;
        /// <summary>能接受的最低单价</summary>
        [DisplayName("能接受的最低单价")]
        [Description("能接受的最低单价")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("MinPrice", "能接受的最低单价", "nvarchar(50)")]
        public String MinPrice { get { return _MinPrice; } set { if (OnPropertyChanging(__.MinPrice, value)) { _MinPrice = value; OnPropertyChanged(__.MinPrice); } } }

        private DateTime _StartTime;
        /// <summary>开始时间</summary>
        [DisplayName("开始时间")]
        [Description("开始时间")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("StartTime", "开始时间", "datetime")]
        public DateTime StartTime { get { return _StartTime; } set { if (OnPropertyChanging(__.StartTime, value)) { _StartTime = value; OnPropertyChanged(__.StartTime); } } }

        private DateTime _EndTime;
        /// <summary>结束时间</summary>
        [DisplayName("结束时间")]
        [Description("结束时间")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("EndTime", "结束时间", "datetime")]
        public DateTime EndTime { get { return _EndTime; } set { if (OnPropertyChanging(__.EndTime, value)) { _EndTime = value; OnPropertyChanged(__.EndTime); } } }

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
                    case __.SellerId : return _SellerId;
                    case __.PubTime : return _PubTime;
                    case __.SellNumber : return _SellNumber;
                    case __.Description : return _Description;
                    case __.MinPrice : return _MinPrice;
                    case __.StartTime : return _StartTime;
                    case __.EndTime : return _EndTime;
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
                    case __.SellerId : _SellerId = Convert.ToInt32(value); break;
                    case __.PubTime : _PubTime = Convert.ToString(value); break;
                    case __.SellNumber : _SellNumber = Convert.ToInt32(value); break;
                    case __.Description : _Description = Convert.ToString(value); break;
                    case __.MinPrice : _MinPrice = Convert.ToString(value); break;
                    case __.StartTime : _StartTime = Convert.ToDateTime(value); break;
                    case __.EndTime : _EndTime = Convert.ToDateTime(value); break;
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
        /// <summary>取得出售信息字段信息的快捷方式</summary>
        public partial class _
        {
            /// <summary>编号</summary>
            public static readonly Field Id = FindByName(__.Id);

            /// <summary>养殖户</summary>
            public static readonly Field SellerId = FindByName(__.SellerId);

            /// <summary>信息发布时间</summary>
            public static readonly Field PubTime = FindByName(__.PubTime);

            /// <summary>出售数量</summary>
            public static readonly Field SellNumber = FindByName(__.SellNumber);

            /// <summary>出售需求描述</summary>
            public static readonly Field Description = FindByName(__.Description);

            /// <summary>能接受的最低单价</summary>
            public static readonly Field MinPrice = FindByName(__.MinPrice);

            /// <summary>开始时间</summary>
            public static readonly Field StartTime = FindByName(__.StartTime);

            /// <summary>结束时间</summary>
            public static readonly Field EndTime = FindByName(__.EndTime);

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

        /// <summary>取得出售信息字段名称的快捷方式</summary>
        public partial class __
        {
            /// <summary>编号</summary>
            public const String Id = "Id";

            /// <summary>养殖户</summary>
            public const String SellerId = "SellerId";

            /// <summary>信息发布时间</summary>
            public const String PubTime = "PubTime";

            /// <summary>出售数量</summary>
            public const String SellNumber = "SellNumber";

            /// <summary>出售需求描述</summary>
            public const String Description = "Description";

            /// <summary>能接受的最低单价</summary>
            public const String MinPrice = "MinPrice";

            /// <summary>开始时间</summary>
            public const String StartTime = "StartTime";

            /// <summary>结束时间</summary>
            public const String EndTime = "EndTime";

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

    /// <summary>出售信息接口</summary>
    public partial interface ISellInfo
    {
        #region 属性
        /// <summary>编号</summary>
        Int32 Id { get; set; }

        /// <summary>养殖户</summary>
        Int32 SellerId { get; set; }

        /// <summary>信息发布时间</summary>
        String PubTime { get; set; }

        /// <summary>出售数量</summary>
        Int32 SellNumber { get; set; }

        /// <summary>出售需求描述</summary>
        String Description { get; set; }

        /// <summary>能接受的最低单价</summary>
        String MinPrice { get; set; }

        /// <summary>开始时间</summary>
        DateTime StartTime { get; set; }

        /// <summary>结束时间</summary>
        DateTime EndTime { get; set; }

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