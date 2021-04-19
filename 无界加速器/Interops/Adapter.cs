using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace NB.Interops
{
    /// <summary>
    ///		适配器
    /// </summary>
    public static class Adapter
    {
        /// <summary>
        ///		索引
        /// </summary>
        public static int Index = -1;

        /// <summary>
        ///		地址
        /// </summary>
        public static IPAddress Address;

        /// <summary>
        ///		网关
        /// </summary>
        public static IPAddress Gateway;
    }
}
