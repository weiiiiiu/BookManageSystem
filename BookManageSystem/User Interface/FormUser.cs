using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManageSystem
{
    public partial class FormUser : Form
    {
        public FormUser()
        {
            InitializeComponent();
        }

        private void 退出登录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show(" 确认退出", "消息", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                //退出
                this.Close();
            }
        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            this.label1.Text = $"用户:{Form1.name}        {Form1.id}";
        }

        private void 注销账号ToolStripMenuItem_Click(object sender, EventArgs e) //删除sql信息
        {
            if (DialogResult.Yes == MessageBox.Show(" 确定注销当前账号吗", "消息", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                //删除
                //获取注销账号
                int id = Form1.id;
                Dao dao = new Dao();
                dao.connect();
                string sql = $"delete T_user where Uid = '{id}'  ";
                if(dao.Execute(sql) > 0)
                {
                    MessageBox.Show("注销成功", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //返回登陆
                    dao.DaoClose();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("注销失败", "消息", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    dao.DaoClose();
                    this.Close();
                }
            }
        }

        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUpdatePwd_User form = new FormUpdatePwd_User();
            form.ShowDialog();
        }

        private void 租借图书ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBorrowBook form = new FormBorrowBook();
            form.ShowDialog();
        } 
    }
}
