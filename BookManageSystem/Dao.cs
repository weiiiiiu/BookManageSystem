using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManageSystem
{
    internal class Dao
    {
        SqlConnection sc;
        public SqlConnection connect()//连接数据库的方法
        {
            string str = @"Data Source=localhost;Initial Catalog=studentsdb;Integrated Security=True;Encrypt=False";
            sc = new SqlConnection(str);
            sc.Open();
            return sc;

        }
        public SqlCommand command(string sql)//执行sql语句的方法
        {
            SqlCommand cmd = new SqlCommand(sql, connect());
            return cmd;
        }
        public int Execute(string sql)
        {
           
            return command(sql).ExecuteNonQuery(); //返回受影响的行数
        }
        public SqlDataReader read(string sql)
        {
            return command(sql).ExecuteReader();//返回查询结果
        }
        public void DaoClose()//关闭数据库的方法
        {
            sc.Close();
        }
    }
}
