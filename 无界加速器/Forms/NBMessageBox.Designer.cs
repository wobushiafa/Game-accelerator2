
namespace NB.Forms
{
    partial class NBMessageBox
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
            this.lbText = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.btnStart = new CCWin.SkinControl.SkinButton();
            this.SuspendLayout();
            // 
            // lbText
            // 
            this.lbText.BackColor = System.Drawing.Color.Transparent;
            this.lbText.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbText.ForeColor = System.Drawing.Color.Coral;
            this.lbText.Location = new System.Drawing.Point(24, 33);
            this.lbText.Name = "lbText";
            this.lbText.Size = new System.Drawing.Size(382, 66);
            this.lbText.TabIndex = 2;
            this.lbText.Text = "None";
            this.lbText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbTitle.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbTitle.ForeColor = System.Drawing.Color.Coral;
            this.lbTitle.Location = new System.Drawing.Point(14, 11);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(44, 20);
            this.lbTitle.TabIndex = 3;
            this.lbTitle.Text = "none";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Transparent;
            this.btnStart.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnStart.DownBack = global::NB.Properties.Resources.reg_btn_down;
            this.btnStart.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.btnStart.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStart.Location = new System.Drawing.Point(153, 102);
            this.btnStart.MouseBack = global::NB.Properties.Resources.reg_btn_enter;
            this.btnStart.Name = "btnStart";
            this.btnStart.NormlBack = global::NB.Properties.Resources.reg_btn_normal;
            this.btnStart.Size = new System.Drawing.Size(120, 36);
            this.btnStart.TabIndex = 10;
            this.btnStart.Text = "确定";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // NBMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(31)))));
            this.BackgroundImage = null;
            this.ClientSize = new System.Drawing.Size(434, 161);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.lbText);
            this.Name = "NBMessageBox";
            this.Text = "提示:";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NBMessageBox_FormClosing);
            this.Controls.SetChildIndex(this.lbText, 0);
            this.Controls.SetChildIndex(this.lbTitle, 0);
            this.Controls.SetChildIndex(this.btnStart, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbText;
        private System.Windows.Forms.Label lbTitle;
        private CCWin.SkinControl.SkinButton btnStart;
    }
}