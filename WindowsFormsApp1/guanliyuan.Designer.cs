
namespace WindowsFormsApp1
{
    partial class guanliyuan
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
            this.班级简介ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.班费管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.课程安排ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.班会ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.学生信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.班级简介ToolStripMenuItem,
            this.班费管理ToolStripMenuItem,
            this.课程安排ToolStripMenuItem,
            this.班会ToolStripMenuItem,
            this.学生信息ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 班级简介ToolStripMenuItem
            // 
            this.班级简介ToolStripMenuItem.Name = "班级简介ToolStripMenuItem";
            this.班级简介ToolStripMenuItem.Size = new System.Drawing.Size(83, 26);
            this.班级简介ToolStripMenuItem.Text = "班级简介";
            this.班级简介ToolStripMenuItem.Click += new System.EventHandler(this.班级简介ToolStripMenuItem_Click);
            // 
            // 班费管理ToolStripMenuItem
            // 
            this.班费管理ToolStripMenuItem.Name = "班费管理ToolStripMenuItem";
            this.班费管理ToolStripMenuItem.Size = new System.Drawing.Size(83, 26);
            this.班费管理ToolStripMenuItem.Text = "班费管理";
            this.班费管理ToolStripMenuItem.Click += new System.EventHandler(this.班费管理ToolStripMenuItem_Click);
            // 
            // 课程安排ToolStripMenuItem
            // 
            this.课程安排ToolStripMenuItem.Name = "课程安排ToolStripMenuItem";
            this.课程安排ToolStripMenuItem.Size = new System.Drawing.Size(83, 26);
            this.课程安排ToolStripMenuItem.Text = "课程安排";
            this.课程安排ToolStripMenuItem.Click += new System.EventHandler(this.课程安排ToolStripMenuItem_Click);
            // 
            // 班会ToolStripMenuItem
            // 
            this.班会ToolStripMenuItem.Name = "班会ToolStripMenuItem";
            this.班会ToolStripMenuItem.Size = new System.Drawing.Size(83, 26);
            this.班会ToolStripMenuItem.Text = "班会管理";
            this.班会ToolStripMenuItem.Click += new System.EventHandler(this.班会ToolStripMenuItem_Click);
            // 
            // 学生信息ToolStripMenuItem
            // 
            this.学生信息ToolStripMenuItem.Name = "学生信息ToolStripMenuItem";
            this.学生信息ToolStripMenuItem.Size = new System.Drawing.Size(113, 26);
            this.学生信息ToolStripMenuItem.Text = "添加学生信息";
            this.学生信息ToolStripMenuItem.Click += new System.EventHandler(this.学生信息ToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(198, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "欢迎管理员登陆！";
            // 
            // guanliyuan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "guanliyuan";
            this.Text = "管理员界面";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 班级简介ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 班费管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 课程安排ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 班会ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem 学生信息ToolStripMenuItem;
    }
}