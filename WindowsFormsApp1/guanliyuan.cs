using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class guanliyuan : Form
    {
        public guanliyuan()
        {
            InitializeComponent();
        }

        private void 班会ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            banhuianpai banhuianpai = new banhuianpai();
            this.Hide();
            banhuianpai.ShowDialog();
            this.Show();
        }

        private void 班级简介ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            banjijianjie banjijianjie = new banjijianjie();
            this.Hide();
            banjijianjie.ShowDialog();
            this.Show();
        }

        private void 课程安排ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kechenganpai kechenganpai = new kechenganpai();
            this.Hide();
            kechenganpai.ShowDialog();
            this.Show();
        }

        private void 班费管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            banfeiguanli banfeiguanli = new banfeiguanli();
            this.Hide();
            banfeiguanli.ShowDialog();
            this.Show();
        }

        private void 学生信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stujiben s2 = new stujiben();
            this.Hide();
            s2.ShowDialog();
            this.Show();

        }
    }
}
