using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace NB.Common
{
    public static class Command
    {
        
        public static int TestIP(string ip) 
        {
            try
            {
                Ping pingSender = new Ping();
                PingOptions options = new PingOptions();
                options.DontFragment = true;
                //测试数据
                string data = "";
                byte[] buffer = Encoding.ASCII.GetBytes(data);
                //设置超时时间
                int timeout = 120;
                //调用同步 send 方法发送数据,将返回结果保存至PingReply实例
                PingReply reply = pingSender.Send(ip, timeout, buffer, options);
                if (reply.Status == IPStatus.Success)
                {
                    return reply.RoundtripTime.ToInt();
                }
                else
                {
                    return 0;
                }
            }
            catch
            {
                return 0;
            }
        }
        public static int PingIP(string ip)
        {
            try
            {
                int result = TestIP(ip);
                if (result != 0) return result;
                else return TestIP(ip);

            }
            catch
            {
                return 0;
            }
        }

        /// <summary>
        /// 从url下载图片
        /// </summary>
        /// <param name="url"></param>
        /// <param name="path">保存的路径</param>
        public static void DownLoadImg(string url,string path) 
        {
            try
            {
                WebClient webClient = new WebClient();
                Byte[] imgData = webClient.DownloadData(url);
                Stream ms = new MemoryStream(imgData);
                ms.Position = 0;
                Image img = Image.FromStream(ms);
                img.Save(path, ImageFormat.Png);
            }
            catch
            {
                
            }

        }

        /// <summary>
        /// 下载路由表txt文件
        /// </summary>
        /// <param name="url"></param>
        /// <param name="path"></param>
        public static void DownLoadRoutetxt(string url,string path)
        {
            try
            {
                HttpWebRequest oHttp_Web_Req = (HttpWebRequest)WebRequest.Create(url);
                Stream oStream = oHttp_Web_Req.GetResponse().GetResponseStream();
                using (StreamReader respStreamReader = new StreamReader(oStream, Encoding.UTF8))
                {
                    string line = string.Empty;
                    while ((line = respStreamReader.ReadLine()) != null)
                    {

                        UTF8Encoding utf8 = new UTF8Encoding(false);
                        //写txt文件
                        using (StreamWriter sw = new StreamWriter(path, true, utf8))
                        {
                            if(!File.Exists(path))
                            {
                                File.Delete(path);
                            }
                            sw.WriteLine(line);
                        }

                    }
                }
            }
            catch 
            {

            }
        }

        /// <summary>
        /// 从text文件转List<string> 
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static List<string> ReadTextFileToList(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            List<string> list = new List<string>();
            StreamReader sr = new StreamReader(fs);
            //使用StreamReader类来读取文件 
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            // 从数据流中读取每一行，直到文件的最后一行
            string tmp = sr.ReadLine();
            while (tmp != null)
            {
                list.Add(tmp);
                tmp = sr.ReadLine();
            }
            //关闭此StreamReader对象 
            sr.Close();
            fs.Close();
            return list;
        }

        public static List<string> ReadUrlToList(string url)
        {
            try
            {
                List<string> list = new List<string>();
                HttpWebRequest oHttp_Web_Req = (HttpWebRequest)WebRequest.Create(url);
                Stream oStream = oHttp_Web_Req.GetResponse().GetResponseStream();
                using (StreamReader respStreamReader = new StreamReader(oStream, Encoding.UTF8))
                {
                    string line = string.Empty;
                    // 从数据流中读取每一行，直到文件的最后一行
                    string tmp = respStreamReader.ReadLine();
                    while (tmp != null)
                    {
                        list.Add(tmp);
                        tmp = respStreamReader.ReadLine();
                    }
                    //关闭此StreamReader对象 
                    respStreamReader.Close();
                }
                return list;
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// 获取文件版本信息
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        public static string GetFileVersion(string file)
        {
            if (File.Exists(file))
                return FileVersionInfo.GetVersionInfo(file).FileVersion ?? "";

            return "";
        }
    }
}
