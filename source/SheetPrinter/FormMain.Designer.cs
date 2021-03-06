﻿namespace SheetPrinter
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbInputMode = new System.Windows.Forms.ComboBox();
            this.lbTemplate = new System.Windows.Forms.ListBox();
            this.lvTaskList = new System.Windows.Forms.ListView();
            this.menuTaskItem = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.编辑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.toolStripMenuItem配置 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem打印配置 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem字体配置 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem填充管理 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem任务 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem打印 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem清空 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem关于 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menuTaskItem.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 27);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.cbInputMode);
            this.splitContainer1.Panel1.Controls.Add(this.lbTemplate);
            this.splitContainer1.Panel1MinSize = 200;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lvTaskList);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2MinSize = 100;
            this.splitContainer1.Size = new System.Drawing.Size(616, 423);
            this.splitContainer1.SplitterDistance = 200;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "运单模版（双击启动）";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "数据录入模式";
            // 
            // cbInputMode
            // 
            this.cbInputMode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbInputMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbInputMode.FormattingEnabled = true;
            this.cbInputMode.Location = new System.Drawing.Point(10, 30);
            this.cbInputMode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbInputMode.Name = "cbInputMode";
            this.cbInputMode.Size = new System.Drawing.Size(190, 27);
            this.cbInputMode.TabIndex = 1;
            // 
            // lbTemplate
            // 
            this.lbTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTemplate.FormattingEnabled = true;
            this.lbTemplate.ItemHeight = 19;
            this.lbTemplate.Location = new System.Drawing.Point(10, 85);
            this.lbTemplate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbTemplate.Name = "lbTemplate";
            this.lbTemplate.Size = new System.Drawing.Size(190, 327);
            this.lbTemplate.TabIndex = 0;
            this.lbTemplate.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbTemplate_MouseDoubleClick);
            // 
            // lvTaskList
            // 
            this.lvTaskList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvTaskList.ContextMenuStrip = this.menuTaskItem;
            this.lvTaskList.FullRowSelect = true;
            this.lvTaskList.GridLines = true;
            this.lvTaskList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvTaskList.Location = new System.Drawing.Point(0, 30);
            this.lvTaskList.Name = "lvTaskList";
            this.lvTaskList.Size = new System.Drawing.Size(400, 383);
            this.lvTaskList.TabIndex = 0;
            this.lvTaskList.UseCompatibleStateImageBehavior = false;
            this.lvTaskList.View = System.Windows.Forms.View.Details;
            this.lvTaskList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvTaskList_MouseDoubleClick);
            // 
            // menuTaskItem
            // 
            this.menuTaskItem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.编辑ToolStripMenuItem,
            this.删除ToolStripMenuItem});
            this.menuTaskItem.Name = "menuTaskItem";
            this.menuTaskItem.Size = new System.Drawing.Size(101, 48);
            this.menuTaskItem.Opening += new System.ComponentModel.CancelEventHandler(this.menuTaskItem_Opening);
            // 
            // 编辑ToolStripMenuItem
            // 
            this.编辑ToolStripMenuItem.Name = "编辑ToolStripMenuItem";
            this.编辑ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.编辑ToolStripMenuItem.Text = "编辑";
            this.编辑ToolStripMenuItem.Click += new System.EventHandler(this.编辑ToolStripMenuItem_Click);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.删除ToolStripMenuItem.Text = "删除";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "任务列表";
            // 
            // toolStripMenuItem配置
            // 
            this.toolStripMenuItem配置.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem打印配置,
            this.toolStripMenuItem字体配置,
            this.toolStripMenuItem填充管理});
            this.toolStripMenuItem配置.Name = "toolStripMenuItem配置";
            this.toolStripMenuItem配置.Size = new System.Drawing.Size(44, 21);
            this.toolStripMenuItem配置.Text = "配置";
            // 
            // toolStripMenuItem打印配置
            // 
            this.toolStripMenuItem打印配置.Name = "toolStripMenuItem打印配置";
            this.toolStripMenuItem打印配置.Size = new System.Drawing.Size(124, 22);
            this.toolStripMenuItem打印配置.Text = "打印配置";
            this.toolStripMenuItem打印配置.Click += new System.EventHandler(this.toolStripMenuItem打印配置_Click);
            // 
            // toolStripMenuItem字体配置
            // 
            this.toolStripMenuItem字体配置.Name = "toolStripMenuItem字体配置";
            this.toolStripMenuItem字体配置.Size = new System.Drawing.Size(124, 22);
            this.toolStripMenuItem字体配置.Text = "字体配置";
            this.toolStripMenuItem字体配置.Click += new System.EventHandler(this.toolStripMenuItem字体配置_Click);
            // 
            // toolStripMenuItem填充管理
            // 
            this.toolStripMenuItem填充管理.Name = "toolStripMenuItem填充管理";
            this.toolStripMenuItem填充管理.Size = new System.Drawing.Size(124, 22);
            this.toolStripMenuItem填充管理.Text = "填充管理";
            this.toolStripMenuItem填充管理.Click += new System.EventHandler(this.toolStripMenuItem填充管理_Click);
            // 
            // toolStripMenuItem任务
            // 
            this.toolStripMenuItem任务.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem打印,
            this.toolStripMenuItem清空});
            this.toolStripMenuItem任务.Name = "toolStripMenuItem任务";
            this.toolStripMenuItem任务.Size = new System.Drawing.Size(44, 21);
            this.toolStripMenuItem任务.Text = "任务";
            // 
            // toolStripMenuItem打印
            // 
            this.toolStripMenuItem打印.Name = "toolStripMenuItem打印";
            this.toolStripMenuItem打印.Size = new System.Drawing.Size(100, 22);
            this.toolStripMenuItem打印.Text = "打印";
            this.toolStripMenuItem打印.Click += new System.EventHandler(this.toolStripMenuItem打印_Click);
            // 
            // toolStripMenuItem清空
            // 
            this.toolStripMenuItem清空.Name = "toolStripMenuItem清空";
            this.toolStripMenuItem清空.Size = new System.Drawing.Size(100, 22);
            this.toolStripMenuItem清空.Text = "清空";
            this.toolStripMenuItem清空.Click += new System.EventHandler(this.toolStripMenuItem清空_Click);
            // 
            // toolStripMenuItem关于
            // 
            this.toolStripMenuItem关于.Name = "toolStripMenuItem关于";
            this.toolStripMenuItem关于.Size = new System.Drawing.Size(44, 21);
            this.toolStripMenuItem关于.Text = "关于";
            this.toolStripMenuItem关于.Click += new System.EventHandler(this.toolStripMenuItem关于_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem配置,
            this.toolStripMenuItem任务,
            this.toolStripMenuItem关于});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip.Size = new System.Drawing.Size(616, 27);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(632, 489);
            this.Name = "FormMain";
            this.Text = "物流运单打印工具";
            this.Activated += new System.EventHandler(this.FormMain_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.menuTaskItem.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbInputMode;
        private System.Windows.Forms.ListBox lbTemplate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lvTaskList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem配置;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem填充管理;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem字体配置;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem任务;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem打印;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem清空;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem关于;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ContextMenuStrip menuTaskItem;
        private System.Windows.Forms.ToolStripMenuItem 编辑ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem打印配置;
    }
}

