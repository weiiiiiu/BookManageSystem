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
    public partial class FormLookBorrow : Form
    {
        public FormLookBorrow()
        {
            InitializeComponent();
        }

        private void BorrowInfo()
        {
            dgv.Rows.Clear();
            Dao dao = new Dao();
            dao.connect();
            string sql = $"select * from T_Borrow";
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

        private void FormLookBorrow_Load(object sender, EventArgs e)
        {
            //加载租借表中所有信息
            BorrowInfo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string key = txtKey.Text.Trim();
            if (key == "")
            {
                MessageBox.Show("请输入关键字！", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Dao dao = new Dao();
            dao.connect();
            string sql =
                $"select * from T_Borrow where Bname like '%{key}%' or Uname like '%{key}%'";
            IDataReader dc = dao.read(sql);
            dgv.Rows.Clear();
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
    }
}
