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
    public partial class FormReturnBook : Form
    {
        public FormReturnBook()
        {
            InitializeComponent();
        }

        private void BorrowInfo()
        {
            dgv.Rows.Clear();
            Dao dao = new Dao();
            dao.connect();
            string sql = $"select * from T_Borrow where Uid = '{Form1.id}'";
            IDataReader dc = dao.read(sql);
            while (dc.Read())
            {
                dgv.Rows.Add(
                    dc[1].ToString(),
                    dc[2].ToString(),
                    dc[0].ToString(),
                    dc[6].ToString(),
                    dc[3].ToString(),
                    dc[4].ToString(),
                    dc[5].ToString()
                );
            }
            dc.Close();
            dao.DaoClose();
        }

        private void FormReturnBook_Load(object sender, EventArgs e)
        {
            //显示当前账号租借情况
            BorrowInfo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //判断是否选中
            if (dgv.CurrentRow.Cells[0].Value == null)
            {
                MessageBox.Show("请选择要归还的书籍！", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //num
            Dao dao = new Dao();
            dao.connect();
            string sqlDelete = $"delete T_Borrow where keys = '{int.Parse(dgv.CurrentRow.Cells[2].Value.ToString())}'";
            string sqlUpdate =
                $"update T_Book set Num = Num + '{int.Parse(dgv.CurrentRow.Cells[6].Value.ToString())}' where Bid ='{int.Parse(dgv.CurrentRow.Cells[3].Value.ToString())}' ";
            if (dao.Execute(sqlDelete) > 0 && dao.Execute(sqlUpdate) > 0)
            {
                MessageBox.Show("归还成功！", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BorrowInfo();
            }
            else
            {
                MessageBox.Show("归还失败！", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
