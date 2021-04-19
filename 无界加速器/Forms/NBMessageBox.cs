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
    public partial class NBMessageBox : BaseFrm
    {
        private static NBMessageBox instance;

        public static NBMessageBox Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new NBMessageBox();
                }
                return instance;
            }
            set { instance = value; }
        }

        public NBMessageBox()
        {
            InitializeComponent();
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool MessageBeep(uint uType);

        public DialogResult Show(string message,string title)
        {
            MessageBeep(1);
            this.TopMost = true;
            lbText.Text = message;
            this.Text = title;
            this.lbTitle.Text = title;
            this.ShowDialog();
            return DialogResult.OK;
        }

        private void NBMessageBox_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
