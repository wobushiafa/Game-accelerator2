using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NB.Model;
using NB.Common;

namespace NB.MyControls
{
    public partial class LineListItem : UserControl
    {
        private ShadowsocksR shadowsocksR;
        public ShadowsocksR ShadowsocksR
        {
            get
            {
                return shadowsocksR;
            }
            set
            {
                shadowsocksR = value;
                if (shadowsocksR != null)
                {
                    lbRemark.Text = shadowsocksR.Remark;
                    this.Ping = Command.PingIP(EncryptsHelper.Decrypt(ShadowsocksR.HostName));
                }
            }
        }

        private int ping;
        public int Ping
        {
            get { return ping; }
            set
            {
                ping = value;
                if (ping > 0&&ping<90)
                {
                    panel_Ping.BackgroundImage = Properties.Resources.select_server_good;
                    lbPing.Text = ping.ToString();
                }
                else if (ping >= 90 && ping <= 200)
                {
                    panel_Ping.BackgroundImage = Properties.Resources.select_server_just;
                    lbPing.Text = ping.ToString();
                }
                else
                {
                    panel_Ping.BackgroundImage = Properties.Resources.select_server_low;
                    lbPing.Text = "超时";
                }
                
            }
        }

        private bool check=false;
        public bool Check
        {
            get { return check; }
            set
            {
                check = value;
                if (check)
                {
                    panel_Back.MouseLeave -= panel_Back_MouseLeave;
                    panel_Back.MouseEnter -= panel_Back_MouseEnter;
                    panel_Back.BorderColor = Color.Coral;
                }
                else
                {
                    panel_Back.MouseEnter += panel_Back_MouseEnter;
                    panel_Back.MouseLeave += panel_Back_MouseLeave;
                    panel_Back.BorderColor = Color.Transparent;
                }
            }
        }


        public delegate void LineClick(object sender, EventArgs e);
        public LineClick BtnLineClick;

        public delegate void LineDoubleClick(object sender, EventArgs e);
        public LineDoubleClick BtnLineDoubleClick;

        public LineListItem()
        {
            InitializeComponent();
        }

        private void panel_Back_MouseEnter(object sender, EventArgs e)
        {
            if (Check == false) panel_Back.BorderColor = Color.Coral;
        }

        private void panel_Back_MouseLeave(object sender, EventArgs e)
        {
            if(Check==false) panel_Back.BorderColor = Color.Transparent;
        }

        private void panel_Back_MouseClick(object sender, MouseEventArgs e)
        {
            Check = true;
            BtnLineClick(sender, e);
        }

        private void panel_Back_DoubleClick(object sender, EventArgs e)
        {
            Check = true;
            BtnLineDoubleClick(sender, e);
        }
    }
}
