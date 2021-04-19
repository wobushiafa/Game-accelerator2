using NB.Forms;
using NB.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NB.MyControls
{
    public partial class MyGamesListItem : UserControl
    {
        public MyGamesListItem()
        {
            InitializeComponent();
        }
        private Games game;
        [Category("Games"), Description("游戏实体模型")]
        public Games Game
        {
            get { return game; }
            set
            {
                game = value;
                lbGameName.Text = game.GameName;
            }
        }

        [Category("GameImage"), Description("背景图片")]
        public Image GameImage
        {
            get { return panel_Back.BackgroundImage; }
            set
            {
                panel_Back.BackgroundImage = value;
            }
        }

        private ShadowsocksR gameLine;
        [Category("GameLine"), Description("游戏节点")]
        public ShadowsocksR GameLine
        {
            get { return gameLine; }
            set
            {
                gameLine = value;
                if (gameLine == null)
                {
                    btnChooseLine.Text = "请选择节点";
                }
                else
                {
                    btnChooseLine.Text = gameLine.Remark;
                }
            }
        }

        private string state;
        [Category("State"), Description("当前状态,未加速或加速中,状态加速中边框颜色为橘黄色")]
        public string State
        {
            get { return state; }
            set
            {
                state = value;
                if (state == "加速中")
                {
                    this.panel_Back.BorderColor = Color.Coral;
                }
                else
                {
                    this.panel_Back.BorderColor = Color.Black;
                }
            }
        }

        private bool animation = false;
        [Category("Animation"), Description("显示加速过程进度条")]
        public bool Animation
        {
            get { return animation; }
            set
            {
                animation = value;
                if (animation)
                {
                    progressbar.BorderColor = Color.Coral;
                    progressbar.Width = 100;
                    progressbar.Visible = true;
                    Application.DoEvents();
                    try
                    {
                        Task.Run(()=>
                        {
                            BeginInvoke(new Action(async ()=> 
                            {
                                progressbar.Width++;
                                while (progressbar.Width < this.Width)
                                {
                                    await Task.Delay(1);
                                    progressbar.Width++;

                                }
                            }));
                        });
                    }
                    catch
                    {

                    }
                }
                else
                {
                    progressbar.Width = 0;
                    progressbar.Visible = false;
                }
            }
        }

        public delegate void DeleteGame(object sender, EventArgs e);
        public DeleteGame BtnDeleteClick;

        public delegate void ChooseLine(object sender, EventArgs e);
        public ChooseLine BtnChooseLine;

        public delegate void ConnectBroker(object sender, EventArgs e);
        public ConnectBroker BtnConnect;

        /// <summary>
        /// 删除游戏按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (BtnDeleteClick != null)
            {
                BtnDeleteClick(sender, e);
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (BtnConnect != null)
                BtnConnect(sender, e);
        }

        private void btnChooseLine_Click(object sender, EventArgs e)
        {
            if (BtnChooseLine != null)
            {
                BtnChooseLine(sender, e);
            }
        }

        private void panel_Back_MouseEnter(object sender, EventArgs e)
        {
            panel_Back.BorderColor = Color.Coral;
        }

        private void panel_Back_MouseLeave(object sender, EventArgs e)
        {
            panel_Back.BorderColor = Color.Transparent;
        }
    }
}
