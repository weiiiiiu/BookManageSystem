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

//acceptbutton   默认按钮
namespace BookManageSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //用户账号和姓名
        public static int id;
        public static string name;

        //管理员登陆方法  获取账号密码对比数据库
        public void AdminLogin()
        {
            int id = int.Parse(txtId.Text);
            string pwd = txtPwd.Text;
            Dao dao = new Dao();
            dao.connect();
            string sql = $"select * from T_Admin where AdminId = '{id}' and Pwd = '{pwd}'     ";
            SqlDataReader reader = dao.read(sql);
            if (reader.Read() == true)
            {
                //表有登录数据
                Form1.id = id;
                sql = $"select Name from T_Admin where AdminId='{id}'";
                reader = dao.read(sql);
                reader.Read();
                Form1.name = reader[0].ToString();

                txtId.Text = "";
                txtPwd.Text = "";

                reader.Close();
                dao.DaoClose();

                FormAdmin form = new FormAdmin();
                form.ShowDialog();
            }
            else
            {
                //账号密码不存在
                MessageBox.Show("账号密码错误！", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void UserLogin()
        {
            int id = int.Parse(txtId.Text);
            string pwd = txtPwd.Text;
            Dao dao = new Dao();
            dao.connect();
            string sql = $"select * from T_User where Uid= '{id}' and Pwd = '{pwd}'     ";
            SqlDataReader reader = dao.read(sql);
            if (reader.Read() == true)
            {
                //表有登录数据
                Form1.id = id;
                sql = $"select Uname from T_User where Uid='{id}'";
                reader = dao.read(sql);
                reader.Read();
                Form1.name = reader[0].ToString();

                txtId.Text = "";
                txtPwd.Text = "";

                reader.Close();
                dao.DaoClose();

                FormUser form = new FormUser();
                form.ShowDialog();
            }
            else
            {
                //账号密码不存在
                MessageBox.Show("账号密码错误！", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            FormRegister form = new FormRegister();
            form.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (
                DialogResult.Yes
                == MessageBox.Show(" 确认退出", "消息", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            )
            {
                //退出
                this.Close();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //判断文本框是否为空
            if ((txtId.Text == "" || txtPwd.Text == ""))
            {
                MessageBox.Show("请填写完整信息！", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //判断登录对象
            if (rbtnAdmin.Checked == true)
            {
                //管理员登录
                AdminLogin();
            }
            if (rbtnUser.Checked == true)
            {
                UserLogin();
            }
        }
    }
}
