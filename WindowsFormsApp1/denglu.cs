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

    public partial class MIanForm : Form
    {
        public MIanForm()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                denglu();
            }
            else
            {
                MessageBox.Show("账号或者密码为空，请重新输入", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定退出吗？", "疑问", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //登陆方法 验证登陆 
        public void denglu() 
        {
            if (radioButton1.Checked == true)//学生
            {
                stushujuku stu = new stushujuku();
                string sql = $"select * from studenglu where stuname='{textBox1.Text}' and stupwd='{textBox2.Text}'";
                IDataReader reader = stu.read(sql);
                if (reader.Read())
                {
                    MessageBox.Show("登陆成功","提示");
                    xuesheng xs = new xuesheng();
                    this.Hide();
                    xs.ShowDialog();
                    this.Show();
                    
                }
                else
                {
                    MessageBox.Show("登陆失败","提示");
                    
                }
                stu.stushujukuClose();
            }
            if (radioButton2.Checked == true)//管理员
            {
                stushujuku stu = new stushujuku();
                string sql = $"select * from guanliyuandenglu where guanliyuanname='{textBox1.Text}' and guanliyuanpwd='{textBox2.Text}'";
                IDataReader reader = stu.read(sql);
                if (reader.Read())
                {
                    MessageBox.Show("登陆成功","提示");
                    guanliyuan gly = new guanliyuan();
                    this.Hide();
                    gly.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("登陆失败","提示");
                    
                }
                stu.stushujukuClose();
            }

            
        }
    }
}
