using NB.Forms;
using NB.Interops;
using NB.Model;
using NB.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static NB.Interops.RedirectorInterop;
using NB.Models;

namespace NB.Controller
{
    public class NFController
    {
        private static readonly ServiceController NFService = new ServiceController("netfilter2");
        private const string BinDriver = "bin\\nfdriver.sys";
        private static readonly string SystemDriver = $"{Environment.SystemDirectory}\\drivers\\netfilter2.sys";

        public void Start(List<string> mode)
        {
            CheckDriver();

            Dial(NameList.TYPE_FILTERLOOPBACK, "false");
            Dial(NameList.TYPE_FILTERICMP, "true");
            var p = PortHelper.GetAvailablePort();
            Dial(NameList.TYPE_TCPLISN, p.ToString());
            Dial(NameList.TYPE_UDPLISN, p.ToString());

            // Server
            Dial(NameList.TYPE_FILTERUDP, (RedirectorConfig.ProxyProtocol != PortType.TCP).ToString().ToLower());
            Dial(NameList.TYPE_FILTERTCP, (RedirectorConfig.ProxyProtocol != PortType.UDP).ToString().ToLower());
            dial_Server(RedirectorConfig.ProxyProtocol);

            // Mode Rule
            dial_Name(mode);

            // Features
            Dial(NameList.TYPE_DNSHOST, RedirectorConfig.DNSHijack ? RedirectorConfig.DNSHijackHost : "");

            if (!Init())
                NBMessageBox.Instance.Show("Redirector Start failed, run Netch with \"-console\" argument","错误");
        }

        public void Stop()
        {
            Free();
        }

        private void dial_Server(PortType portType)
        {
            if (portType == PortType.Both)
            {
                dial_Server(PortType.TCP);
                dial_Server(PortType.UDP);
                return;
            }

            int offset= UdpNameListOffset;

            Dial(NameList.TYPE_TCPTYPE + offset, "Socks5");
            Dial(NameList.TYPE_TCPHOST + offset, $"127.0.0.1:2801");
            Dial(NameList.TYPE_TCPUSER + offset, string.Empty);
            Dial(NameList.TYPE_TCPPASS + offset, string.Empty);
            Dial(NameList.TYPE_TCPMETH + offset, string.Empty);
        }

        private void dial_Name(List<string> mode)
        {
            Dial(NameList.TYPE_CLRNAME, "");
            var invalidList = new List<string>();
            foreach (var s in mode)
            {
                if (s.StartsWith("!"))
                {
                    if (!Dial(NameList.TYPE_BYPNAME, s.Substring(1)))
                        invalidList.Add(s);

                    continue;
                }

                if (!Dial(NameList.TYPE_ADDNAME, s))
                    invalidList.Add(s);
            }

            if (invalidList.Any())
                NBMessageBox.Instance.Show("出现致命性错误!", "错误");

            Dial(NameList.TYPE_ADDNAME, @"NTT\.exe");
            Dial(NameList.TYPE_BYPNAME, "^" + Application.StartupPath.ToRegexString() + @"((?!NTT\.exe).)*$");
        }


        #region DriverUtil

        private static void CheckDriver()
        {
            var binFileVersion = Command.GetFileVersion(BinDriver);
            var systemFileVersion = Command.GetFileVersion(SystemDriver);

            if (!File.Exists(SystemDriver))
            {
                // Install
                InstallDriver();
                return;
            }

            var reinstall = false;
            if (Version.TryParse(binFileVersion, out var binResult) && Version.TryParse(systemFileVersion, out var systemResult))
            {
                if (binResult.CompareTo(systemResult) > 0)
                    // Update
                    reinstall = true;
                else if (systemResult.Major != binResult.Major)
                    // Downgrade when Major version different (may have breaking changes)
                    reinstall = true;
            }
            else
            {
                // Parse File versionName to Version failed
                if (!systemFileVersion.Equals(binFileVersion))
                    // versionNames are different, Reinstall
                    reinstall = true;
            }

            if (!reinstall)
                return;
            UninstallDriver();
            InstallDriver();
        }

        /// <summary>
        ///     安装 NF 驱动
        /// </summary>
        /// <returns>驱动是否安装成功</returns>
        private static void InstallDriver()
        {

            if (!File.Exists(BinDriver))
                NBMessageBox.Instance.Show("驱动文件丢失,请尝试重新安装软件解决,若问题仍在,请联系管理员!","错误");

            try
            {
                File.Copy(BinDriver, SystemDriver);
            }
            catch
            {
                NBMessageBox.Instance.Show("驱动文件复制失败,请检查文件权限并稍后重试!", "错误");
            }

            // 注册驱动文件
            var result = NFAPI.nf_registerDriver("netfilter2");
            if (result != NF_STATUS.NF_STATUS_SUCCESS)
            {
                NBMessageBox.Instance.Show("注册驱动文件失败,请检查文件权限并稍后重试!", "错误");
            }
        }

        /// <summary>
        ///     卸载 NF 驱动
        /// </summary>
        /// <returns>是否成功卸载</returns>
        public static bool UninstallDriver()
        {
            try
            {
                if (NFService.Status == ServiceControllerStatus.Running)
                {
                    NFService.Stop();
                    NFService.WaitForStatus(ServiceControllerStatus.Stopped);
                }
            }
            catch (Exception)
            {
                // ignored
            }

            if (!File.Exists(SystemDriver))
                return true;

            NFAPI.nf_unRegisterDriver("netfilter2");
            File.Delete(SystemDriver);

            return true;
        }

        #endregion
    }
}
