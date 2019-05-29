namespace Zoro_Client.UI
{
    partial class MainForm
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_height = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_count_node = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.钱包WToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.创建钱包数据库NToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开钱包数据库OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.修改密码CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.退出XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.交易TToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.转账TToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.交易TToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.签名SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看帮助VToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.官网WToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.开发人员工具TToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.关于AntSharesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.accountFrm1 = new Zoro_Client.UI.AccountFrm();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lbl_height,
            this.toolStripStatusLabel4,
            this.lbl_count_node,
            this.toolStripProgressBar1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.statusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.statusStrip1.Location = new System.Drawing.Point(0, 417);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(839, 26);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(49, 21);
            this.toolStripStatusLabel1.Text = "Height:";
            // 
            // lbl_height
            // 
            this.lbl_height.Name = "lbl_height";
            this.lbl_height.Size = new System.Drawing.Size(39, 21);
            this.lbl_height.Text = "0/0/0";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(73, 21);
            this.toolStripStatusLabel4.Text = "Connected:";
            // 
            // lbl_count_node
            // 
            this.lbl_count_node.Name = "lbl_count_node";
            this.lbl_count_node.Size = new System.Drawing.Size(15, 21);
            this.lbl_count_node.Text = "0";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripProgressBar1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripProgressBar1.Maximum = 15;
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(133, 20);
            this.toolStripProgressBar1.Step = 1;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(140, 21);
            this.toolStripStatusLabel2.Text = "Waiting for next block:";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.IsLink = true;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(145, 21);
            this.toolStripStatusLabel3.Text = "Download New Version";
            this.toolStripStatusLabel3.Visible = false;
            // 
            // columnHeader7
            // 
            this.columnHeader7.DisplayIndex = 0;
            this.columnHeader7.Text = "Time";
            this.columnHeader7.Width = 132;
            // 
            // columnHeader8
            // 
            this.columnHeader8.DisplayIndex = 1;
            this.columnHeader8.Text = "Transaction ID";
            this.columnHeader8.Width = 482;
            // 
            // columnHeader9
            // 
            this.columnHeader9.DisplayIndex = 2;
            this.columnHeader9.Text = "confirm";
            this.columnHeader9.Width = 78;
            // 
            // columnHeader10
            // 
            this.columnHeader10.DisplayIndex = 3;
            this.columnHeader10.Text = "Transaction Type";
            this.columnHeader10.Width = 163;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.钱包WToolStripMenuItem,
            this.交易TToolStripMenuItem,
            this.帮助HToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(839, 32);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 钱包WToolStripMenuItem
            // 
            this.钱包WToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.钱包WToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.创建钱包数据库NToolStripMenuItem,
            this.打开钱包数据库OToolStripMenuItem,
            this.toolStripSeparator1,
            this.修改密码CToolStripMenuItem,
            this.toolStripSeparator2,
            this.退出XToolStripMenuItem});
            this.钱包WToolStripMenuItem.Name = "钱包WToolStripMenuItem";
            this.钱包WToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.钱包WToolStripMenuItem.Text = "&Wallet";
            // 
            // 创建钱包数据库NToolStripMenuItem
            // 
            this.创建钱包数据库NToolStripMenuItem.Name = "创建钱包数据库NToolStripMenuItem";
            this.创建钱包数据库NToolStripMenuItem.Size = new System.Drawing.Size(238, 24);
            this.创建钱包数据库NToolStripMenuItem.Text = "&New Wallet Database...";
            this.创建钱包数据库NToolStripMenuItem.Click += new System.EventHandler(this.创建钱包数据库NToolStripMenuItem_Click);
            // 
            // 打开钱包数据库OToolStripMenuItem
            // 
            this.打开钱包数据库OToolStripMenuItem.Name = "打开钱包数据库OToolStripMenuItem";
            this.打开钱包数据库OToolStripMenuItem.Size = new System.Drawing.Size(238, 24);
            this.打开钱包数据库OToolStripMenuItem.Text = "&Open Wallet Database...";
            this.打开钱包数据库OToolStripMenuItem.Click += new System.EventHandler(this.打开钱包数据库OToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(235, 6);
            // 
            // 修改密码CToolStripMenuItem
            // 
            this.修改密码CToolStripMenuItem.Enabled = false;
            this.修改密码CToolStripMenuItem.Name = "修改密码CToolStripMenuItem";
            this.修改密码CToolStripMenuItem.Size = new System.Drawing.Size(238, 24);
            this.修改密码CToolStripMenuItem.Text = "&Change Password...";
            this.修改密码CToolStripMenuItem.Click += new System.EventHandler(this.修改密码CToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(235, 6);
            // 
            // 退出XToolStripMenuItem
            // 
            this.退出XToolStripMenuItem.Name = "退出XToolStripMenuItem";
            this.退出XToolStripMenuItem.Size = new System.Drawing.Size(238, 24);
            this.退出XToolStripMenuItem.Text = "E&xit";
            this.退出XToolStripMenuItem.Click += new System.EventHandler(this.退出XToolStripMenuItem_Click);
            // 
            // 交易TToolStripMenuItem
            // 
            this.交易TToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.转账TToolStripMenuItem,
            this.交易TToolStripMenuItem1,
            this.toolStripSeparator5,
            this.签名SToolStripMenuItem});
            this.交易TToolStripMenuItem.Enabled = false;
            this.交易TToolStripMenuItem.Name = "交易TToolStripMenuItem";
            this.交易TToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.交易TToolStripMenuItem.Text = "&Transaction";
            // 
            // 转账TToolStripMenuItem
            // 
            this.转账TToolStripMenuItem.Name = "转账TToolStripMenuItem";
            this.转账TToolStripMenuItem.Size = new System.Drawing.Size(190, 24);
            this.转账TToolStripMenuItem.Text = "&Transfer...";
            // 
            // 交易TToolStripMenuItem1
            // 
            this.交易TToolStripMenuItem1.Name = "交易TToolStripMenuItem1";
            this.交易TToolStripMenuItem1.Size = new System.Drawing.Size(190, 24);
            this.交易TToolStripMenuItem1.Text = "Transactions(&X)...";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(187, 6);
            // 
            // 签名SToolStripMenuItem
            // 
            this.签名SToolStripMenuItem.Name = "签名SToolStripMenuItem";
            this.签名SToolStripMenuItem.Size = new System.Drawing.Size(190, 24);
            this.签名SToolStripMenuItem.Text = "&Signature...";
            // 
            // 帮助HToolStripMenuItem
            // 
            this.帮助HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查看帮助VToolStripMenuItem,
            this.官网WToolStripMenuItem,
            this.toolStripSeparator3,
            this.开发人员工具TToolStripMenuItem,
            this.toolStripSeparator4,
            this.关于AntSharesToolStripMenuItem});
            this.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem";
            this.帮助HToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.帮助HToolStripMenuItem.Text = "&Help";
            // 
            // 查看帮助VToolStripMenuItem
            // 
            this.查看帮助VToolStripMenuItem.Name = "查看帮助VToolStripMenuItem";
            this.查看帮助VToolStripMenuItem.Size = new System.Drawing.Size(213, 24);
            this.查看帮助VToolStripMenuItem.Text = "&Check for Help";
            // 
            // 官网WToolStripMenuItem
            // 
            this.官网WToolStripMenuItem.Name = "官网WToolStripMenuItem";
            this.官网WToolStripMenuItem.Size = new System.Drawing.Size(213, 24);
            this.官网WToolStripMenuItem.Text = "Official &Web";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(210, 6);
            // 
            // 开发人员工具TToolStripMenuItem
            // 
            this.开发人员工具TToolStripMenuItem.Name = "开发人员工具TToolStripMenuItem";
            this.开发人员工具TToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F12;
            this.开发人员工具TToolStripMenuItem.Size = new System.Drawing.Size(213, 24);
            this.开发人员工具TToolStripMenuItem.Text = "Developer &Tool";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(210, 6);
            // 
            // 关于AntSharesToolStripMenuItem
            // 
            this.关于AntSharesToolStripMenuItem.Name = "关于AntSharesToolStripMenuItem";
            this.关于AntSharesToolStripMenuItem.Size = new System.Drawing.Size(213, 24);
            this.关于AntSharesToolStripMenuItem.Text = "&About NEO";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabControl1.Location = new System.Drawing.Point(0, 32);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(839, 385);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.accountFrm1);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(831, 353);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Account";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(831, 353);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Asset";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(831, 353);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Contract";
            // 
            // accountFrm1
            // 
            this.accountFrm1.Dock = System.Windows.Forms.DockStyle.Top;
            this.accountFrm1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.accountFrm1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.accountFrm1.Location = new System.Drawing.Point(4, 4);
            this.accountFrm1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.accountFrm1.Name = "accountFrm1";
            this.accountFrm1.Size = new System.Drawing.Size(823, 39);
            this.accountFrm1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 443);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zoro-Client";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lbl_height;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel lbl_count_node;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 钱包WToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 创建钱包数据库NToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开钱包数据库OToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 修改密码CToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem 退出XToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 交易TToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 转账TToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 交易TToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem 签名SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看帮助VToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 官网WToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem 开发人员工具TToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem 关于AntSharesToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private AccountFrm account5;
        private AccountFrm account4;
        private AccountFrm account3;
        private AccountFrm account2;
        private AccountFrm account1;
        private AccountFrm accountFrm1;
    }
}

