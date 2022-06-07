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
    public partial class stujiben2 : Form
    {
        public stujiben2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            stushujuku stu = new stushujuku();//数据库实例化
            string sql = $"insert into stujibenxinxi values ('{textBox1.Text}',{textBox2.Text},'{textBox3.Text}','{textBox4.Text}','{textBox5.Text}')";
            int s = stu.Execute(sql);//将sql作为参数就可以执行sql语句
            if (s>0)
            {
                MessageBox.Show("添加成功","提示",MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("添加失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //清空上面的文本框
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //作用同上
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }
    }
}
