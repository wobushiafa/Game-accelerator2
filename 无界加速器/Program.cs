using NB.Common;
using NB.Forms;
using NB.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace NB
{
    public static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        public static void Main()
        {
            #region 连接数据库
            NewLife.Setting.Current.Debug = false;
            NewLife.Setting.Current.LogLevel = NewLife.Log.LogLevel.Fatal;
            XCode.Setting.Current.Debug = false;
            XCode.Setting.Current.ShowSQL = false;
            XCode.Setting.Current.Migration = XCode.DataAccessLayer.Migration.Off;
            XCode.Setting.Current.Save();
            NewLife.Setting.Current.Save();

            string constr = "CqwdHtfaCdvU9mzXQSJ62fyhctsOjMrm23qu6Djg2QzdBH45/9So6BlnxHpAjJsHLiVsAC5kahoeYtojKQQW0q3aiULY977C";
            XCode.DataAccessLayer.DAL.AddConnStr("NoBoundaries",EncryptsHelper.Decrypt(constr),null,"sqlserver");
            #endregion

            CheckEnviroment();
            LoadCache();

            bool runone;
            System.Threading.Mutex run = new System.Threading.Mutex(true, "无界网游加速器", out runone);
            if (runone)
            {
                run.ReleaseMutex();
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainFrm());
            }
            else
            {
                NBMessageBox.Instance.Show("已经运行了一个实例了。","错误");
            }
        
        }

        public static void CheckEnviroment()
        {
            string path = Environment.CurrentDirectory;
            if (!Directory.Exists(path+"/res/"))
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(path+"/res/");
                directoryInfo.Create();
            }
            if (!Directory.Exists(path + "/res/Small/"))
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(path + "/res/Small/");
                directoryInfo.Create();
            }
            if (!Directory.Exists(path + "/res/Big/"))
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(path + "/res/Big/");
                directoryInfo.Create();
            }
            if (!Directory.Exists(path + "/res/BG/"))
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(path + "/res/BG/");
                directoryInfo.Create();
            }
            #region 关闭代理进程
            Process[] pProxy = Process.GetProcessesByName("Proxy");
            Process[] pTun2socks = Process.GetProcessesByName("tun2socks");
            try
            {
                foreach(var p in pProxy)
                {
                    p.Kill();
                }
                foreach (var p2 in pTun2socks)
                {
                    p2.Kill();
                }
            }
            catch
            {

            }
            #endregion

        }

        public static void LoadCache()
        {
            try
            {
                SysBaseInfo.globalMode = GlobalMode.Route;
                SysBaseInfo.NFRule.Add("msedge.exe");
                //SysBaseInfo.globalMode = GlobalMode.NetFilter;
                if (File.Exists(Environment.CurrentDirectory + "/Config/MyGames.config"))
                {
                    string list = File.ReadAllText(Environment.CurrentDirectory + "/Config/MyGames.config");
                    list = EncryptsHelper.Decrypt(list);
                    SysBaseInfo.MyGames = JsonConvert.DeserializeObject<List<MyGames>>(list);
                }

                SysBaseInfo.ShadowsocksR = ShadowsocksR.FindAll("State='启用'","Type asc",null,0,0).ToList();
                SysBaseInfo.Games = Games.FindAll("GameSmallImageUrl!=''", "GameName asc", null, 0, 0).ToList();
                if (SysBaseInfo.Games.Count > 0)
                {
                    foreach (Games games in SysBaseInfo.Games)
                    {
                        if (!File.Exists(Environment.CurrentDirectory + "/res/Big/" + games.SerialCode + ".png"))
                        {
                            Command.DownLoadImg(games.GameBigImageUrl, Environment.CurrentDirectory + "/res/Big/" + games.SerialCode + ".png");
                        }
                        if (!File.Exists(Environment.CurrentDirectory + "/res/Small/" + games.SerialCode + ".png"))
                        {
                            Command.DownLoadImg(games.GameSmallImageUrl, Environment.CurrentDirectory + "/res/Small/" + games.SerialCode + ".png");
                        }
                        if (!File.Exists(Environment.CurrentDirectory + "/res/BG/" + games.SerialCode + ".png"))
                        {
                            Command.DownLoadImg(games.GameBGImageUrl, Environment.CurrentDirectory + "/res/BG/" + games.SerialCode + ".png");
                        }
                    }
                }
            }
            catch
            {
                NBMessageBox.Instance.Show("加载数据失败,请尝试重新打开!若问题一直存在,请联系管理员!", "提示");
            }
            
        }
        
    }
}
