using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace NB.Common
{
    public static class NativeMethods
    {
        /// <summary>
        ///		创建路由规则
        /// </summary>
        /// <param name="address">目标地址</param>
        /// <param name="netmask">掩码地址</param>
        /// <param name="gateway">网关地址</param>
        /// <param name="index">适配器索引</param>
        /// <param name="metric">跃点数</param>
        /// <returns>是否成功</returns>
        [DllImport("\\bin\\rule.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "CreateRoute")]
        public static extern bool CreateRoute(string address, int netmask, string gateway, int index, int metric = 0);

        /// <summary>
        ///		修改路由规则
        /// </summary>
        /// <param name="address">目标地址</param>
        /// <param name="netmask">掩码地址</param>
        /// <param name="gateway">网关地址</param>
        /// <param name="index">适配器索引</param>
        /// <param name="metric">跃点数</param>
        /// <returns>是否成功</returns>
        [DllImport("\\bin\\rule.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ChangeRoute")]
        public static extern bool ChangeRoute(string address, int netmask, string gateway, int index, int metric = 0);

        /// <summary>
        ///		删除路由规则
        /// </summary>
        /// <param name="address">目标地址</param>
        /// <param name="netmask">掩码地址</param>
        /// <param name="gateway">网关地址</param>
        /// <param name="index">适配器索引</param>
        /// <param name="metric">跃点数</param>
        /// <returns>是否成功</returns>
        [DllImport("\\bin\\rule.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "DeleteRoute")]
        public static extern bool DeleteRoute(string address, int netmask, string gateway, int index, int metric = 0);
    }
}
