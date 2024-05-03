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
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void 退出登录ToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void FormAdmin_Load(object sender, EventArgs e) //窗体加载事件
        {
            this.label1.Text = $"管理员:{Form1.name}        {Form1.id}";
        }

        private void 注销账号ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (
                DialogResult.Yes
                == MessageBox.Show(
                    " 确定注销当前账号吗",
                    "消息",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                )
            )
            {
                //删除
                //获取注销账号
                int id = Form1.id;
                Dao dao = new Dao();
                dao.connect();
                string sql = $"delete T_Admin where AdminId = '{id}'  ";
                if (dao.Execute(sql) > 0)
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
            FormUpdatePwd_Admin form = new FormUpdatePwd_Admin();
            form.ShowDialog();
        }

        private void 添加图书ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddBook form = new FormAddBook();
            form.ShowDialog();
        }

        private void 修改图书ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormManager form = new FormManager();
            form.ShowDialog();
        }

        private void 下架图书ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormManager form = new FormManager();
            form.ShowDialog();
        }

        private void 搜索图书ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormManager form = new FormManager();
            form.ShowDialog();
        }

        private void 查看用户租借情况ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLookBorrow form = new FormLookBorrow();
            form.ShowDialog();
        }

        private void 用户信息管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLookUser formLookUser = new FormLookUser();
            formLookUser.ShowDialog();
        }
    }
}
