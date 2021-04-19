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
    [BindIndex("PK_Games", true, "SerialCode")]
    [BindTable("Games", Description = "", ConnName = "NoBoundaries", DbType = DatabaseType.SqlServer)]
    public partial class Games
    {
        #region 属性
        private String _SerialCode;
        /// <summary></summary>
        [DisplayName("SerialCode")]
        [DataObjectField(true, false, false, 50)]
        [BindColumn("SerialCode", "", "varchar(50)")]
        public String SerialCode { get => _SerialCode; set { if (OnPropertyChanging("SerialCode", value)) { _SerialCode = value; OnPropertyChanged("SerialCode"); } } }

        private String _GameName;
        /// <summary></summary>
        [DisplayName("GameName")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("GameName", "", "varchar(50)")]
        public String GameName { get => _GameName; set { if (OnPropertyChanging("GameName", value)) { _GameName = value; OnPropertyChanged("GameName"); } } }

        private String _GameBigImageUrl;
        /// <summary></summary>
        [DisplayName("GameBigImageUrl")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("GameBigImageUrl", "", "varchar(50)")]
        public String GameBigImageUrl { get => _GameBigImageUrl; set { if (OnPropertyChanging("GameBigImageUrl", value)) { _GameBigImageUrl = value; OnPropertyChanged("GameBigImageUrl"); } } }

        private String _GameBGImageUrl;
        /// <summary></summary>
        [DisplayName("GameBGImageUrl")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("GameBGImageUrl", "", "varchar(50)")]
        public String GameBGImageUrl { get => _GameBGImageUrl; set { if (OnPropertyChanging("GameBGImageUrl", value)) { _GameBGImageUrl = value; OnPropertyChanged("GameBGImageUrl"); } } }

        private String _GameSmallImageUrl;
        /// <summary></summary>
        [DisplayName("GameSmallImageUrl")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("GameSmallImageUrl", "", "varchar(50)")]
        public String GameSmallImageUrl { get => _GameSmallImageUrl; set { if (OnPropertyChanging("GameSmallImageUrl", value)) { _GameSmallImageUrl = value; OnPropertyChanged("GameSmallImageUrl"); } } }

        private String _GameNFRoute;
        /// <summary></summary>
        [DisplayName("GameNFRoute")]
        [DataObjectField(false, false, true, 200)]
        [BindColumn("GameNFRoute", "", "varchar(200)")]
        public String GameNFRoute { get => _GameNFRoute; set { if (OnPropertyChanging("GameNFRoute", value)) { _GameNFRoute = value; OnPropertyChanged("GameNFRoute"); } } }
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
                    case "GameName": return _GameName;
                    case "GameBigImageUrl": return _GameBigImageUrl;
                    case "GameBGImageUrl": return _GameBGImageUrl;
                    case "GameSmallImageUrl": return _GameSmallImageUrl;
                    case "GameNFRoute": return _GameNFRoute;
                    default: return base[name];
                }
            }
            set
            {
                switch (name)
                {
                    case "SerialCode": _SerialCode = Convert.ToString(value); break;
                    case "GameName": _GameName = Convert.ToString(value); break;
                    case "GameBigImageUrl": _GameBigImageUrl = Convert.ToString(value); break;
                    case "GameBGImageUrl": _GameBGImageUrl = Convert.ToString(value); break;
                    case "GameSmallImageUrl": _GameSmallImageUrl = Convert.ToString(value); break;
                    case "GameNFRoute": _GameNFRoute = Convert.ToString(value); break;
                    default: base[name] = value; break;
                }
            }
        }
        #endregion

        #region 字段名
        /// <summary>取得Games字段信息的快捷方式</summary>
        public partial class _
        {
            /// <summary></summary>
            public static readonly Field SerialCode = FindByName("SerialCode");

            /// <summary></summary>
            public static readonly Field GameName = FindByName("GameName");

            /// <summary></summary>
            public static readonly Field GameBigImageUrl = FindByName("GameBigImageUrl");

            /// <summary></summary>
            public static readonly Field GameBGImageUrl = FindByName("GameBGImageUrl");

            /// <summary></summary>
            public static readonly Field GameSmallImageUrl = FindByName("GameSmallImageUrl");

            /// <summary></summary>
            public static readonly Field GameNFRoute = FindByName("GameNFRoute");

            static Field FindByName(String name) => Meta.Table.FindByName(name);
        }

        /// <summary>取得Games字段名称的快捷方式</summary>
        public partial class __
        {
            /// <summary></summary>
            public const String SerialCode = "SerialCode";

            /// <summary></summary>
            public const String GameName = "GameName";

            /// <summary></summary>
            public const String GameBigImageUrl = "GameBigImageUrl";

            /// <summary></summary>
            public const String GameBGImageUrl = "GameBGImageUrl";

            /// <summary></summary>
            public const String GameSmallImageUrl = "GameSmallImageUrl";

            /// <summary></summary>
            public const String GameNFRoute = "GameNFRoute";
        }
        #endregion
    }
}