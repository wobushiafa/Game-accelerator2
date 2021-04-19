namespace NB.MyControls
{
    partial class LineListItem
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_Back = new CCWin.SkinControl.SkinPanel();
            this.panel_Ping = new CCWin.SkinControl.SkinPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.lbState = new System.Windows.Forms.Label();
            this.lbPing = new System.Windows.Forms.Label();
            this.lbRemark = new System.Windows.Forms.Label();
            this.panel_Back.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Back
            // 
            this.panel_Back.BackColor = System.Drawing.Color.Transparent;
            this.panel_Back.Controls.Add(this.panel_Ping);
            this.panel_Back.Controls.Add(this.label2);
            this.panel_Back.Controls.Add(this.lbState);
            this.panel_Back.Controls.Add(this.lbPing);
            this.panel_Back.Controls.Add(this.lbRemark);
            this.panel_Back.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.panel_Back.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Back.DownBack = null;
            this.panel_Back.Location = new System.Drawing.Point(0, 0);
            this.panel_Back.MouseBack = null;
            this.panel_Back.Name = "panel_Back";
            this.panel_Back.NormlBack = null;
            this.panel_Back.Size = new System.Drawing.Size(490, 30);
            this.panel_Back.TabIndex = 0;
            this.panel_Back.DoubleClick += new System.EventHandler(this.panel_Back_DoubleClick);
            this.panel_Back.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel_Back_MouseClick);
            this.panel_Back.MouseEnter += new System.EventHandler(this.panel_Back_MouseEnter);
            this.panel_Back.MouseLeave += new System.EventHandler(this.panel_Back_MouseLeave);
            // 
            // panel_Ping
            // 
            this.panel_Ping.BackColor = System.Drawing.Color.Transparent;
            this.panel_Ping.BackgroundImage = global::NB.Properties.Resources.select_server_network_none;
            this.panel_Ping.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.panel_Ping.DownBack = null;
            this.panel_Ping.Location = new System.Drawing.Point(201, 9);
            this.panel_Ping.MouseBack = null;
            this.panel_Ping.Name = "panel_Ping";
            this.panel_Ping.NormlBack = null;
            this.panel_Ping.Size = new System.Drawing.Size(11, 13);
            this.panel_Ping.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(251, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "ms";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbState
            // 
            this.lbState.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbState.AutoSize = true;
            this.lbState.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbState.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbState.Location = new System.Drawing.Point(398, 5);
            this.lbState.Name = "lbState";
            this.lbState.Size = new System.Drawing.Size(37, 20);
            this.lbState.TabIndex = 3;
            this.lbState.Text = "空闲";
            // 
            // lbPing
            // 
            this.lbPing.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbPing.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbPing.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbPing.Location = new System.Drawing.Point(215, 5);
            this.lbPing.Name = "lbPing";
            this.lbPing.Size = new System.Drawing.Size(39, 20);
            this.lbPing.TabIndex = 2;
            this.lbPing.Text = "0";
            this.lbPing.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbRemark
            // 
            this.lbRemark.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbRemark.AutoSize = true;
            this.lbRemark.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbRemark.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbRemark.Location = new System.Drawing.Point(45, 5);
            this.lbRemark.Name = "lbRemark";
            this.lbRemark.Size = new System.Drawing.Size(73, 20);
            this.lbRemark.TabIndex = 1;
            this.lbRemark.Text = "unknown";
            // 
            // LineListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel_Back);
            this.Name = "LineListItem";
            this.Size = new System.Drawing.Size(490, 30);
            this.panel_Back.ResumeLayout(false);
            this.panel_Back.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinPanel panel_Back;
        private CCWin.SkinControl.SkinPanel panel_Ping;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbState;
        private System.Windows.Forms.Label lbPing;
        private System.Windows.Forms.Label lbRemark;
    }
}
