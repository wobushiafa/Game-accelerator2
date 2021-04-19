
namespace NB.MyControls
{
    partial class MyGamesListItem
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
            this.progressbar = new CCWin.SkinControl.SkinPanel();
            this.btnChooseLine = new CCWin.SkinControl.SkinLabel();
            this.btnDelete = new CCWin.SkinControl.SkinPanel();
            this.lbGameName = new System.Windows.Forms.Label();
            this.btnStart = new CCWin.SkinControl.SkinPanel();
            this.panel_Back.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Back
            // 
            this.panel_Back.BackColor = System.Drawing.Color.Transparent;
            this.panel_Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_Back.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Back.Controls.Add(this.progressbar);
            this.panel_Back.Controls.Add(this.btnChooseLine);
            this.panel_Back.Controls.Add(this.btnDelete);
            this.panel_Back.Controls.Add(this.lbGameName);
            this.panel_Back.Controls.Add(this.btnStart);
            this.panel_Back.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.panel_Back.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Back.DownBack = null;
            this.panel_Back.Location = new System.Drawing.Point(0, 0);
            this.panel_Back.MouseBack = null;
            this.panel_Back.Name = "panel_Back";
            this.panel_Back.NormlBack = null;
            this.panel_Back.Size = new System.Drawing.Size(240, 420);
            this.panel_Back.TabIndex = 7;
            this.panel_Back.MouseEnter += new System.EventHandler(this.panel_Back_MouseEnter);
            this.panel_Back.MouseLeave += new System.EventHandler(this.panel_Back_MouseLeave);
            // 
            // progressbar
            // 
            this.progressbar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.progressbar.BackColor = System.Drawing.Color.Coral;
            this.progressbar.BorderColor = System.Drawing.Color.Tomato;
            this.progressbar.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.progressbar.DownBack = null;
            this.progressbar.Location = new System.Drawing.Point(1, 413);
            this.progressbar.MouseBack = null;
            this.progressbar.Name = "progressbar";
            this.progressbar.NormlBack = null;
            this.progressbar.Size = new System.Drawing.Size(20, 4);
            this.progressbar.TabIndex = 12;
            this.progressbar.Visible = false;
            // 
            // btnChooseLine
            // 
            this.btnChooseLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnChooseLine.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.btnChooseLine.AutoSize = true;
            this.btnChooseLine.BackColor = System.Drawing.Color.Transparent;
            this.btnChooseLine.BorderColor = System.Drawing.Color.White;
            this.btnChooseLine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChooseLine.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnChooseLine.ForeColor = System.Drawing.Color.Coral;
            this.btnChooseLine.Location = new System.Drawing.Point(6, 378);
            this.btnChooseLine.Name = "btnChooseLine";
            this.btnChooseLine.Size = new System.Drawing.Size(68, 17);
            this.btnChooseLine.TabIndex = 11;
            this.btnChooseLine.Text = "请选择节点";
            this.btnChooseLine.Click += new System.EventHandler(this.btnChooseLine_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.DownBack = global::NB.Properties.Resources.del_down;
            this.btnDelete.Location = new System.Drawing.Point(200, 13);
            this.btnDelete.MouseBack = global::NB.Properties.Resources.del_enter;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.NormlBack = global::NB.Properties.Resources.del;
            this.btnDelete.Size = new System.Drawing.Size(25, 27);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lbGameName
            // 
            this.lbGameName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbGameName.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbGameName.ForeColor = System.Drawing.Color.Coral;
            this.lbGameName.Location = new System.Drawing.Point(4, 345);
            this.lbGameName.Name = "lbGameName";
            this.lbGameName.Size = new System.Drawing.Size(154, 23);
            this.lbGameName.TabIndex = 9;
            this.lbGameName.Text = "Unknown";
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.BackColor = System.Drawing.Color.Transparent;
            this.btnStart.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnStart.DownBack = global::NB.Properties.Resources.start_x;
            this.btnStart.Location = new System.Drawing.Point(173, 338);
            this.btnStart.MouseBack = global::NB.Properties.Resources.start_success;
            this.btnStart.Name = "btnStart";
            this.btnStart.NormlBack = global::NB.Properties.Resources.start;
            this.btnStart.Size = new System.Drawing.Size(59, 66);
            this.btnStart.TabIndex = 8;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // MyGamesListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel_Back);
            this.Name = "MyGamesListItem";
            this.Size = new System.Drawing.Size(240, 420);
            this.panel_Back.ResumeLayout(false);
            this.panel_Back.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinPanel panel_Back;
        private System.Windows.Forms.Label lbGameName;
        private CCWin.SkinControl.SkinPanel btnStart;
        private CCWin.SkinControl.SkinPanel btnDelete;
        private CCWin.SkinControl.SkinLabel btnChooseLine;
        private CCWin.SkinControl.SkinPanel progressbar;
    }
}
