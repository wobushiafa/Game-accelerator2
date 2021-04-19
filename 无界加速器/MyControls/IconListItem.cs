using NB.Model;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace NB.MyControls
{
    public partial class IconListItem : UserControl
    {

        [Category("Games"), Description("游戏实体模型")]
        private Games game;
        public Games Game 
        {
            get { return game; }
            set 
            { 
                game = value;
                this.lbGameName.Text = game.GameName;
            }
        }

        [Category("Image"), Description("游戏图标")]
        public Image GameImage 
        {
            get { return this.panel_Icon.BackgroundImage; }
            set { this.panel_Icon.BackgroundImage = value; }
        }

        public delegate void IconListItemClick(object sender, EventArgs e);
        public IconListItemClick IconListItemMouseClick;

        public IconListItem()
        {
            InitializeComponent();
        }

        private void panel_Icon_MouseEnter(object sender, EventArgs e)
        {
            skinPanel1.BorderColor = Color.White;
        }

        private void panel_Icon_MouseLeave(object sender, EventArgs e)
        {
            skinPanel1.BorderColor = Color.Transparent;
        }

        private void panel_Icon_Click(object sender, EventArgs e)
        {
            if (IconListItemMouseClick != null)
            {
                IconListItemMouseClick(sender, e);
            }
        }
    }
}
