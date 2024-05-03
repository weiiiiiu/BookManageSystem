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
    public partial class FormUpdateBook : Form
    {
        public FormUpdateBook()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //加载显示选中数据方便修改
        private void FormUpdateBook_Load(object sender, EventArgs e)
        {
            txtId.Text = FormManager.Bid.ToString();
            txtAuthor.Text = FormManager.Author;
            txtName.Text = FormManager.Bname;
            txtIntroduce.Text = FormManager.Introduce;
            txtNum.Text = FormManager.Num.ToString();
            txtPrice.Text = FormManager.Price.ToString();
            dtpDate.Value = DateTime.Parse(FormManager.PubDate);
            txtPublisher.Text = FormManager.Publisher;
            txtType.Text = FormManager.Type;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //判断文本框为空
            if (txtAuthor.Text.Trim() == "" || txtId.Text == "" || txtIntroduce.Text == "" || txtName.Text == "" || txtPrice.Text == "" || txtPublisher.Text == "" || txtType.Text == "" || txtNum.Text == "" || dtpDate.Text == "")
            {
                MessageBox.Show("请填写完整信息！", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //修改图书信息
            Dao dao = new Dao();
            dao.connect();
            string sql = $"update T_Book set Bid ='{txtId.Text}',Bname='{txtName.Text}',Author='{txtAuthor.Text}',Publisher='{txtPublisher.Text}',Date='{dtpDate.Value}',Price='{float.Parse(txtPrice.Text)}',Num='{int.Parse(txtNum.Text)}',Introduce='{txtIntroduce.Text}',Type='{txtType.Text}' " +
                $"where Bid='{FormManager.Bid}'";
            if (dao.Execute(sql) > 0)
            {
                dao.DaoClose();
                MessageBox.Show("修改成功！", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                dao.DaoClose();
                MessageBox.Show("修改失败！", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
