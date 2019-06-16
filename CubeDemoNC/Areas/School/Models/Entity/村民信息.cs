using System;
using System.Collections.Generic;
using System.ComponentModel;
using XCode;
using XCode.Configuration;
using XCode.DataAccessLayer;

namespace NewLife.School.Entity
{
    /// <summary>村民信息</summary>
    [Serializable]
    [DataObject]
    [Description("村民信息")]
    [BindTable("People", Description = "村民信息", ConnName = "Bill", DbType = DatabaseType.SqlServer)]
    public partial class People : IPeople
    {
        #region 属性
        private Int32 _ID;
        /// <summary>订单编号</summary>
        [DisplayName("订单编号")]
        [Description("订单编号")]
        [DataObjectField(true, true, false, 0)]
        [BindColumn("ID", "订单编号", "int")]
        public Int32 ID { get { return _ID; } set { if (OnPropertyChanging(__.ID, value)) { _ID = value; OnPropertyChanged(__.ID); } } }

        private String _Name;
        /// <summary>姓名</summary>
        [DisplayName("姓名")]
        [Description("姓名")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("Name", "姓名", "nvarchar(50)", Master = true)]
        public String Name { get { return _Name; } set { if (OnPropertyChanging(__.Name, value)) { _Name = value; OnPropertyChanged(__.Name); } } }

        private Int32 _Age;
        /// <summary>年龄</summary>
        [DisplayName("年龄")]
        [Description("年龄")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("Age", "年龄", "int")]
        public Int32 Age { get { return _Age; } set { if (OnPropertyChanging(__.Age, value)) { _Age = value; OnPropertyChanged(__.Age); } } }

        private Int32 _Sex;
        /// <summary>性别</summary>
        [DisplayName("性别")]
        [Description("性别")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("Sex", "性别", "int")]
        public Int32 Sex { get { return _Sex; } set { if (OnPropertyChanging(__.Sex, value)) { _Sex = value; OnPropertyChanged(__.Sex); } } }
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
                    case __.ID : return _ID;
                    case __.Name : return _Name;
                    case __.Age : return _Age;
                    case __.Sex : return _Sex;
                    default: return base[name];
                }
            }
            set
            {
                switch (name)
                {
                    case __.ID : _ID = Convert.ToInt32(value); break;
                    case __.Name : _Name = Convert.ToString(value); break;
                    case __.Age : _Age = Convert.ToInt32(value); break;
                    case __.Sex : _Sex = Convert.ToInt32(value); break;
                    default: base[name] = value; break;
                }
            }
        }
        #endregion

        #region 字段名
        /// <summary>取得村民信息字段信息的快捷方式</summary>
        public partial class _
        {
            /// <summary>订单编号</summary>
            public static readonly Field ID = FindByName(__.ID);

            /// <summary>姓名</summary>
            public static readonly Field Name = FindByName(__.Name);

            /// <summary>年龄</summary>
            public static readonly Field Age = FindByName(__.Age);

            /// <summary>性别</summary>
            public static readonly Field Sex = FindByName(__.Sex);

            static Field FindByName(String name) { return Meta.Table.FindByName(name); }
        }

        /// <summary>取得村民信息字段名称的快捷方式</summary>
        public partial class __
        {
            /// <summary>订单编号</summary>
            public const String ID = "ID";

            /// <summary>姓名</summary>
            public const String Name = "Name";

            /// <summary>年龄</summary>
            public const String Age = "Age";

            /// <summary>性别</summary>
            public const String Sex = "Sex";
        }
        #endregion
    }

    /// <summary>村民信息接口</summary>
    public partial interface IPeople
    {
        #region 属性
        /// <summary>订单编号</summary>
        Int32 ID { get; set; }

        /// <summary>姓名</summary>
        String Name { get; set; }

        /// <summary>年龄</summary>
        Int32 Age { get; set; }

        /// <summary>性别</summary>
        Int32 Sex { get; set; }
        #endregion

        #region 获取/设置 字段值
        /// <summary>获取/设置 字段值</summary>
        /// <param name="name">字段名</param>
        /// <returns></returns>
        Object this[String name] { get; set; }
        #endregion
    }
}