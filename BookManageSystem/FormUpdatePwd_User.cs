using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManageSystem
{
    public partial class FormUpdatePwd_User : Form
    {
        public FormUpdatePwd_User()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //需要返回的可能
            if (txtNewPwd.Text == "" || txtOldPwd.Text == "" || txtOkPwd.Text == "")
            {
                //空项返回
                MessageBox.Show("有空项", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtNewPwd.Text != txtOkPwd.Text)
            {
                //两次密码不一致
                MessageBox.Show("两次密码不一致", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //密码是否匹配
            Dao dao = new Dao();
            dao.connect();
            //读取原密码
            string sql = $"SELECT Pwd from T_User WHERE Uid = '{Form1.id}'";
            SqlDataReader reader = dao.read(sql);
            reader.Read();

            if (reader[0].ToString() != txtOldPwd.Text)
            {
                //原密码错误
                MessageBox.Show("原密码错误", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                sql = $"UPDATE T_User SET Pwd = '{txtNewPwd.Text}' WHERE Uid = '{Form1.id}'";
                if (dao.Execute(sql) > 0)
                {
                    //密码遮盖 UseSystemPassword
                    MessageBox.Show("修改成功", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    reader.Close();
                    dao.DaoClose();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("修改失败", "消息", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                }
            }
            catch
            {
                MessageBox.Show("sql语法错误！", "消息", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
