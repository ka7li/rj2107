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
    public partial class kechengchaxun : Form
    {
        public kechengchaxun()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tableID();
        }
        public void tableID()
        {
            dataGridView1.Rows.Clear();//清空旧数据
            stushujuku stu = new stushujuku();
            string sql = $"select * from kecheng where kechengxuhao = '{textBox1.Text}'";
            IDataReader kegl = stu.read(sql);
            while (kegl.Read())//对bfgl进行读行循环
            {
                dataGridView1.Rows.Add(kegl[0].ToString(), kegl[1].ToString(), kegl[2].ToString());
            }
            kegl.Close();
            stu.stushujukuClose();

        }
        public void table()
        {
            dataGridView1.Rows.Clear();//清空旧数据
            stushujuku stu = new stushujuku();
            string sql = $"select * from kecheng";
            IDataReader kegl = stu.read(sql);
            while (kegl.Read())//对bfgl进行读行循环
            {
                dataGridView1.Rows.Add(kegl[0].ToString(), kegl[1].ToString(), kegl[2].ToString());
            }
            kegl.Close();
            stu.stushujukuClose();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            table();
        }
    }
}
