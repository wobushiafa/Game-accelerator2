using NB.Common;
using NB.Model;
using NB.MyControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NB.Forms
{
    public partial class ChooseLineFrm : BaseFrm
    {
        public ChooseLineFrm()
        {
            InitializeComponent();
        }
        public ShadowsocksR ShadowsocksR { get; set; }
        private Games Games;
        public ChooseLineFrm(Games games):this()
        {
            this.Games = games;
        }

        private void ChooseLineFrm_Load(object sender, EventArgs e)
        {
            btnRefresh.Location = new Point(this.Width - 60, 20);
            cb_Mode.SelectedIndex = 0;
            this.lbGameName.Text = Games.GameName;
            RefreshPanel();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshPanel();
        }

        /// <summary>
        /// 刷新节点列表
        /// </summary>
        private void RefreshPanel()
        {
            Task.Run(()=> 
            {
                this.skinFlowLayoutPanel1.BeginInvoke(new Action(()=> 
                {
                    this.skinFlowLayoutPanel1.Controls.Clear();
                    SysBaseInfo.ShadowsocksR.ForEach(t =>
                    {
                        LineListItem lineListItem = new LineListItem();
                        lineListItem.ShadowsocksR = t;
                        lineListItem.BtnLineClick += ChooseLine;
                        lineListItem.BtnLineDoubleClick += ChooseLineDoubleClick;
                        this.skinFlowLayoutPanel1.Controls.Add(lineListItem);
                    });
                }));
            });
        }

        /// <summary>
        /// 单击选择节点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChooseLine(object sender,EventArgs e)
        {
            LineListItem lineListItem = (sender as CCWin.SkinControl.SkinPanel).Parent as LineListItem;
            foreach(LineListItem item in skinFlowLayoutPanel1.Controls)
            {
                if(item!= lineListItem)
                {
                    item.Check = false;
                }
            }
            this.ShadowsocksR = lineListItem.ShadowsocksR;
            this.lbSelectedLine.Text = lineListItem.ShadowsocksR.Remark;
        }

        /// <summary>
        /// 双击节点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChooseLineDoubleClick(object sender, EventArgs e)
        {
            LineListItem lineListItem = (sender as CCWin.SkinControl.SkinPanel).Parent as LineListItem;
            this.lbSelectedLine.Text = lineListItem.ShadowsocksR.Remark;
            this.ShadowsocksR = lineListItem.ShadowsocksR;
            if (ShadowsocksR == null)
            {
                Task.Run(() =>     //在线程中执行,不然UI会卡顿
                {
                    this.Invoke(new Action(() =>
                    {
                        NBMessageBox.Instance.Show("请先选择节点,再开始加速!", "提示:");
                    }));
                });
                return;
            }
            else
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        /// <summary>
        /// 开始加速
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (ShadowsocksR == null)
            {
                Task.Run(() =>     //在线程中执行,不然UI会卡顿
                {
                    this.Invoke(new Action(() =>
                    {
                        NBMessageBox.Instance.Show("请先选择节点,再开始加速!", "提示");
                    }));
                });
            }
            else
            {
                if (cb_Mode.SelectedIndex == 0)
                {
                    SysBaseInfo.globalMode = GlobalMode.Route;
                }
                else if (cb_Mode.SelectedIndex == 1)
                {
                    //NBMessageBox.Instance.Show("模式二正在开发中!", "错误");
                    SysBaseInfo.globalMode = GlobalMode.NetFilter;
                }

                this.DialogResult = DialogResult.OK;
                //this.Close();
            }
        }

    }
    
}
