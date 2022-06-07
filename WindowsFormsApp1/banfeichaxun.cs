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
    public partial class banfeichaxun : Form
    {
        public banfeichaxun()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            tableID();
        }
        public void table()
        {
            dataGridView1.Rows.Clear();//清空旧数据
            stushujuku stu = new stushujuku();
            string sql = $"select * from banfei";
            IDataReader bfgl = stu.read(sql);
            while (bfgl.Read())//对bfgl进行读行循环
            {
                dataGridView1.Rows.Add(bfgl[0].ToString(), bfgl[1].ToString(), bfgl[2].ToString(), bfgl[3].ToString());
            }
            bfgl.Close();
            stu.stushujukuClose();

        }


        public void tableID()
        {
            dataGridView1.Rows.Clear();//清空旧数据
            stushujuku stu = new stushujuku();
            string sql = $"select * from banfei where banfeixuhao = '{textBox1.Text}'";
            IDataReader bfgl = stu.read(sql);
            while (bfgl.Read())//对bfgl进行读行循环
            {
                dataGridView1.Rows.Add(bfgl[0].ToString(), bfgl[1].ToString(), bfgl[2].ToString(), bfgl[3].ToString());
            }
            bfgl.Close();
            stu.stushujukuClose();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            table();
        }
    }
}
