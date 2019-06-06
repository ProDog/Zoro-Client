namespace Zoro_Client.UI
{
    partial class AccountFrm
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
            this.components = new System.ComponentModel.Container();
            this.lblAddress = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblBcp = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblBct = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.查看私钥VToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.复制到剪贴板CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblAddress.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblAddress.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblAddress.Location = new System.Drawing.Point(3, 8);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(330, 20);
            this.lblAddress.TabIndex = 21;
            this.lblAddress.Text = "AcQLYjGbQU2bEQ8RKFXUcf8XvromfUQodq";
            this.lblAddress.TextChanged += new System.EventHandler(this.LblAddress_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(423, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "BCP:";
            // 
            // lblBcp
            // 
            this.lblBcp.AutoSize = true;
            this.lblBcp.ContextMenuStrip = this.contextMenuStrip1;
            this.lblBcp.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblBcp.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblBcp.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblBcp.Location = new System.Drawing.Point(470, 8);
            this.lblBcp.Name = "lblBcp";
            this.lblBcp.Size = new System.Drawing.Size(139, 20);
            this.lblBcp.TabIndex = 23;
            this.lblBcp.Text = "00000000.000000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(615, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "BCT:";
            // 
            // lblBct
            // 
            this.lblBct.AutoSize = true;
            this.lblBct.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblBct.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblBct.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblBct.Location = new System.Drawing.Point(662, 8);
            this.lblBct.Name = "lblBct";
            this.lblBct.Size = new System.Drawing.Size(139, 20);
            this.lblBct.TabIndex = 25;
            this.lblBct.Text = "00000000.000000";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.contextMenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查看私钥VToolStripMenuItem,
            this.复制到剪贴板CToolStripMenuItem,
            this.删除DToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(177, 70);
            // 
            // 查看私钥VToolStripMenuItem
            // 
            this.查看私钥VToolStripMenuItem.Name = "查看私钥VToolStripMenuItem";
            this.查看私钥VToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.查看私钥VToolStripMenuItem.Text = "View &Private Key";
            this.查看私钥VToolStripMenuItem.Click += new System.EventHandler(this.查看私钥VToolStripMenuItem_Click);
            // 
            // 复制到剪贴板CToolStripMenuItem
            // 
            this.复制到剪贴板CToolStripMenuItem.Name = "复制到剪贴板CToolStripMenuItem";
            this.复制到剪贴板CToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.复制到剪贴板CToolStripMenuItem.ShowShortcutKeys = false;
            this.复制到剪贴板CToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.复制到剪贴板CToolStripMenuItem.Text = "&Copy to Clipboard";
            this.复制到剪贴板CToolStripMenuItem.Click += new System.EventHandler(this.复制到剪贴板CToolStripMenuItem_Click);
            // 
            // 删除DToolStripMenuItem
            // 
            this.删除DToolStripMenuItem.Name = "删除DToolStripMenuItem";
            this.删除DToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.删除DToolStripMenuItem.Text = "&Delete...";
            this.删除DToolStripMenuItem.Click += new System.EventHandler(this.删除DToolStripMenuItem_Click);
            // 
            // AccountFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.lblBct);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblBcp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblAddress);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AccountFrm";
            this.Size = new System.Drawing.Size(825, 39);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblBcp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblBct;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 查看私钥VToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 复制到剪贴板CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除DToolStripMenuItem;
    }
}
