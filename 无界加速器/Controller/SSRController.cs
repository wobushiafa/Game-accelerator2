using NB.Common;
using NB.Forms;
using NB.Model;
using System.Diagnostics;
using System.IO;

namespace NB.Controller
{
    public class SSRController
    {
        public Process controller;
        public ShadowsocksR ssr;
        public SSRController(ShadowsocksR ssrr)
        {
            ssr = ssrr;
        }
        public bool Start()
        {
            foreach (var proc in Process.GetProcessesByName("Proxy"))
            {
                try
                {
                    proc.Kill();
                }
                catch
                {
                    // 跳过
                }
            }

            string HostName = EncryptsHelper.Decrypt(ssr.HostName);
            string Port = EncryptsHelper.Decrypt(ssr.Port);
            string Password = EncryptsHelper.Decrypt(ssr.Password);
            string Method = EncryptsHelper.Decrypt(ssr.Method);
            string Protocol = EncryptsHelper.Decrypt(ssr.Protocol);
            string ProtocolParam = EncryptsHelper.Decrypt(ssr.ProtocolParam);
            string Obfs = EncryptsHelper.Decrypt(ssr.Obfs);
            string OBFSParam = EncryptsHelper.Decrypt(ssr.OBFSParam);

            string arguments = $"-s {HostName} -p {Port} -k \"{Password}\" -m {Method} -t 120 -b 127.0.0.1 -l 2801 -u";
            if (!string.IsNullOrEmpty(Protocol))
            {
                arguments += $" -O {Protocol}";
                if (!string.IsNullOrEmpty(ProtocolParam)) arguments += $" -G \"{ProtocolParam}\"";
            }
            if (!string.IsNullOrEmpty(Obfs))
            {
                arguments += $" -o {Obfs}";
                if (!string.IsNullOrEmpty(OBFSParam)) arguments += $" -g \"{OBFSParam}\"";
            }
            string path = System.Environment.CurrentDirectory;
            if (!File.Exists(path + @"\bin\Proxy.exe"))
            {
                NBMessageBox.Instance.Show("驱动文件丢失,请尝试重新安装本软件解决!", "提示");
                return false;
            }
            controller = new Process();
            controller.StartInfo.FileName = path + @"\bin\Proxy.exe";
            controller.StartInfo.Arguments = arguments.ToString();
            controller.StartInfo.UseShellExecute = false;    //是否使用操作系统shell启动
            controller.StartInfo.RedirectStandardInput = true;//接受来自调用程序的输入信息
            controller.StartInfo.RedirectStandardOutput = true;//由调用程序获取输出信息
            controller.StartInfo.CreateNoWindow = true;//不显示程序窗口
            controller.Start();
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
            }
            catch
            {

            }
        }
    }
}
