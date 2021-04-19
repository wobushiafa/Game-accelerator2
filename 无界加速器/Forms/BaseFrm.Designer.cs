namespace NB.Forms
{
    partial class BaseFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sysClose = new CCWin.SkinControl.SkinPanel();
            this.SuspendLayout();
            // 
            // sysClose
            // 
            this.sysClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sysClose.BackColor = System.Drawing.Color.Transparent;
            this.sysClose.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.sysClose.DownBack = global::NB.Properties.Resources.close_x;
            this.sysClose.Location = new System.Drawing.Point(350, 25);
            this.sysClose.MouseBack = global::NB.Properties.Resources.close_x;
            this.sysClose.Name = "sysClose";
            this.sysClose.NormlBack = global::NB.Properties.Resources.close;
            this.sysClose.Size = new System.Drawing.Size(24, 24);
            this.sysClose.TabIndex = 0;
            this.sysClose.MouseUp += new System.Windows.Forms.MouseEventHandler(this.sysClose_MouseUp);
            // 
            // BaseFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CanResize = false;
            this.ClientSize = new System.Drawing.Size(392, 184);
            this.ControlBox = false;
            this.Controls.Add(this.sysClose);
            this.EffectBack = System.Drawing.Color.Transparent;
            this.EffectCaption = CCWin.TitleType.None;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BaseFrm";
            this.Radius = 1;
            this.RoundStyle = CCWin.SkinClass.RoundStyle.None;
            this.ShadowWidth = 7;
            this.ShowBorder = false;
            this.ShowDrawIcon = false;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BaseFrm";
            this.TitleColor = System.Drawing.Color.Transparent;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BaseFrm_FormClosing);
            this.Load += new System.EventHandler(this.BaseFrm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.BaseFrm_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinPanel sysClose;
    }
}