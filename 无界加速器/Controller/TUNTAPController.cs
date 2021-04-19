using NB.Common;
using NB.Forms;
using NB.Interops;
using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;

namespace NB.Controller
{
    public class TUNTAPController
    {
        public Process controller;

        public bool Start()
        {
            foreach (var proc in Process.GetProcessesByName("tun2socks"))
            {
                try
                {
                    proc.Kill();
                }
                catch (Exception)
                {
                    // 跳过
                }
            }

            if (!File.Exists("bin\\tun2socks.exe"))
            {
                NBMessageBox.Instance.Show("驱动文件丢失,请尝试重新安装程序!", "错误");
                return false;
            }
            if (!CheckEnvironment()) return false;
            if (!SetupBypass()) return false;

            controller = new Process();
            controller.StartInfo.WorkingDirectory = String.Format("{0}\\bin", Environment.CurrentDirectory);
            controller.StartInfo.FileName = String.Format("{0}\\bin\\tun2socks.exe", Environment.CurrentDirectory);
            controller.StartInfo.UseShellExecute = false;    //是否使用操作系统shell启动
            controller.StartInfo.RedirectStandardInput = true;//接受来自调用程序的输入信息
            controller.StartInfo.RedirectStandardOutput = true;//由调用程序获取输出信息
            controller.StartInfo.CreateNoWindow = true;//不显示程序窗口
            controller.StartInfo.Arguments = String.Format("-proxyServer 127.0.0.1:2801 -tunAddr {0} -tunMask {1} -tunGw {2} -tunDns 8.8.8.8,8.8.4.4", 
                TUNTAPConfig.Address, TUNTAPConfig.Netmask, TUNTAPConfig.Gateway);
            controller.Start();

            SetupBypass();
            return true;

        }

        /// <summary>
        /// 检查虚拟网卡驱动是否安装
        /// </summary>
        public bool CheckEnvironment()
        {
            try
            {
                // 搜索 TUN/TAP 适配器的索引
                TUNTAPConfig.ComponentID = TUNTAP.GetComponentID();
                if (String.IsNullOrEmpty(TUNTAPConfig.ComponentID))
                {
                    NBMessageBox.Instance.Show("未安装虚拟网卡驱动,安装程序将会在按下 确定 按钮后启动!", "提示");
                    if(File.Exists(Environment.CurrentDirectory+ "\\bin\\tap-driver\\addtap.bat"))
                    {
                        TUNTAP.Addtap();
                    }
                    else
                    {
                        NBMessageBox.Instance.Show("驱动文件丢失,请尝试重新安装程序!", "提示");
                        return false;
                    }
                    
                }
                var name = TUNTAP.GetName(TUNTAPConfig.ComponentID);
                foreach (var adapter in NetworkInterface.GetAllNetworkInterfaces())
                {
                    if (adapter.Name == name)
                    {
                        TUNTAPConfig.Adapter = adapter;
                        TUNTAPConfig.Index = adapter.GetIPProperties().GetIPv4Properties().Index;
                        break;
                    }
                }
                return true;
            }
            catch { return false; }
        }

        /// <summary>
        /// 配置路由表
        /// </summary>
        public bool SetupBypass()
        {
            if (SysBaseInfo.Rule==null)
            {
                NBMessageBox.Instance.Show("获取路由文件失败,请稍后重试!", "错误");
                return false;
            }

            foreach (var ip in SysBaseInfo.Rule)
            {
                var info = ip.Split('/');

                if (info.Length == 2)
                {
                    if (int.TryParse(info[1], out var prefix))
                    {
                        NativeMethods.CreateRoute(info[0], prefix, TUNTAPConfig.Gateway.ToString(), TUNTAPConfig.Index);
                    }
                }
            }
            return true;
        }

        /// <summary>
        ///		停止
        /// </summary>
        public void Stop()
        {
            try
            {
                if (controller != null && !controller.HasExited)
                {
                    controller.Kill();
                }

                foreach (var ip in SysBaseInfo.Rule)
                {
                    var info = ip.Split('/');
                    var address = IPAddress.Parse(info[0]);

                    if (!IPAddress.IsLoopback(address))
                    {
                        NativeMethods.DeleteRoute(address.ToString(), int.Parse(info[1]), TUNTAPConfig.Gateway.ToString(), TUNTAPConfig.Index);
                    }
                }
            }
            catch (Exception e)
            {
                
            }
        }
    }
}
