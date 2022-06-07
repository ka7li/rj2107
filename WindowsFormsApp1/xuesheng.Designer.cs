
namespace WindowsFormsApp1
{
    partial class xuesheng
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.基本信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询班费ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询班会ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询课程ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.班级简介ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.基本信息ToolStripMenuItem,
            this.查询班费ToolStripMenuItem,
            this.查询班会ToolStripMenuItem,
            this.查询课程ToolStripMenuItem,
            this.班级简介ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 基本信息ToolStripMenuItem
            // 
            this.基本信息ToolStripMenuItem.Name = "基本信息ToolStripMenuItem";
            this.基本信息ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.基本信息ToolStripMenuItem.Text = "基本信息";
            this.基本信息ToolStripMenuItem.Click += new System.EventHandler(this.基本信息ToolStripMenuItem_Click);
            // 
            // 查询班费ToolStripMenuItem
            // 
            this.查询班费ToolStripMenuItem.Name = "查询班费ToolStripMenuItem";
            this.查询班费ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.查询班费ToolStripMenuItem.Text = "查询班费";
            this.查询班费ToolStripMenuItem.Click += new System.EventHandler(this.查询班费ToolStripMenuItem_Click);
            // 
            // 查询班会ToolStripMenuItem
            // 
            this.查询班会ToolStripMenuItem.Name = "查询班会ToolStripMenuItem";
            this.查询班会ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.查询班会ToolStripMenuItem.Text = "查询班会";
            this.查询班会ToolStripMenuItem.Click += new System.EventHandler(this.查询班会ToolStripMenuItem_Click);
            // 
            // 查询课程ToolStripMenuItem
            // 
            this.查询课程ToolStripMenuItem.Name = "查询课程ToolStripMenuItem";
            this.查询课程ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.查询课程ToolStripMenuItem.Text = "查询课程";
            this.查询课程ToolStripMenuItem.Click += new System.EventHandler(this.查询课程ToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(253, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "欢迎学生登陆！";
            // 
            // 班级简介ToolStripMenuItem
            // 
            this.班级简介ToolStripMenuItem.Name = "班级简介ToolStripMenuItem";
            this.班级简介ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.班级简介ToolStripMenuItem.Text = "班级简介";
            this.班级简介ToolStripMenuItem.Click += new System.EventHandler(this.班级简介ToolStripMenuItem_Click);
            // 
            // xuesheng
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "xuesheng";
            this.Text = "学生界面";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 基本信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询班费ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询班会ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询课程ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem 班级简介ToolStripMenuItem;
    }
}