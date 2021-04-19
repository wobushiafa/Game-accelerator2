namespace NB.Forms
{
    partial class MainFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.skinTabControl1 = new CCWin.SkinControl.SkinTabControl();
            this.page_AllGames = new CCWin.SkinControl.SkinTabPage();
            this.panel_AllGames = new CCWin.SkinControl.SkinFlowLayoutPanel();
            this.page_MyGames = new CCWin.SkinControl.SkinTabPage();
            this.panel_MyGames = new CCWin.SkinControl.SkinFlowLayoutPanel();
            this.page_Finish = new CCWin.SkinControl.SkinTabPage();
            this.panel_Complete = new CCWin.SkinControl.SkinPanel();
            this.lb_CompletePing = new System.Windows.Forms.Label();
            this.skinPanel3 = new CCWin.SkinControl.SkinPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.skinPanel2 = new CCWin.SkinControl.SkinPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_CompleteStopbkg = new CCWin.SkinControl.SkinPanel();
            this.btn_CompleteStop = new System.Windows.Forms.Label();
            this.skinPanel1 = new CCWin.SkinControl.SkinPanel();
            this.btn_CompleteStartGame = new CCWin.SkinControl.SkinPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_CompleteTimer = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_CompleteGameLine = new System.Windows.Forms.Label();
            this.lb_CompleteGameName = new System.Windows.Forms.Label();
            this.sysMore = new CCWin.SkinControl.SkinPanel();
            this.sysMin = new CCWin.SkinControl.SkinPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel_Nav = new CCWin.SkinControl.SkinFlowLayoutPanel();
            this.btnNavAllGames = new CCWin.SkinControl.SkinButton();
            this.btnNavMyGames = new CCWin.SkinControl.SkinButton();
            this.btnNavGit = new CCWin.SkinControl.SkinButton();
            this.btnDelete = new CCWin.SkinControl.SkinPanel();
            this.panel_TopMenu = new CCWin.SkinControl.SkinFlowLayoutPanel();
            this.skinTabControl1.SuspendLayout();
            this.page_AllGames.SuspendLayout();
            this.page_MyGames.SuspendLayout();
            this.page_Finish.SuspendLayout();
            this.panel_Complete.SuspendLayout();
            this.skinPanel3.SuspendLayout();
            this.skinPanel2.SuspendLayout();
            this.btn_CompleteStopbkg.SuspendLayout();
            this.panel_Nav.SuspendLayout();
            this.SuspendLayout();
            // 
            // skinTabControl1
            // 
            this.skinTabControl1.AnimatorType = CCWin.SkinControl.AnimationType.Leaf;
            this.skinTabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.skinTabControl1.ArrowBaseColor = System.Drawing.Color.Transparent;
            this.skinTabControl1.ArrowBorderColor = System.Drawing.Color.Transparent;
            this.skinTabControl1.ArrowColor = System.Drawing.Color.Transparent;
            this.skinTabControl1.CloseRect = new System.Drawing.Rectangle(2, 2, 12, 12);
            this.skinTabControl1.Controls.Add(this.page_AllGames);
            this.skinTabControl1.Controls.Add(this.page_MyGames);
            this.skinTabControl1.Controls.Add(this.page_Finish);
            this.skinTabControl1.HeadBack = null;
            this.skinTabControl1.ImgTxtOffset = new System.Drawing.Point(0, 0);
            this.skinTabControl1.Interval = 1;
            this.skinTabControl1.ItemSize = new System.Drawing.Size(1, 1);
            this.skinTabControl1.Location = new System.Drawing.Point(169, 102);
            this.skinTabControl1.Name = "skinTabControl1";
            this.skinTabControl1.PageArrowDown = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageArrowDown")));
            this.skinTabControl1.PageArrowHover = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageArrowHover")));
            this.skinTabControl1.PageBaseColor = System.Drawing.Color.Transparent;
            this.skinTabControl1.PageBorderColor = System.Drawing.Color.Transparent;
            this.skinTabControl1.PageCloseHover = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageCloseHover")));
            this.skinTabControl1.PageCloseNormal = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageCloseNormal")));
            this.skinTabControl1.PageDown = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageDown")));
            this.skinTabControl1.PageHover = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageHover")));
            this.skinTabControl1.PageImagePosition = CCWin.SkinControl.SkinTabControl.ePageImagePosition.Bottom;
            this.skinTabControl1.PageNorml = null;
            this.skinTabControl1.PageNormlTxtColor = System.Drawing.Color.White;
            this.skinTabControl1.SelectedIndex = 2;
            this.skinTabControl1.Size = new System.Drawing.Size(807, 472);
            this.skinTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.skinTabControl1.TabIndex = 3;
            this.skinTabControl1.TabStop = false;
            // 
            // page_AllGames
            // 
            this.page_AllGames.BackColor = System.Drawing.Color.Transparent;
            this.page_AllGames.Controls.Add(this.panel_AllGames);
            this.page_AllGames.Dock = System.Windows.Forms.DockStyle.Fill;
            this.page_AllGames.Location = new System.Drawing.Point(0, 1);
            this.page_AllGames.Name = "page_AllGames";
            this.page_AllGames.Size = new System.Drawing.Size(820, 471);
            this.page_AllGames.TabIndex = 0;
            this.page_AllGames.TabItemImage = null;
            this.page_AllGames.Text = "AllGames";
            // 
            // panel_AllGames
            // 
            this.panel_AllGames.AutoScroll = true;
            this.panel_AllGames.AutoScrollMinSize = new System.Drawing.Size(0, 1);
            this.panel_AllGames.BackColor = System.Drawing.Color.Transparent;
            this.panel_AllGames.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.panel_AllGames.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_AllGames.DownBack = null;
            this.panel_AllGames.Location = new System.Drawing.Point(0, 0);
            this.panel_AllGames.MouseBack = null;
            this.panel_AllGames.Name = "panel_AllGames";
            this.panel_AllGames.NormlBack = null;
            this.panel_AllGames.Size = new System.Drawing.Size(820, 471);
            this.panel_AllGames.TabIndex = 0;
            // 
            // page_MyGames
            // 
            this.page_MyGames.BackColor = System.Drawing.Color.Transparent;
            this.page_MyGames.Controls.Add(this.panel_MyGames);
            this.page_MyGames.Dock = System.Windows.Forms.DockStyle.Fill;
            this.page_MyGames.Location = new System.Drawing.Point(0, 1);
            this.page_MyGames.Name = "page_MyGames";
            this.page_MyGames.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.page_MyGames.Size = new System.Drawing.Size(820, 471);
            this.page_MyGames.TabIndex = 1;
            this.page_MyGames.TabItemImage = null;
            this.page_MyGames.Text = "MyGames";
            // 
            // panel_MyGames
            // 
            this.panel_MyGames.BackColor = System.Drawing.Color.Transparent;
            this.panel_MyGames.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.panel_MyGames.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_MyGames.DownBack = null;
            this.panel_MyGames.Location = new System.Drawing.Point(0, 0);
            this.panel_MyGames.MouseBack = null;
            this.panel_MyGames.Name = "panel_MyGames";
            this.panel_MyGames.NormlBack = null;
            this.panel_MyGames.Size = new System.Drawing.Size(810, 439);
            this.panel_MyGames.TabIndex = 0;
            this.panel_MyGames.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.panel_MyGames_ControlAdded);
            // 
            // page_Finish
            // 
            this.page_Finish.BackColor = System.Drawing.Color.Transparent;
            this.page_Finish.Controls.Add(this.panel_Complete);
            this.page_Finish.Dock = System.Windows.Forms.DockStyle.Fill;
            this.page_Finish.Location = new System.Drawing.Point(0, 1);
            this.page_Finish.Name = "page_Finish";
            this.page_Finish.Size = new System.Drawing.Size(807, 471);
            this.page_Finish.TabIndex = 2;
            this.page_Finish.TabItemImage = null;
            this.page_Finish.Text = "Finish";
            // 
            // panel_Complete
            // 
            this.panel_Complete.BackColor = System.Drawing.Color.Transparent;
            this.panel_Complete.BackgroundImage = global::NB.Properties.Resources.Complete_bg;
            this.panel_Complete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_Complete.BorderColor = System.Drawing.Color.Coral;
            this.panel_Complete.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Complete.Controls.Add(this.lb_CompletePing);
            this.panel_Complete.Controls.Add(this.skinPanel3);
            this.panel_Complete.Controls.Add(this.skinPanel2);
            this.panel_Complete.Controls.Add(this.btn_CompleteStopbkg);
            this.panel_Complete.Controls.Add(this.skinPanel1);
            this.panel_Complete.Controls.Add(this.btn_CompleteStartGame);
            this.panel_Complete.Controls.Add(this.label7);
            this.panel_Complete.Controls.Add(this.lb_CompleteTimer);
            this.panel_Complete.Controls.Add(this.label6);
            this.panel_Complete.Controls.Add(this.label5);
            this.panel_Complete.Controls.Add(this.label4);
            this.panel_Complete.Controls.Add(this.lb_CompleteGameLine);
            this.panel_Complete.Controls.Add(this.lb_CompleteGameName);
            this.panel_Complete.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.panel_Complete.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel_Complete.DownBack = null;
            this.panel_Complete.Location = new System.Drawing.Point(1, -1);
            this.panel_Complete.MouseBack = null;
            this.panel_Complete.Name = "panel_Complete";
            this.panel_Complete.NormlBack = null;
            this.panel_Complete.Size = new System.Drawing.Size(791, 419);
            this.panel_Complete.TabIndex = 15;
            // 
            // lb_CompletePing
            // 
            this.lb_CompletePing.AutoSize = true;
            this.lb_CompletePing.Font = new System.Drawing.Font("微软雅黑", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_CompletePing.ForeColor = System.Drawing.Color.Chartreuse;
            this.lb_CompletePing.Location = new System.Drawing.Point(518, 165);
            this.lb_CompletePing.Name = "lb_CompletePing";
            this.lb_CompletePing.Size = new System.Drawing.Size(144, 62);
            this.lb_CompletePing.TabIndex = 20;
            this.lb_CompletePing.Text = "0 MS";
            // 
            // skinPanel3
            // 
            this.skinPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.skinPanel3.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel3.BackgroundImage = global::NB.Properties.Resources.status_fenge;
            this.skinPanel3.Controls.Add(this.label9);
            this.skinPanel3.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.skinPanel3.DownBack = null;
            this.skinPanel3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinPanel3.Location = new System.Drawing.Point(482, 168);
            this.skinPanel3.MouseBack = null;
            this.skinPanel3.Name = "skinPanel3";
            this.skinPanel3.NormlBack = null;
            this.skinPanel3.Size = new System.Drawing.Size(2, 52);
            this.skinPanel3.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(31, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 20);
            this.label9.TabIndex = 4;
            this.label9.Text = "停止加速";
            // 
            // skinPanel2
            // 
            this.skinPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.skinPanel2.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel2.BackgroundImage = global::NB.Properties.Resources.status_fenge;
            this.skinPanel2.Controls.Add(this.label8);
            this.skinPanel2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.skinPanel2.DownBack = null;
            this.skinPanel2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinPanel2.Location = new System.Drawing.Point(276, 168);
            this.skinPanel2.MouseBack = null;
            this.skinPanel2.Name = "skinPanel2";
            this.skinPanel2.NormlBack = null;
            this.skinPanel2.Size = new System.Drawing.Size(2, 52);
            this.skinPanel2.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(31, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "停止加速";
            // 
            // btn_CompleteStopbkg
            // 
            this.btn_CompleteStopbkg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_CompleteStopbkg.BackColor = System.Drawing.Color.Transparent;
            this.btn_CompleteStopbkg.BackgroundImage = global::NB.Properties.Resources.status_stop;
            this.btn_CompleteStopbkg.Controls.Add(this.btn_CompleteStop);
            this.btn_CompleteStopbkg.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_CompleteStopbkg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CompleteStopbkg.DownBack = null;
            this.btn_CompleteStopbkg.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_CompleteStopbkg.Location = new System.Drawing.Point(231, 314);
            this.btn_CompleteStopbkg.MouseBack = null;
            this.btn_CompleteStopbkg.Name = "btn_CompleteStopbkg";
            this.btn_CompleteStopbkg.NormlBack = null;
            this.btn_CompleteStopbkg.Size = new System.Drawing.Size(126, 42);
            this.btn_CompleteStopbkg.TabIndex = 17;
            this.btn_CompleteStopbkg.Click += new System.EventHandler(this.btn_CompleteStopbkg_Click);
            // 
            // btn_CompleteStop
            // 
            this.btn_CompleteStop.AutoSize = true;
            this.btn_CompleteStop.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_CompleteStop.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_CompleteStop.Location = new System.Drawing.Point(32, 10);
            this.btn_CompleteStop.Name = "btn_CompleteStop";
            this.btn_CompleteStop.Size = new System.Drawing.Size(65, 20);
            this.btn_CompleteStop.TabIndex = 4;
            this.btn_CompleteStop.Text = "停止加速";
            this.btn_CompleteStop.Click += new System.EventHandler(this.btn_CompleteStop_Click);
            // 
            // skinPanel1
            // 
            this.skinPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.skinPanel1.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.skinPanel1.DownBack = global::NB.Properties.Resources.status_drop_bg;
            this.skinPanel1.Location = new System.Drawing.Point(166, 317);
            this.skinPanel1.MouseBack = global::NB.Properties.Resources.status_drop_bg;
            this.skinPanel1.Name = "skinPanel1";
            this.skinPanel1.NormlBack = global::NB.Properties.Resources.status_drop;
            this.skinPanel1.Size = new System.Drawing.Size(31, 36);
            this.skinPanel1.TabIndex = 16;
            // 
            // btn_CompleteStartGame
            // 
            this.btn_CompleteStartGame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_CompleteStartGame.BackColor = System.Drawing.Color.Transparent;
            this.btn_CompleteStartGame.BackgroundImage = global::NB.Properties.Resources.status_startgame;
            this.btn_CompleteStartGame.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_CompleteStartGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CompleteStartGame.DownBack = null;
            this.btn_CompleteStartGame.Location = new System.Drawing.Point(48, 317);
            this.btn_CompleteStartGame.MouseBack = null;
            this.btn_CompleteStartGame.Name = "btn_CompleteStartGame";
            this.btn_CompleteStartGame.NormlBack = null;
            this.btn_CompleteStartGame.Size = new System.Drawing.Size(120, 36);
            this.btn_CompleteStartGame.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(323, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 62);
            this.label7.TabIndex = 6;
            this.label7.Text = "0 %";
            // 
            // lb_CompleteTimer
            // 
            this.lb_CompleteTimer.AutoSize = true;
            this.lb_CompleteTimer.Font = new System.Drawing.Font("微软雅黑", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_CompleteTimer.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_CompleteTimer.Location = new System.Drawing.Point(46, 165);
            this.lb_CompleteTimer.Name = "lb_CompleteTimer";
            this.lb_CompleteTimer.Size = new System.Drawing.Size(219, 62);
            this.lb_CompleteTimer.TabIndex = 5;
            this.lb_CompleteTimer.Text = "00:00:00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Default;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(572, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 21);
            this.label6.TabIndex = 4;
            this.label6.Text = "延迟";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(347, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "丢包率";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(117, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "加速时长";
            // 
            // lb_CompleteGameLine
            // 
            this.lb_CompleteGameLine.AutoSize = true;
            this.lb_CompleteGameLine.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_CompleteGameLine.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_CompleteGameLine.Location = new System.Drawing.Point(55, 109);
            this.lb_CompleteGameLine.Name = "lb_CompleteGameLine";
            this.lb_CompleteGameLine.Size = new System.Drawing.Size(108, 28);
            this.lb_CompleteGameLine.TabIndex = 1;
            this.lb_CompleteGameLine.Text = "Unknown";
            // 
            // lb_CompleteGameName
            // 
            this.lb_CompleteGameName.AutoSize = true;
            this.lb_CompleteGameName.Font = new System.Drawing.Font("微软雅黑", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_CompleteGameName.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_CompleteGameName.Location = new System.Drawing.Point(45, 34);
            this.lb_CompleteGameName.Name = "lb_CompleteGameName";
            this.lb_CompleteGameName.Size = new System.Drawing.Size(289, 75);
            this.lb_CompleteGameName.TabIndex = 0;
            this.lb_CompleteGameName.Text = "Unknown";
            // 
            // sysMore
            // 
            this.sysMore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sysMore.BackColor = System.Drawing.Color.Transparent;
            this.sysMore.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.sysMore.DownBack = global::NB.Properties.Resources.more_x;
            this.sysMore.Location = new System.Drawing.Point(897, 14);
            this.sysMore.MouseBack = global::NB.Properties.Resources.more_x;
            this.sysMore.Name = "sysMore";
            this.sysMore.NormlBack = global::NB.Properties.Resources.more;
            this.sysMore.Size = new System.Drawing.Size(24, 24);
            this.sysMore.TabIndex = 4;
            // 
            // sysMin
            // 
            this.sysMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sysMin.BackColor = System.Drawing.Color.Transparent;
            this.sysMin.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.sysMin.DownBack = global::NB.Properties.Resources.small_x;
            this.sysMin.Location = new System.Drawing.Point(936, 15);
            this.sysMin.MouseBack = global::NB.Properties.Resources.small_x;
            this.sysMin.Name = "sysMin";
            this.sysMin.NormlBack = global::NB.Properties.Resources.small;
            this.sysMin.Size = new System.Drawing.Size(24, 24);
            this.sysMin.TabIndex = 8;
            this.sysMin.Click += new System.EventHandler(this.sysMin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(210, 584);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "[公告] 问题反馈QQ群";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Coral;
            this.label2.Location = new System.Drawing.Point(475, 584);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "[公告] 加速失败常见问题";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Coral;
            this.label3.Location = new System.Drawing.Point(764, 584);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "[公告] 官方主页";
            // 
            // panel_Nav
            // 
            this.panel_Nav.BackColor = System.Drawing.Color.Transparent;
            this.panel_Nav.Controls.Add(this.btnNavAllGames);
            this.panel_Nav.Controls.Add(this.btnNavMyGames);
            this.panel_Nav.Controls.Add(this.btnNavGit);
            this.panel_Nav.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.panel_Nav.DownBack = null;
            this.panel_Nav.Location = new System.Drawing.Point(8, 102);
            this.panel_Nav.MouseBack = null;
            this.panel_Nav.Name = "panel_Nav";
            this.panel_Nav.NormlBack = null;
            this.panel_Nav.Size = new System.Drawing.Size(155, 418);
            this.panel_Nav.TabIndex = 13;
            // 
            // btnNavAllGames
            // 
            this.btnNavAllGames.BackColor = System.Drawing.Color.Transparent;
            this.btnNavAllGames.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnNavAllGames.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavAllGames.DownBack = global::NB.Properties.Resources.store_down;
            this.btnNavAllGames.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.btnNavAllGames.FadeGlow = false;
            this.btnNavAllGames.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavAllGames.Location = new System.Drawing.Point(3, 3);
            this.btnNavAllGames.MouseBack = global::NB.Properties.Resources.store_hover;
            this.btnNavAllGames.Name = "btnNavAllGames";
            this.btnNavAllGames.NormlBack = global::NB.Properties.Resources.store_normal;
            this.btnNavAllGames.Size = new System.Drawing.Size(150, 132);
            this.btnNavAllGames.TabIndex = 14;
            this.btnNavAllGames.UseVisualStyleBackColor = false;
            this.btnNavAllGames.Click += new System.EventHandler(this.btnNavAllGames_Click);
            // 
            // btnNavMyGames
            // 
            this.btnNavMyGames.BackColor = System.Drawing.Color.Transparent;
            this.btnNavMyGames.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnNavMyGames.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavMyGames.DownBack = global::NB.Properties.Resources.game_down;
            this.btnNavMyGames.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.btnNavMyGames.Location = new System.Drawing.Point(3, 141);
            this.btnNavMyGames.MouseBack = global::NB.Properties.Resources.game_hover;
            this.btnNavMyGames.Name = "btnNavMyGames";
            this.btnNavMyGames.NormlBack = global::NB.Properties.Resources.game_normal;
            this.btnNavMyGames.Size = new System.Drawing.Size(150, 132);
            this.btnNavMyGames.TabIndex = 15;
            this.btnNavMyGames.UseVisualStyleBackColor = false;
            this.btnNavMyGames.Click += new System.EventHandler(this.btnNavMyGames_Click);
            // 
            // btnNavGit
            // 
            this.btnNavGit.BackColor = System.Drawing.Color.Transparent;
            this.btnNavGit.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnNavGit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavGit.DownBack = global::NB.Properties.Resources.gift_down;
            this.btnNavGit.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.btnNavGit.Location = new System.Drawing.Point(3, 279);
            this.btnNavGit.MouseBack = global::NB.Properties.Resources.gift_hover;
            this.btnNavGit.Name = "btnNavGit";
            this.btnNavGit.NormlBack = global::NB.Properties.Resources.gift_normal;
            this.btnNavGit.Size = new System.Drawing.Size(150, 132);
            this.btnNavGit.TabIndex = 16;
            this.btnNavGit.UseVisualStyleBackColor = false;
            this.btnNavGit.Click += new System.EventHandler(this.btnNavGit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BackgroundImage = global::NB.Properties.Resources.logo;
            this.btnDelete.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.DownBack = null;
            this.btnDelete.Location = new System.Drawing.Point(7, 3);
            this.btnDelete.MouseBack = null;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.NormlBack = null;
            this.btnDelete.Size = new System.Drawing.Size(207, 96);
            this.btnDelete.TabIndex = 14;
            // 
            // panel_TopMenu
            // 
            this.panel_TopMenu.BackColor = System.Drawing.Color.Transparent;
            this.panel_TopMenu.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.panel_TopMenu.DownBack = null;
            this.panel_TopMenu.Location = new System.Drawing.Point(792, 45);
            this.panel_TopMenu.MouseBack = null;
            this.panel_TopMenu.Name = "panel_TopMenu";
            this.panel_TopMenu.NormlBack = null;
            this.panel_TopMenu.Size = new System.Drawing.Size(129, 178);
            this.panel_TopMenu.TabIndex = 15;
            this.panel_TopMenu.Visible = false;
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(31)))));
            this.BackgroundImage = global::NB.Properties.Resources.bkg;
            this.BackShade = false;
            this.ClientSize = new System.Drawing.Size(1000, 630);
            this.Controls.Add(this.panel_TopMenu);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.panel_Nav);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sysMin);
            this.Controls.Add(this.sysMore);
            this.Controls.Add(this.skinTabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainFrm";
            this.Radius = 0;
            this.Special = false;
            this.Text = "无界网游加速器";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFrm_FormClosing);
            this.Load += new System.EventHandler(this.MainFrm_Load);
            this.Controls.SetChildIndex(this.skinTabControl1, 0);
            this.Controls.SetChildIndex(this.sysMore, 0);
            this.Controls.SetChildIndex(this.sysMin, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.panel_Nav, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.panel_TopMenu, 0);
            this.skinTabControl1.ResumeLayout(false);
            this.page_AllGames.ResumeLayout(false);
            this.page_MyGames.ResumeLayout(false);
            this.page_Finish.ResumeLayout(false);
            this.panel_Complete.ResumeLayout(false);
            this.panel_Complete.PerformLayout();
            this.skinPanel3.ResumeLayout(false);
            this.skinPanel3.PerformLayout();
            this.skinPanel2.ResumeLayout(false);
            this.skinPanel2.PerformLayout();
            this.btn_CompleteStopbkg.ResumeLayout(false);
            this.btn_CompleteStopbkg.PerformLayout();
            this.panel_Nav.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinTabControl skinTabControl1;
        private CCWin.SkinControl.SkinTabPage page_AllGames;
        private CCWin.SkinControl.SkinTabPage page_MyGames;
        private CCWin.SkinControl.SkinFlowLayoutPanel panel_AllGames;
        private CCWin.SkinControl.SkinPanel sysMore;
        private CCWin.SkinControl.SkinTabPage page_Finish;
        private CCWin.SkinControl.SkinFlowLayoutPanel panel_MyGames;
        private CCWin.SkinControl.SkinPanel sysMin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private CCWin.SkinControl.SkinFlowLayoutPanel panel_Nav;
        private CCWin.SkinControl.SkinButton btnNavAllGames;
        private CCWin.SkinControl.SkinButton btnNavMyGames;
        private CCWin.SkinControl.SkinButton btnNavGit;
        private CCWin.SkinControl.SkinPanel btnDelete;
        private CCWin.SkinControl.SkinFlowLayoutPanel panel_TopMenu;
        private CCWin.SkinControl.SkinPanel panel_Complete;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lb_CompleteTimer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_CompleteGameLine;
        private System.Windows.Forms.Label lb_CompleteGameName;
        private CCWin.SkinControl.SkinPanel btn_CompleteStopbkg;
        private CCWin.SkinControl.SkinPanel skinPanel1;
        private CCWin.SkinControl.SkinPanel btn_CompleteStartGame;
        private System.Windows.Forms.Label btn_CompleteStop;
        private System.Windows.Forms.Label lb_CompletePing;
        private CCWin.SkinControl.SkinPanel skinPanel3;
        private System.Windows.Forms.Label label9;
        private CCWin.SkinControl.SkinPanel skinPanel2;
        private System.Windows.Forms.Label label8;
    }
}