namespace GameRetailerManagement.Source.Forms.Main
{
    partial class Form_GameRetailer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_GameRetailer));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.systemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.totalEarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Logout = new System.Windows.Forms.ToolStripMenuItem();
            this.gamesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_NewGames = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_OpenGameList = new System.Windows.Forms.ToolStripMenuItem();
            this.billsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_NewBill = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_OpenBillList = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel_List = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_Tools = new System.Windows.Forms.Panel();
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.button_Refresh = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_Main = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_Datetime = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel_Tools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.systemToolStripMenuItem,
            this.gamesToolStripMenuItem,
            this.billsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1128, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // systemToolStripMenuItem
            // 
            this.systemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportToolStripMenuItem,
            this.toolStripMenuItem1});
            this.systemToolStripMenuItem.Name = "systemToolStripMenuItem";
            this.systemToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.systemToolStripMenuItem.Text = "System";
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.totalEarToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // totalEarToolStripMenuItem
            // 
            this.totalEarToolStripMenuItem.Name = "totalEarToolStripMenuItem";
            this.totalEarToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.totalEarToolStripMenuItem.Text = "Total Earning";
            this.totalEarToolStripMenuItem.Click += new System.EventHandler(this.totalEarToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_Logout});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(119, 22);
            this.toolStripMenuItem1.Text = "Account";
            // 
            // toolStripMenuItem_Logout
            // 
            this.toolStripMenuItem_Logout.Name = "toolStripMenuItem_Logout";
            this.toolStripMenuItem_Logout.Size = new System.Drawing.Size(112, 22);
            this.toolStripMenuItem_Logout.Text = "Logout";
            this.toolStripMenuItem_Logout.Click += new System.EventHandler(this.toolStripMenuItem_Logout_Click);
            // 
            // gamesToolStripMenuItem
            // 
            this.gamesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_NewGames,
            this.toolStripMenuItem_OpenGameList});
            this.gamesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gamesToolStripMenuItem.Name = "gamesToolStripMenuItem";
            this.gamesToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.gamesToolStripMenuItem.Text = "Games";
            // 
            // toolStripMenuItem_NewGames
            // 
            this.toolStripMenuItem_NewGames.Name = "toolStripMenuItem_NewGames";
            this.toolStripMenuItem_NewGames.Size = new System.Drawing.Size(103, 22);
            this.toolStripMenuItem_NewGames.Text = "New";
            this.toolStripMenuItem_NewGames.Click += new System.EventHandler(this.toolStripMenuItem_NewGame_Click);
            // 
            // toolStripMenuItem_OpenGameList
            // 
            this.toolStripMenuItem_OpenGameList.Name = "toolStripMenuItem_OpenGameList";
            this.toolStripMenuItem_OpenGameList.Size = new System.Drawing.Size(103, 22);
            this.toolStripMenuItem_OpenGameList.Text = "Open";
            this.toolStripMenuItem_OpenGameList.Click += new System.EventHandler(this.toolStripMenuItem_OpenGameList_Click);
            // 
            // billsToolStripMenuItem
            // 
            this.billsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_NewBill,
            this.toolStripMenuItem_OpenBillList});
            this.billsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billsToolStripMenuItem.Name = "billsToolStripMenuItem";
            this.billsToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.billsToolStripMenuItem.Text = "Bills";
            // 
            // toolStripMenuItem_NewBill
            // 
            this.toolStripMenuItem_NewBill.Name = "toolStripMenuItem_NewBill";
            this.toolStripMenuItem_NewBill.Size = new System.Drawing.Size(103, 22);
            this.toolStripMenuItem_NewBill.Text = "New";
            this.toolStripMenuItem_NewBill.Click += new System.EventHandler(this.toolStripMenuItem_NewBill_Click);
            // 
            // toolStripMenuItem_OpenBillList
            // 
            this.toolStripMenuItem_OpenBillList.Name = "toolStripMenuItem_OpenBillList";
            this.toolStripMenuItem_OpenBillList.Size = new System.Drawing.Size(103, 22);
            this.toolStripMenuItem_OpenBillList.Text = "Open";
            this.toolStripMenuItem_OpenBillList.Click += new System.EventHandler(this.toolStripMenuItem_OpenBillList_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.flowLayoutPanel_List);
            this.splitContainer1.Panel1.Controls.Add(this.panel_Tools);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel_Main);
            this.splitContainer1.Size = new System.Drawing.Size(1128, 587);
            this.splitContainer1.SplitterDistance = 281;
            this.splitContainer1.TabIndex = 3;
            // 
            // flowLayoutPanel_List
            // 
            this.flowLayoutPanel_List.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel_List.AutoScroll = true;
            this.flowLayoutPanel_List.BackColor = System.Drawing.Color.Gainsboro;
            this.flowLayoutPanel_List.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel_List.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel_List.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.flowLayoutPanel_List.Location = new System.Drawing.Point(6, 32);
            this.flowLayoutPanel_List.Name = "flowLayoutPanel_List";
            this.flowLayoutPanel_List.Size = new System.Drawing.Size(272, 530);
            this.flowLayoutPanel_List.TabIndex = 0;
            // 
            // panel_Tools
            // 
            this.panel_Tools.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Tools.BackColor = System.Drawing.Color.DarkGray;
            this.panel_Tools.Controls.Add(this.textBox_Search);
            this.panel_Tools.Controls.Add(this.button_Refresh);
            this.panel_Tools.Controls.Add(this.pictureBox1);
            this.panel_Tools.Location = new System.Drawing.Point(3, 3);
            this.panel_Tools.Name = "panel_Tools";
            this.panel_Tools.Size = new System.Drawing.Size(275, 581);
            this.panel_Tools.TabIndex = 0;
            // 
            // textBox_Search
            // 
            this.textBox_Search.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Search.Location = new System.Drawing.Point(29, 2);
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Size = new System.Drawing.Size(176, 23);
            this.textBox_Search.TabIndex = 2;
            this.textBox_Search.TextChanged += new System.EventHandler(this.textBox_Search_TextChanged);
            // 
            // button_Refresh
            // 
            this.button_Refresh.Location = new System.Drawing.Point(211, 2);
            this.button_Refresh.Name = "button_Refresh";
            this.button_Refresh.Size = new System.Drawing.Size(61, 23);
            this.button_Refresh.TabIndex = 0;
            this.button_Refresh.Text = "Refresh";
            this.button_Refresh.UseVisualStyleBackColor = true;
            this.button_Refresh.Click += new System.EventHandler(this.button_Refresh_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel_Main
            // 
            this.panel_Main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Main.BackColor = System.Drawing.Color.DarkGray;
            this.panel_Main.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_Main.Location = new System.Drawing.Point(3, 6);
            this.panel_Main.Name = "panel_Main";
            this.panel_Main.Size = new System.Drawing.Size(828, 556);
            this.panel_Main.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_Datetime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 589);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1128, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_Datetime
            // 
            this.toolStripStatusLabel_Datetime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.toolStripStatusLabel_Datetime.Name = "toolStripStatusLabel_Datetime";
            this.toolStripStatusLabel_Datetime.Size = new System.Drawing.Size(136, 17);
            this.toolStripStatusLabel_Datetime.Text = "dd/MM/yyyy hh/mm/ss";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form_GameRetailer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1128, 611);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_GameRetailer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Games Retailer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_GameRetailer_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel_Tools.ResumeLayout(false);
            this.panel_Tools.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gamesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem billsToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel_Tools;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_Datetime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_NewGames;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_OpenGameList;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Panel panel_Main;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_List;
        private System.Windows.Forms.Button button_Refresh;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_NewBill;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_OpenBillList;
        private System.Windows.Forms.TextBox textBox_Search;
        private System.Windows.Forms.ToolStripMenuItem systemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem totalEarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Logout;
    }
}