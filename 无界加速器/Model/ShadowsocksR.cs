using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Web.Script.Serialization;
using System.Xml.Serialization;
using XCode;
using XCode.Configuration;
using XCode.DataAccessLayer;

namespace NB.Model
{
    /// <summary></summary>
    [Serializable]
    [DataObject]
    [BindIndex("PK__Shadowso__651A95AE0AD2A005", true, "SerialCode")]
    [BindTable("ShadowsocksR", Description = "", ConnName = "NoBoundaries", DbType = DatabaseType.SqlServer)]
    public partial class ShadowsocksR
    {
        #region 属性
        private String _SerialCode;
        /// <summary></summary>
        [DisplayName("SerialCode")]
        [DataObjectField(true, false, false, 50)]
        [BindColumn("SerialCode", "", "varchar(50)")]
        public String SerialCode { get => _SerialCode; set { if (OnPropertyChanging("SerialCode", value)) { _SerialCode = value; OnPropertyChanged("SerialCode"); } } }

        private String _Remark;
        /// <summary></summary>
        [DisplayName("Remark")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("Remark", "", "varchar(50)")]
        public String Remark { get => _Remark; set { if (OnPropertyChanging("Remark", value)) { _Remark = value; OnPropertyChanged("Remark"); } } }

        private String _HostName;
        /// <summary></summary>
        [DisplayName("HostName")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("HostName", "", "varchar(50)")]
        public String HostName { get => _HostName; set { if (OnPropertyChanging("HostName", value)) { _HostName = value; OnPropertyChanged("HostName"); } } }

        private String _Port;
        /// <summary></summary>
        [DisplayName("Port")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("Port", "", "varchar(50)")]
        public String Port { get => _Port; set { if (OnPropertyChanging("Port", value)) { _Port = value; OnPropertyChanged("Port"); } } }

        private String _Method;
        /// <summary></summary>
        [DisplayName("Method")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("Method", "", "varchar(50)")]
        public String Method { get => _Method; set { if (OnPropertyChanging("Method", value)) { _Method = value; OnPropertyChanged("Method"); } } }

        private String _Password;
        /// <summary></summary>
        [DisplayName("Password")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("Password", "", "varchar(50)")]
        public String Password { get => _Password; set { if (OnPropertyChanging("Password", value)) { _Password = value; OnPropertyChanged("Password"); } } }

        private String _Protocol;
        /// <summary></summary>
        [DisplayName("Protocol")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("Protocol", "", "varchar(50)")]
        public String Protocol { get => _Protocol; set { if (OnPropertyChanging("Protocol", value)) { _Protocol = value; OnPropertyChanged("Protocol"); } } }

        private String _ProtocolParam;
        /// <summary></summary>
        [DisplayName("ProtocolParam")]
        [DataObjectField(false, false, true, 100)]
        [BindColumn("ProtocolParam", "", "varchar(100)")]
        public String ProtocolParam { get => _ProtocolParam; set { if (OnPropertyChanging("ProtocolParam", value)) { _ProtocolParam = value; OnPropertyChanged("ProtocolParam"); } } }

        private String _Obfs;
        /// <summary></summary>
        [DisplayName("Obfs")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("OBFS", "", "varchar(50)")]
        public String Obfs { get => _Obfs; set { if (OnPropertyChanging("Obfs", value)) { _Obfs = value; OnPropertyChanged("Obfs"); } } }

        private String _OBFSParam;
        /// <summary></summary>
        [DisplayName("OBFSParam")]
        [DataObjectField(false, false, true, 100)]
        [BindColumn("OBFSParam", "", "varchar(100)")]
        public String OBFSParam { get => _OBFSParam; set { if (OnPropertyChanging("OBFSParam", value)) { _OBFSParam = value; OnPropertyChanged("OBFSParam"); } } }

        private Int32 _Type;
        /// <summary></summary>
        [DisplayName("Type")]
        [DataObjectField(false, false, true, 10)]
        [BindColumn("Type", "", "int")]
        public Int32 Type { get => _Type; set { if (OnPropertyChanging("Type", value)) { _Type = value; OnPropertyChanged("Type"); } } }

        private String _State;
        /// <summary></summary>
        [DisplayName("State")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("State", "", "varchar(50)")]
        public String State { get => _State; set { if (OnPropertyChanging("State", value)) { _State = value; OnPropertyChanged("State"); } } }

        private String _Memo;
        /// <summary></summary>
        [DisplayName("Memo")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("Memo", "", "varchar(50)")]
        public String Memo { get => _Memo; set { if (OnPropertyChanging("Memo", value)) { _Memo = value; OnPropertyChanged("Memo"); } } }
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
                    case "SerialCode": return _SerialCode;
                    case "Remark": return _Remark;
                    case "HostName": return _HostName;
                    case "Port": return _Port;
                    case "Method": return _Method;
                    case "Password": return _Password;
                    case "Protocol": return _Protocol;
                    case "ProtocolParam": return _ProtocolParam;
                    case "Obfs": return _Obfs;
                    case "OBFSParam": return _OBFSParam;
                    case "Type": return _Type;
                    case "State": return _State;
                    case "Memo": return _Memo;
                    default: return base[name];
                }
            }
            set
            {
                switch (name)
                {
                    case "SerialCode": _SerialCode = Convert.ToString(value); break;
                    case "Remark": _Remark = Convert.ToString(value); break;
                    case "HostName": _HostName = Convert.ToString(value); break;
                    case "Port": _Port = Convert.ToString(value); break;
                    case "Method": _Method = Convert.ToString(value); break;
                    case "Password": _Password = Convert.ToString(value); break;
                    case "Protocol": _Protocol = Convert.ToString(value); break;
                    case "ProtocolParam": _ProtocolParam = Convert.ToString(value); break;
                    case "Obfs": _Obfs = Convert.ToString(value); break;
                    case "OBFSParam": _OBFSParam = Convert.ToString(value); break;
                    case "Type": _Type = value.ToInt(); break;
                    case "State": _State = Convert.ToString(value); break;
                    case "Memo": _Memo = Convert.ToString(value); break;
                    default: base[name] = value; break;
                }
            }
        }
        #endregion

        #region 字段名
        /// <summary>取得ShadowsocksR字段信息的快捷方式</summary>
        public partial class _
        {
            /// <summary></summary>
            public static readonly Field SerialCode = FindByName("SerialCode");

            /// <summary></summary>
            public static readonly Field Remark = FindByName("Remark");

            /// <summary></summary>
            public static readonly Field HostName = FindByName("HostName");

            /// <summary></summary>
            public static readonly Field Port = FindByName("Port");

            /// <summary></summary>
            public static readonly Field Method = FindByName("Method");

            /// <summary></summary>
            public static readonly Field Password = FindByName("Password");

            /// <summary></summary>
            public static readonly Field Protocol = FindByName("Protocol");

            /// <summary></summary>
            public static readonly Field ProtocolParam = FindByName("ProtocolParam");

            /// <summary></summary>
            public static readonly Field Obfs = FindByName("Obfs");

            /// <summary></summary>
            public static readonly Field OBFSParam = FindByName("OBFSParam");

            /// <summary></summary>
            public static readonly Field Type = FindByName("Type");

            /// <summary></summary>
            public static readonly Field State = FindByName("State");

            /// <summary></summary>
            public static readonly Field Memo = FindByName("Memo");

            static Field FindByName(String name) => Meta.Table.FindByName(name);
        }

        /// <summary>取得ShadowsocksR字段名称的快捷方式</summary>
        public partial class __
        {
            /// <summary></summary>
            public const String SerialCode = "SerialCode";

            /// <summary></summary>
            public const String Remark = "Remark";

            /// <summary></summary>
            public const String HostName = "HostName";

            /// <summary></summary>
            public const String Port = "Port";

            /// <summary></summary>
            public const String Method = "Method";

            /// <summary></summary>
            public const String Password = "Password";

            /// <summary></summary>
            public const String Protocol = "Protocol";

            /// <summary></summary>
            public const String ProtocolParam = "ProtocolParam";

            /// <summary></summary>
            public const String Obfs = "Obfs";

            /// <summary></summary>
            public const String OBFSParam = "OBFSParam";

            /// <summary></summary>
            public const String Type = "Type";

            /// <summary></summary>
            public const String State = "State";

            /// <summary></summary>
            public const String Memo = "Memo";
        }
        #endregion
    }
}