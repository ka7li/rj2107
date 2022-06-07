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
    public partial class banfeiguanli : Form
    {

        public banfeiguanli()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            banfeiguanli2 b2 = new banfeiguanli2();
            this.Hide();
            b2.ShowDialog();
            this.Show();
        }
        public void table()
        {
            dataGridView1.Rows.Clear();//清空旧数据
            stushujuku stu = new stushujuku();
            string sql = "select * from banfei";
            IDataReader bfgl = stu.read(sql);
            while (bfgl.Read())//对bfgl进行读行循环
            {
                dataGridView1.Rows.Add(bfgl[0].ToString(), bfgl[1].ToString(), bfgl[2].ToString(), bfgl[3].ToString());
            }
            bfgl.Close();
            stu.stushujukuClose();

        }


       /* public void tableID()
        {
            dataGridView1.Rows.Clear();//清空旧数据
            stushujuku stu = new stushujuku();
            string sql = $"select * from banfei where banfeixuhao = ''";
            IDataReader bfgl = stu.read(sql);
            while (bfgl.Read())//对bfgl进行读行循环
            {
                dataGridView1.Rows.Add(bfgl[0].ToString(), bfgl[1].ToString(), bfgl[2].ToString(), bfgl[3].ToString());
            }
            bfgl.Close();
            stu.stushujukuClose();

        }*/
        private void banfeiguanli_Load(object sender, EventArgs e)
        {
            
            table();
         
        }

        private void button4_Click(object sender, EventArgs e)
        {
            table();
        }

        private void button2_Click(object sender, EventArgs e)
        {
                string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();//获取班费序号
                DialogResult dr = MessageBox.Show("确认删除吗？","提示",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                string sql = string.Format("delete from banfei where banfeixuhao ='{0}'", id);
                    stushujuku stu = new stushujuku();
                    if (stu.Execute(sql)>0)
        
                    {
                        MessageBox.Show("删除成功");
                        table();
                    }
                    else
                    {
                        MessageBox.Show("删除失败"+sql);
                    }
                    stu.stushujukuClose();
                }

            }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
