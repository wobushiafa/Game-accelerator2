using NB.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NB.Interops
{
    public static class RedirectorConfig
    {
        /// <summary>
        ///     不代理TCP
        /// </summary>
        public static PortType ProxyProtocol { get; set; } = PortType.Both;

        /// <summary>
        ///     是否开启DNS转发
        /// </summary>
        public static bool DNSHijack { get; set; } = true;

        /// <summary>
        ///     转发DNS地址
        /// </summary>
        public static string DNSHijackHost { get; set; } = "1.1.1.1:53";

        public static string ICMPHost { get; set; } = "1.2.4.8";

        public static bool ICMPHijack { get; set; } = false;

        /// <summary>
        ///     是否使用RDR内置SS
        /// </summary>
        public static bool RedirectorSS { get; set; } = false;

        /// <summary>
        ///     是否代理子进程
        /// </summary>
        public static bool ChildProcessHandle { get; set; } = false;

    }
}
