namespace NB.Forms
{
    partial class ChooseLineFrm
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
            this.components = new System.ComponentModel.Container();
            this.btnRefresh = new CCWin.SkinControl.SkinPanel();
            this.skinFlowLayoutPanel1 = new CCWin.SkinControl.SkinFlowLayoutPanel();
            this.lbGameName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbSelectedLine = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnStart = new CCWin.SkinControl.SkinButton();
            this.cb_Mode = new CCWin.SkinControl.SkinComboBox();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnRefresh.DownBack = global::NB.Properties.Resources.select_server_flush;
            this.btnRefresh.Location = new System.Drawing.Point(428, 20);
            this.btnRefresh.MouseBack = global::NB.Properties.Resources.select_server_flush_enter;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.NormlBack = global::NB.Properties.Resources.select_server_flush;
            this.btnRefresh.Size = new System.Drawing.Size(16, 13);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // skinFlowLayoutPanel1
            // 
            this.skinFlowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.skinFlowLayoutPanel1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinFlowLayoutPanel1.DownBack = null;
            this.skinFlowLayoutPanel1.Location = new System.Drawing.Point(5, 71);
            this.skinFlowLayoutPanel1.MouseBack = null;
            this.skinFlowLayoutPanel1.Name = "skinFlowLayoutPanel1";
            this.skinFlowLayoutPanel1.NormlBack = null;
            this.skinFlowLayoutPanel1.Size = new System.Drawing.Size(500, 288);
            this.skinFlowLayoutPanel1.TabIndex = 2;
            // 
            // lbGameName
            // 
            this.lbGameName.AutoSize = true;
            this.lbGameName.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbGameName.ForeColor = System.Drawing.Color.White;
            this.lbGameName.Location = new System.Drawing.Point(28, 369);
            this.lbGameName.Name = "lbGameName";
            this.lbGameName.Size = new System.Drawing.Size(97, 25);
            this.lbGameName.TabIndex = 3;
            this.lbGameName.Text = "unknown";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(28, 410);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "当前选择:";
            // 
            // lbSelectedLine
            // 
            this.lbSelectedLine.AutoSize = true;
            this.lbSelectedLine.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbSelectedLine.ForeColor = System.Drawing.Color.Coral;
            this.lbSelectedLine.Location = new System.Drawing.Point(102, 410);
            this.lbSelectedLine.Name = "lbSelectedLine";
            this.lbSelectedLine.Size = new System.Drawing.Size(73, 20);
            this.lbSelectedLine.TabIndex = 5;
            this.lbSelectedLine.Text = "unknown";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(56, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "节点名称";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(216, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "节点延迟";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(389, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "节点状态";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Transparent;
            this.btnStart.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnStart.DownBack = global::NB.Properties.Resources.reg_btn_down;
            this.btnStart.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.btnStart.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStart.Location = new System.Drawing.Point(357, 402);
            this.btnStart.MouseBack = global::NB.Properties.Resources.reg_btn_enter;
            this.btnStart.Name = "btnStart";
            this.btnStart.NormlBack = global::NB.Properties.Resources.reg_btn_normal;
            this.btnStart.Size = new System.Drawing.Size(120, 36);
            this.btnStart.TabIndex = 9;
            this.btnStart.Text = "确认选择";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // cb_Mode
            // 
            this.cb_Mode.ArrowColor = System.Drawing.Color.DimGray;
            this.cb_Mode.AutoCompleteCustomSource.AddRange(new string[] {
            "模式一",
            "模式二"});
            this.cb_Mode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(31)))));
            this.cb_Mode.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(31)))));
            this.cb_Mode.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cb_Mode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_Mode.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_Mode.DropBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(31)))));
            this.cb_Mode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Mode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_Mode.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_Mode.ForeColor = System.Drawing.Color.DimGray;
            this.cb_Mode.FormattingEnabled = true;
            this.cb_Mode.ItemBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(31)))));
            this.cb_Mode.ItemHeight = 20;
            this.cb_Mode.ItemHoverForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cb_Mode.Items.AddRange(new object[] {
            "模式一",
            "模式二"});
            this.cb_Mode.Location = new System.Drawing.Point(197, 407);
            this.cb_Mode.MaxDropDownItems = 2;
            this.cb_Mode.MouseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(31)))));
            this.cb_Mode.MouseGradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(31)))));
            this.cb_Mode.Name = "cb_Mode";
            this.cb_Mode.Size = new System.Drawing.Size(121, 26);
            this.cb_Mode.TabIndex = 10;
            this.cb_Mode.WaterColor = System.Drawing.Color.DimGray;
            this.cb_Mode.WaterText = "自动选择";
            // 
            // ChooseLineFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(31)))));
            this.BackgroundImage = null;
            this.ClientSize = new System.Drawing.Size(508, 457);
            this.Controls.Add(this.cb_Mode);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbSelectedLine);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbGameName);
            this.Controls.Add(this.skinFlowLayoutPanel1);
            this.Controls.Add(this.btnRefresh);
            this.Name = "ChooseLineFrm";
            this.Text = "节点选择";
            this.Load += new System.EventHandler(this.ChooseLineFrm_Load);
            this.Controls.SetChildIndex(this.btnRefresh, 0);
            this.Controls.SetChildIndex(this.skinFlowLayoutPanel1, 0);
            this.Controls.SetChildIndex(this.lbGameName, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.lbSelectedLine, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.btnStart, 0);
            this.Controls.SetChildIndex(this.cb_Mode, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinPanel btnRefresh;
        private CCWin.SkinControl.SkinFlowLayoutPanel skinFlowLayoutPanel1;
        private System.Windows.Forms.Label lbGameName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbSelectedLine;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private CCWin.SkinControl.SkinButton btnStart;
        private CCWin.SkinControl.SkinComboBox cb_Mode;
    }
}