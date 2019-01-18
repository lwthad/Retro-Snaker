namespace 贪吃蛇
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuGame = new System.Windows.Forms.ToolStripMenuItem();
            this.MemuStart = new System.Windows.Forms.ToolStripMenuItem();
            this.MemuPause = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.速度ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.加快ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.减速ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuGame,
            this.速度ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(522, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuGame
            // 
            this.MenuGame.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MemuStart,
            this.MemuPause,
            this.MenuExit});
            this.MenuGame.Name = "MenuGame";
            this.MenuGame.Size = new System.Drawing.Size(41, 20);
            this.MenuGame.Text = "游戏";
            // 
            // MemuStart
            // 
            this.MemuStart.Name = "MemuStart";
            this.MemuStart.Size = new System.Drawing.Size(94, 22);
            this.MemuStart.Text = "开始";
            this.MemuStart.Click += new System.EventHandler(this.MemuStart_Click);
            // 
            // MemuPause
            // 
            this.MemuPause.Enabled = false;
            this.MemuPause.Name = "MemuPause";
            this.MemuPause.Size = new System.Drawing.Size(94, 22);
            this.MemuPause.Text = "暂停";
            this.MemuPause.Click += new System.EventHandler(this.MemuPause_Click);
            // 
            // MenuExit
            // 
            this.MenuExit.Enabled = false;
            this.MenuExit.Name = "MenuExit";
            this.MenuExit.Size = new System.Drawing.Size(94, 22);
            this.MenuExit.Text = "退出";
            this.MenuExit.Click += new System.EventHandler(this.MenuExit_Click);
            // 
            // 速度ToolStripMenuItem
            // 
            this.速度ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.加快ToolStripMenuItem,
            this.减速ToolStripMenuItem});
            this.速度ToolStripMenuItem.Name = "速度ToolStripMenuItem";
            this.速度ToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.速度ToolStripMenuItem.Text = "速度";
            // 
            // 加快ToolStripMenuItem
            // 
            this.加快ToolStripMenuItem.Name = "加快ToolStripMenuItem";
            this.加快ToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.加快ToolStripMenuItem.Text = "加快";
            this.加快ToolStripMenuItem.Click += new System.EventHandler(this.加快ToolStripMenuItem_Click);
            // 
            // 减速ToolStripMenuItem
            // 
            this.减速ToolStripMenuItem.Name = "减速ToolStripMenuItem";
            this.减速ToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.减速ToolStripMenuItem.Text = "减速";
            this.减速ToolStripMenuItem.Click += new System.EventHandler(this.减速ToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.帮助ToolStripMenuItem.Text = "帮助";
            this.帮助ToolStripMenuItem.Click += new System.EventHandler(this.帮助ToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(395, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = " 级别：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(461, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "等分：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 342);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "贪吃蛇V1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuGame;
        private System.Windows.Forms.ToolStripMenuItem MemuStart;
        private System.Windows.Forms.ToolStripMenuItem MemuPause;
        private System.Windows.Forms.ToolStripMenuItem MenuExit;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem 速度ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 加快ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 减速ToolStripMenuItem;
    }
}

