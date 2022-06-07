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
    public partial class xuesheng : Form
    {
        public xuesheng()
        {
            InitializeComponent();
        }

        private void 基本信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stuji stuji = new stuji();
            this.Hide();
            stuji.ShowDialog();
            this.Show();
        }

        private void 查询班费ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            banfeichaxun banfeichaxun = new banfeichaxun();
            this.Hide();
            banfeichaxun.ShowDialog();
            this.Show();
        }

        private void 查询班会ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            banhuichaxun banhuichaxun = new banhuichaxun();
            this.Hide();
            banhuichaxun.ShowDialog();
            this.Show();
        }

        private void 查询课程ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kechengchaxun kechengchaxun = new kechengchaxun();
            this.Hide();
            kechengchaxun.ShowDialog();
            this.Show();
        }

        private void 班级简介ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            banjijianjie banjijianjie = new banjijianjie();
            this.Hide();
            banjijianjie.ShowDialog();
            this.Show();
        }
    }
}
