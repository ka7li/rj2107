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
    public partial class stujiben : Form
    {
        public stujiben()
        {
            InitializeComponent();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();//获取学生姓名
            DialogResult dr = MessageBox.Show("确认删除吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                string sql = string.Format("delete from stujibenxinxi where stuname ='{0}'", id);
                stushujuku stu = new stushujuku();
                if (stu.Execute(sql) > 0)

                {
                    MessageBox.Show("删除成功");
                    table();
                }
                else
                {
                    MessageBox.Show("删除失败" + sql);
                }
                stu.stushujukuClose();
            }
        }

        private void stujiben_Load(object sender, EventArgs e)
        {
            table();//构建窗体完成执行这个事件
        }


        public void table() 
        {
            dataGridView1.Rows.Clear();//清空旧数据
            stushujuku stu = new stushujuku();
            string sql = "select * from stujibenxinxi";
            IDataReader xsxx = stu.read(sql);
            while (xsxx.Read())//对xsxx进行读行循环
            {
                dataGridView1.Rows.Add(xsxx[0].ToString(), xsxx[1].ToString(), xsxx[2].ToString(), xsxx[3].ToString(), xsxx[4].ToString());
            }
            xsxx.Close();
            stu.stushujukuClose(); 

        }

        private void button1_Click(object sender, EventArgs e)
        {
            stujiben2 s2 = new stujiben2();
            this.Hide();
            s2.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            stujiben2 s2 = new stujiben2();
            this.Hide();
            s2.ShowDialog();
            this.Show();
        }
    }
}
