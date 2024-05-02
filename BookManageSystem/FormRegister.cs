using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManageSystem
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCencel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //判断为空
            if(txtName.Text == "" || txtPwd.Text == "" || txtTel.Text == ""||coSex.Text==""||txtIdCard.Text
                ==""||txtAgainPwd.Text=="")
            {
                MessageBox.Show("请填写完整信息！","消息",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }

            if (txtPwd.Text.Trim()!=txtAgainPwd.Text.Trim())//不包括空格
            {
                MessageBox.Show("两次密码不一致！", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //账号随机生成
            Dao dao = new Dao();
            dao.connect();

            string sql = "select MAX(Uid) from T_User";
            SqlDataReader reader = dao.read(sql);
            reader.Read();
            int id = int.Parse(reader[0].ToString());
            string name = txtName.Text;
            string idCard = txtIdCard.Text;
            string sex = coSex.Text;
            string pwd = txtPwd.Text;
            string tel = txtTel.Text;


            sql = $"insert into T_User(Uid,Uname,Pwd,Sex,IdCard,Tel,Used) values('{id + 1}','{name}','{pwd}','{sex}','{idCard}','{tel}','1')";//插入数据
            if (dao.Execute(sql) > 0)
            {
                MessageBox.Show($"注册成功！您的账号是{id}", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("注册失败！", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            reader.Close();
            dao.DaoClose();
        }
    }
}
