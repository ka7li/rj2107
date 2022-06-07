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
    public partial class banhuichaxun : Form
    {
        public banhuichaxun()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tableID();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            table();
        }
        public void table()
        {
            dataGridView1.Rows.Clear();//清空旧数据
            stushujuku stu = new stushujuku();
            string sql = $"select * from banhui";
            IDataReader bh = stu.read(sql);
            while (bh.Read())//对bh进行读行循环
            {
                dataGridView1.Rows.Add(bh[0].ToString(), bh[1].ToString(), bh[2].ToString());
            }
            bh.Close();
            stu.stushujukuClose();

        }
        public void tableID()
        {
            dataGridView1.Rows.Clear();//清空旧数据
            stushujuku stu = new stushujuku();
            string sql = $"select * from banhui where banhuixuhao = '{textBox1.Text}'";
            IDataReader bh = stu.read(sql);
            while (bh.Read())//对bfgl进行读行循环
            {
                dataGridView1.Rows.Add(bh[0].ToString(), bh[1].ToString(), bh[2].ToString(), bh[3].ToString());
            }
            bh.Close();
            stu.stushujukuClose();

        }
    }
}
