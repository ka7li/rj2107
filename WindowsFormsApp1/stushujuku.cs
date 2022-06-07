using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    class stushujuku
    {
        //在外面做一个变量
        SqlConnection stu;
        public SqlConnection connect() 
        {
            string str = "server=.;database=class;uid=sa;pwd=1230";
            stu = new SqlConnection(str);
            stu.Open();
            return stu;
        }
        public SqlCommand command(string sql) 
        {
            SqlCommand cmd = new SqlCommand(sql,connect());
            return cmd;
        }
        public int Execute(string sql) //更新数据库操作
        {
            return command(sql).ExecuteNonQuery();
        }
        public SqlDataReader read(string sql) //读取数据库操作 
        {
            return command(sql).ExecuteReader();
        }
        public void stushujukuClose() 
        {
            stu.Close();//关闭数据库链接
        }
    }
}
