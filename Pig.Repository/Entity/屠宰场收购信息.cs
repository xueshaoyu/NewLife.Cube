using System;
using System.Collections.Generic;
using System.ComponentModel;
using XCode;
using XCode.Configuration;
using XCode.DataAccessLayer;

namespace Pig.Repository.Entity
{
    /// <summary>屠宰场收购信息</summary>
    [Serializable]
    [DataObject]
    [Description("屠宰场收购信息")]
    [BindIndex("IX_BuyInfo_PubTime", false, "PubTime")]
    [BindTable("BuyInfo", Description = "屠宰场收购信息", ConnName = "Pig", DbType = DatabaseType.SqlServer)]
    public partial class BuyInfo : IBuyInfo
    {
        #region 属性
        private Int32 _Id;
        /// <summary>编号</summary>
        [DisplayName("编号")]
        [Description("编号")]
        [DataObjectField(true, true, false, 0)]
        [BindColumn("Id", "编号", "int")]
        public Int32 Id { get { return _Id; } set { if (OnPropertyChanging(__.Id, value)) { _Id = value; OnPropertyChanged(__.Id); } } }

        private Int32 _BuyerId;
        /// <summary>屠宰场</summary>
        [DisplayName("屠宰场")]
        [Description("屠宰场")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("BuyerId", "屠宰场", "int")]
        public Int32 BuyerId { get { return _BuyerId; } set { if (OnPropertyChanging(__.BuyerId, value)) { _BuyerId = value; OnPropertyChanged(__.BuyerId); } } }

        private String _PubTime;
        /// <summary>信息发布时间</summary>
        [DisplayName("信息发布时间")]
        [Description("信息发布时间")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("PubTime", "信息发布时间", "nvarchar(50)", Master = true)]
        public String PubTime { get { return _PubTime; } set { if (OnPropertyChanging(__.PubTime, value)) { _PubTime = value; OnPropertyChanged(__.PubTime); } } }

        private String _Price;
        /// <summary>单价</summary>
        [DisplayName("单价")]
        [Description("单价")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("Price", "单价", "nvarchar(50)")]
        public String Price { get { return _Price; } set { if (OnPropertyChanging(__.Price, value)) { _Price = value; OnPropertyChanged(__.Price); } } }

        private Int32 _BuyNumber;
        /// <summary>购买数量</summary>
        [DisplayName("购买数量")]
        [Description("购买数量")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("BuyNumber", "购买数量", "int")]
        public Int32 BuyNumber { get { return _BuyNumber; } set { if (OnPropertyChanging(__.BuyNumber, value)) { _BuyNumber = value; OnPropertyChanged(__.BuyNumber); } } }

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
                    case __.BuyerId : return _BuyerId;
                    case __.PubTime : return _PubTime;
                    case __.Price : return _Price;
                    case __.BuyNumber : return _BuyNumber;
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
                    case __.BuyerId : _BuyerId = Convert.ToInt32(value); break;
                    case __.PubTime : _PubTime = Convert.ToString(value); break;
                    case __.Price : _Price = Convert.ToString(value); break;
                    case __.BuyNumber : _BuyNumber = Convert.ToInt32(value); break;
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
        /// <summary>取得屠宰场收购信息字段信息的快捷方式</summary>
        public partial class _
        {
            /// <summary>编号</summary>
            public static readonly Field Id = FindByName(__.Id);

            /// <summary>屠宰场</summary>
            public static readonly Field BuyerId = FindByName(__.BuyerId);

            /// <summary>信息发布时间</summary>
            public static readonly Field PubTime = FindByName(__.PubTime);

            /// <summary>单价</summary>
            public static readonly Field Price = FindByName(__.Price);

            /// <summary>购买数量</summary>
            public static readonly Field BuyNumber = FindByName(__.BuyNumber);

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

        /// <summary>取得屠宰场收购信息字段名称的快捷方式</summary>
        public partial class __
        {
            /// <summary>编号</summary>
            public const String Id = "Id";

            /// <summary>屠宰场</summary>
            public const String BuyerId = "BuyerId";

            /// <summary>信息发布时间</summary>
            public const String PubTime = "PubTime";

            /// <summary>单价</summary>
            public const String Price = "Price";

            /// <summary>购买数量</summary>
            public const String BuyNumber = "BuyNumber";

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

    /// <summary>屠宰场收购信息接口</summary>
    public partial interface IBuyInfo
    {
        #region 属性
        /// <summary>编号</summary>
        Int32 Id { get; set; }

        /// <summary>屠宰场</summary>
        Int32 BuyerId { get; set; }

        /// <summary>信息发布时间</summary>
        String PubTime { get; set; }

        /// <summary>单价</summary>
        String Price { get; set; }

        /// <summary>购买数量</summary>
        Int32 BuyNumber { get; set; }

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