using CCWin.SkinControl;
using NB.Common;
using NB.Model;
using NB.MyControls;
using System;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using NB.Controller;
using System.Diagnostics;

namespace NB.Forms
{
    public partial class MainFrm : BaseFrm
    {
        public NotifyIcon Notifyicon { get; set; }//托盘图标

        private bool IsConnected = false;//当前是否在加速中

        SSRController ssrController;
        TUNTAPController tuntapController;
        NFController nfController;

        public MainFrm()
        {
            InitializeComponent();
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000; // 用双缓冲绘制窗口的所有子控件
                return cp;
            }
        }

        #region 关闭按钮是否置托盘图标

        /// <summary>
        /// 托盘图标双击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NotifyIcon_MouseDoubleClick(object sender,MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Show();
                this.WindowState = FormWindowState.Normal;
                Notifyicon.Visible = false;
                this.ShowInTaskbar = true;
            }
        }

        /// <summary>
        /// 置托盘
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NotifyIcon_Start()
        {
            //隐藏主窗体
            this.Hide();
            Notifyicon = new NotifyIcon();
            Notifyicon.BalloonTipText = "无界一直都在哦...主人要记得我哦!";//托盘气泡显示内容
            Notifyicon.Text = "无界网游加速器";
            Notifyicon.Visible = true;//托盘按钮是否可见
            Notifyicon.Icon = System.Drawing.Icon.ExtractAssociatedIcon(System.Windows.Forms.Application.ExecutablePath);//托盘中显示的图标
            Notifyicon.ShowBalloonTip(1000);//托盘气泡显示时间
            Notifyicon.MouseDoubleClick += NotifyIcon_MouseDoubleClick;
        }
        #endregion

        #region 窗体信息基本
        private void MainFrm_Load(object sender, EventArgs e)
        {
            sysMore.Location = new Point(this.Width - 96, 15);
            sysMin.Location = new Point(this.Width - 65, 15);
            ThreadPool.QueueUserWorkItem(new WaitCallback(LoadGames));//线程池中加载游戏列表
            if (SysBaseInfo.MyGames.Count == 0)
            {
                SwitchPages(0);
            }
            else
            {
                SwitchPages(1);
            }
        }

        private void MainFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseProxy();
            #region 关闭代理进程
            Process[] pProxy = Process.GetProcessesByName("Proxy");
            Process[] pTun2socks = Process.GetProcessesByName("tun2socks");
            try
            {
                foreach (var p in pProxy)
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

        private void sysMin_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Minimized;
            NotifyIcon_Start();
        }
        #endregion

        #region 左侧导航按钮事件
        private void SwitchPages(int index)
        {
            try
            {
                if (index== 0)
                {
                    btnNavAllGames.BackgroundImage = Properties.Resources.store_hover;
                    btnNavMyGames.BackgroundImage = Properties.Resources.game_normal;
                }
                else if (index == 1)
                {
                    btnNavAllGames.BackgroundImage = Properties.Resources.store_normal;
                    btnNavMyGames.BackgroundImage = Properties.Resources.game_hover;
                }
                else
                {
                    btnNavAllGames.BackgroundImage = Properties.Resources.store_normal;
                    btnNavMyGames.BackgroundImage = Properties.Resources.game_normal;
                }
                skinTabControl1.SelectedIndex = index;
            }
            catch
            {

            }
        }

        private void btnNavAllGames_Click(object sender, EventArgs e)
        {
            SwitchPages(0); 
        }

        private void btnNavMyGames_Click(object sender, EventArgs e)
        {
            SwitchPages(1);
        }
        private void btnNavGit_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                this.Invoke(new Action(() =>
                {
                    NBMessageBox.Instance.Show("该功能尚未开发,敬请期待...", "提示");
                }));
            });
            
        }
        #endregion

        /// <summary>
        /// 加载所有游戏列表
        /// </summary>
        /// <param name="state"></param>
        private void LoadGames(object state)
        {
            try
            {
                if (SysBaseInfo.Games.Count > 0)
                {
                    panel_MyGames.SuspendLayout();
                    foreach (Games game in SysBaseInfo.Games)
                    {
                        IconListItem iconListItem = new IconListItem();
                        iconListItem.Game = game;
                        iconListItem.GameImage = Image.FromFile(Environment.CurrentDirectory + "/res/Small/" + game.SerialCode + ".png");
                        iconListItem.IconListItemMouseClick += ChooseGame;
                        panel_AllGames.BeginInvoke(new Action(() =>
                        {
                            panel_AllGames.Controls.Add(iconListItem);

                        }));
                    }
                }
                else
                {
                    NBMessageBox.Instance.Show("获取游戏列表失败,请重新运行本软件,若问题一直存在,请联系管理员!", "错误");
                }
            }
            catch { }
            finally
            {
                panel_MyGames.ResumeLayout();
            }

            ///加载我的游戏列表
            if (SysBaseInfo.MyGames != null)
            {
                foreach(MyGames myGames in SysBaseInfo.MyGames)
                {
                    MyGamesListItem item = new MyGamesListItem();
                    item.Game = myGames.Game;
                    item.GameLine = myGames.ShadowsocksR;
                    item.Name = myGames.Game.GameName;
                    item.GameImage = Image.FromFile(Environment.CurrentDirectory + "/res/Big/" + item.Game.SerialCode + ".png");
                    item.BtnDeleteClick += DeleteMyGame;
                    item.BtnChooseLine += ChooseLine;
                    item.BtnConnect += InitConnection;
                    panel_MyGames.BeginInvoke(new Action(() =>
                    {
                        panel_MyGames.Controls.Add(item);
                    }));
                }
            }
        }

        /// <summary>
        /// 当游戏列表内游戏被选择,则把该游戏添加到我的游戏中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChooseGame(object sender,EventArgs e)
        {
            try
            {
                IconListItem iconListItem = (sender as SkinPanel).Parent.Parent as IconListItem;
                Control[] list = panel_MyGames.Controls.Find(iconListItem.Game.GameName, true);
                if (list.Length == 0)
                {
                    MyGamesListItem myGamesListItem = new MyGamesListItem();
                    myGamesListItem.Name = iconListItem.Game.GameName;
                    myGamesListItem.Game = iconListItem.Game;
                    myGamesListItem.GameImage = Image.FromFile(Environment.CurrentDirectory + "/res/Big/" + iconListItem.Game.SerialCode + ".png");
                    myGamesListItem.BtnDeleteClick += DeleteMyGame;
                    myGamesListItem.BtnChooseLine += ChooseLine;
                    myGamesListItem.BtnConnect += InitConnection;
                    panel_MyGames.Controls.Add(myGamesListItem);
                    panel_MyGames.Controls.SetChildIndex(myGamesListItem, 0);
                }
                else
                {
                    panel_MyGames.Controls.SetChildIndex(list[0], 0);
                }
                SwitchPages(1);
            }
            catch
            {
                NBMessageBox.Instance.Show("添加游戏失败,请请稍后重试,若问题一直存在,请联系管理员!", "错误");
            }

        }

        /// <summary>
        /// 删除删游,同时也要删除mygames配置文件里的游戏
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteMyGame(object sender,EventArgs e)
        {
            try
            {
                MyGamesListItem myGamesListItem = (sender as SkinPanel).Parent.Parent as MyGamesListItem;
                panel_MyGames.Controls.Remove(myGamesListItem);

                MyGames myGames = SysBaseInfo.MyGames.Find(t => t.Game == myGamesListItem.Game);
                SysBaseInfo.MyGames.Remove(myGames);
                WriteMyGamesRecord();
            }
            catch
            {
                NBMessageBox.Instance.Show("删除失败,请稍后重试!若问题一直存在,请联系管理员!", "错误");
            }
        }

        /// <summary>
        /// 写到配置文件记录我的游戏有哪些以及节点信息
        /// </summary>
        private void WriteMyGamesRecord()
        {
            try
            {
                SysBaseInfo.MyGames.Clear();//首先先清空集合
                foreach (MyGamesListItem myGamesListItem in panel_MyGames.Controls)
                {
                    MyGames myGames = new MyGames();
                    myGames.Game = myGamesListItem.Game;
                    myGames.ShadowsocksR = myGamesListItem.GameLine;
                    SysBaseInfo.MyGames.Add(myGames);
                }
                string list = JsonConvert.SerializeObject(SysBaseInfo.MyGames);
                list = EncryptsHelper.Encrypt(list);
                File.WriteAllText(Environment.CurrentDirectory + "/Config/MyGames.config", list);
            }
            catch
            {
                NBMessageBox.Instance.Show("保存游戏记录失败,请检查本地文件权限,此异常并不影响本次加速", "提示");
            }
        }

        /// <summary>
        /// panel_MyGames数量限制为3个
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel_MyGames_ControlAdded(object sender, ControlEventArgs e)
        {
            int count = panel_MyGames.Controls.Count;
            if (count == 4)
            {
                panel_MyGames.Controls.RemoveAt(2);
                panel_MyGames.Controls.Add(sender as MyGamesListItem);
            }
            else
            {
                panel_MyGames.Controls.Add(sender as MyGamesListItem);
            }
        }

        /// <summary>
        /// 选择节点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChooseLine(object sender,EventArgs e)
        {
            MyGamesListItem myGamesListItem = (sender as SkinLabel).Parent.Parent as MyGamesListItem;
            Task.Run(() =>
            {
                this.Invoke(new Action(() =>
                {
                    ChooseLineFrm chooseLineFrm = new ChooseLineFrm(myGamesListItem.Game);
                    if (chooseLineFrm.ShowDialog() == DialogResult.OK)
                    {
                        myGamesListItem.GameLine = chooseLineFrm.ShadowsocksR;
                        WriteMyGamesRecord();
                    }
                }));
            });
        }

        /// <summary>
        /// 关闭所有代理进程
        /// </summary>
        private void CloseProxy()
        {
            try
            {
                ssrController.Stop();
                //判断当前模式
                if (SysBaseInfo.globalMode == GlobalMode.Route)
                {
                    tuntapController.Stop();
                }
                else
                {
                    nfController.Stop();
                }
            }
            catch (Exception ex)
            {
            }
        }

        /// <summary>
        /// 还原我的游戏控件动画
        /// </summary>
        /// <param name="item"></param>
        private void RestoreMyGame(MyGamesListItem item)
        {
            item.Animation = false;
            item.State = "未加速";
            IsConnected = false;
            item.BtnDeleteClick += DeleteMyGame;
        }

        /// <summary>
        /// 加速前进行检查
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InitConnection(object sender,EventArgs e)
        {
            try
            {
                MyGamesListItem myGamesListItem = (sender as SkinPanel).Parent.Parent as MyGamesListItem;
                if (IsConnected)  //若当前状态已经是在加速中了
                { 
                    if (myGamesListItem.State == "加速中") //此时正在加速该游戏,让他断开连接
                    {
                        try
                        {
                            CloseProxy();
                            RestoreMyGame(myGamesListItem);
                            TimingStop();
                            PingTimingStop();
                        }
                        catch { }
                    }
                    else //此时正在加速其他游戏,这时弹出信息框提示请先断开连接
                    {
                        Task.Run(() =>     //在线程中执行,不然UI会卡顿
                        {
                            this.Invoke(new Action(() =>
                            {
                                NBMessageBox.Instance.Show("请先断开当前加速的连接,再启用新的加速!", "提示:");
                            }));
                        });
                    }
                }
                else  //当前状态还没有开始加速
                { 
                    if (myGamesListItem.GameLine == null)//没有选择节点,就先选择节点
                    {
                        Task.Run(() =>
                        {
                            this.BeginInvoke(new Action(() =>
                            {
                                ChooseLineFrm chooseLineFrm = new ChooseLineFrm(myGamesListItem.Game);
                                if (chooseLineFrm.ShowDialog() == DialogResult.OK)
                                {
                                    myGamesListItem.GameLine = chooseLineFrm.ShadowsocksR;
                                    WriteMyGamesRecord();
                                }
                            }));
                        });
                    }
                    else   //开始加速
                    {
                        //先放动画,不然获取路由表的时间看上去像是卡住了
                        myGamesListItem.State = "加速中";
                        IsConnected = true;
                        myGamesListItem.BtnDeleteClick = null;
                        myGamesListItem.Animation = true;
                        Application.DoEvents();

                        Task.Run(() =>
                        {
                            this.Invoke(new Action(() =>
                            {
                                SysBaseInfo.Rule.Clear();
                                SysBaseInfo.Rule = Command.ReadUrlToList(SysBaseInfo.WebUrl + myGamesListItem.Game.SerialCode + ".txt");//获取路由表文件
                                if (ConnectionSSR(myGamesListItem)==false)
                                {
                                    ssrController.Stop();
                                    RestoreMyGame(myGamesListItem);
                                    return;
                                }
                            }));
                        });
                    }
                }
            }
            catch
            {
                NBMessageBox.Instance.Show("加速出现异常,请重新加速!若问题一直存在,请联系管理员!", "错误");
            }
        }

        /// <summary>
        /// 正式开始加速
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        private bool ConnectionSSR(MyGamesListItem item)
        {
            ssrController = new SSRController(item.GameLine);
            if (!ssrController.Start()) return false;

            //判断当前模式
            if (SysBaseInfo.globalMode == GlobalMode.Route)
            {
                tuntapController = new TUNTAPController();
                if (!tuntapController.Start())
                {
                    return false;
                }

                if (!File.Exists(Environment.CurrentDirectory + "/res/BG/" + item.Game.SerialCode + ".png"))
                {
                    panel_Complete.BackgroundImage = Properties.Resources.Complete_bg;
                }
                else
                {
                    panel_Complete.BackgroundImage = Image.FromFile(Environment.CurrentDirectory + "/res/BG/" + item.Game.SerialCode + ".png");
                }
                lb_CompleteGameName.Text = item.Game.GameName;
                lb_CompleteGameLine.Text = item.GameLine.Remark;
                Timing();
                PingTiming((object)EncryptsHelper.Decrypt(item.GameLine.HostName));
                SwitchPages(2);

            }
            else
            {
                nfController = new NFController();
                nfController.Start(SysBaseInfo.NFRule);
                lb_CompleteGameName.Text = item.Game.GameName;
                lb_CompleteGameLine.Text = item.GameLine.Remark;
                Timing();
                SwitchPages(2);
            }
            lb_CompletePing.Text=Command.PingIP(EncryptsHelper.Decrypt(item.GameLine.HostName)).ToString()+" MS";
            return true;
        }

        /// <summary>
        /// 断开加速
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_CompleteStop_Click(object sender, EventArgs e)
        {
            Task.Run(() => 
            {
                this.Invoke(new Action(() =>
                {
                    foreach(MyGamesListItem item in panel_MyGames.Controls)
                    {
                        if (item.Animation)
                        {
                            RestoreMyGame(item);
                        }
                    }
                    TimingStop();
                    PingTimingStop();
                    CloseProxy();
                    SwitchPages(1);
                }));
            });
        }
        private void btn_CompleteStopbkg_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                this.Invoke(new Action(() =>
                {
                    foreach (MyGamesListItem item in panel_MyGames.Controls)
                    {
                        if (item.Animation)
                        {
                            RestoreMyGame(item);
                        }
                    }
                    TimingStop();
                    PingTimingStop();
                    CloseProxy();
                    SwitchPages(1);
                }));
            });
        }

        #region 计时器
        System.Threading.Timer Mytimer;
        long TimeCount;
        delegate void SetValue();
        private void TimerUp(object state)
        {
            this.Invoke(new SetValue(ShowTime));
            TimeCount++;
        }
        public void ShowTime()
        {
            TimeSpan t = new TimeSpan(0, 0, (int)TimeCount);
            lb_CompleteTimer.Text = string.Format("{0:00}:{1:00}:{2:00}", t.Hours, t.Minutes, t.Seconds);
            Process[] pProxy = Process.GetProcessesByName("Proxy");
            if (pProxy == null || pProxy.Length == 0)
            {
                btn_CompleteStop_Click(new object(), new EventArgs());
            }
        }
        //开始计时
        private void Timing()
        {
            Mytimer = new System.Threading.Timer(new TimerCallback(TimerUp), null, Timeout.Infinite, 1000);
            TimeCount = 0;
            Mytimer.Change(0, 1000);
        }
        //停止计时
        private void TimingStop()
        {
            Mytimer.Change(Timeout.Infinite, 1000);
        }

        #endregion

        #region 延迟计时器
        System.Threading.Timer PingTimer;
        long PingTimeCount;
        //delegate void SetPingValue(object state);3
        //开始计时
        private void PingTiming(object state)
        {
            TimerCallback timeCB = new TimerCallback((o) => { PingTimerUp(state); });
            PingTimer = new System.Threading.Timer(timeCB, null, Timeout.Infinite, 5000);
            TimeCount = 0;
            PingTimer.Change(0, 5000);
        }
        //停止计时
        private void PingTimingStop()
        {
            PingTimer.Change(Timeout.Infinite, 1000);
        }
        private void PingTimerUp(object state)
        {
            this.Invoke(new Action(()=> 
            {
            int result = Command.PingIP(state.ToString());
                {
                    if (result > 0 && result < 90) lb_CompletePing.ForeColor = Color.Chartreuse;
                    else if (result > 89 && result < 200) lb_CompletePing.ForeColor = Color.Chocolate;
                    else lb_CompletePing.ForeColor = Color.Red;

                    lb_CompletePing.Text = result.ToString() + " MS";
                }
            }));
            PingTimeCount++;
        }
        #endregion


    }
}
