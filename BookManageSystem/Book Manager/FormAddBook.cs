using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BookManageSystem
{
    public partial class FormAddBook : Form
    {
        public FormAddBook()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //空项返回
            if(txtAuthor.Text.Trim()==""||txtId.Text==""||txtIntroduce.Text==""||txtName.Text==""||txtPrice.Text==""||txtPublisher.Text==""||txtType.Text==""||TxtNum.Text==""||dtpPBDate.Text=="")
            {
                MessageBox.Show("请填写完整信息！", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Dao dao = new Dao();
            dao.connect();
            string sql = $"insert into T_Book(Bid,Bname,Author,Publisher,Date,Price,Num,Introduce,BorrowCount) values('{int.Parse(txtId.Text)}','{txtName.Text}','{txtAuthor.Text}','{txtPublisher.Text}','{dtpPBDate.Value}','{float.Parse(txtPrice.Text)}','{int.Parse(TxtNum.Text)}','{txtIntroduce.Text}','0')";
            if (dao.Execute(sql) > 0)
            {
                dao.DaoClose();
                MessageBox.Show("添加成功！", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                dao.DaoClose();
                MessageBox.Show("添加成功！", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
