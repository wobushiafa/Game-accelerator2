using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace NB.Interops
{
    public static class TUNTAPConfig
    {
        /// <summary>
        ///		适配器
        /// </summary>
        public static NetworkInterface Adapter;

        /// <summary>
        ///		索引
        /// </summary>
        public static int Index = -1;

        /// <summary>
        ///		组件 ID
        /// </summary>
        public static string ComponentID = String.Empty;

        /// <summary>
        ///		地址
        /// </summary>
        public static IPAddress Address = IPAddress.Parse("10.0.236.10");

        /// <summary>
        ///		掩码
        /// </summary>
        public static IPAddress Netmask = IPAddress.Parse("255.255.255.0");

        /// <summary>
        ///		网关
        /// </summary>
        public static IPAddress Gateway = IPAddress.Parse("10.0.236.1");

        /// <summary>
        ///		DNS
        /// </summary>
        //public static List<IPAddress> DNS = new List<IPAddress>()
        //{
        //        IPAddress.Parse("8.8.8.8")
        //};

        /// <summary>
        ///		使用伪装 DNS
        /// </summary>
        public static bool UseFakeDNS = false;

        /// <summary>
        ///		使用自定义 DNS 设置
        /// </summary>
        public static bool UseCustomDNS = false;
    }
}
