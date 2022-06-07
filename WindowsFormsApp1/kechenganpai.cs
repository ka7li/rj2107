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
    public partial class kechenganpai : Form
    {
        public kechenganpai()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kecheng2 kecheng2 = new kecheng2();
            this.Hide();
            kecheng2.ShowDialog();
            this.Show();
        }

        private void kechenganpai_Load(object sender, EventArgs e)
        {
            table();
        }
        public void table()
        {
            dataGridView1.Rows.Clear();//清空旧数据
            stushujuku stu = new stushujuku();
            string sql = "select * from kecheng";
            IDataReader kegl = stu.read(sql);
            while (kegl.Read())//对bfgl进行读行循环
            {
                dataGridView1.Rows.Add(kegl[0].ToString(), kegl[1].ToString(), kegl[2].ToString());
            }
            kegl.Close();
            stu.stushujukuClose();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            table();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();//获取序号
            DialogResult dr = MessageBox.Show("确认删除吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                string sql = string.Format("delete from kecheng where kechengxuhao ='{0}'", id);
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
    }
}
