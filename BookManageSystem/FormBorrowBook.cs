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
    public partial class FormBorrowBook : Form
    {
        public FormBorrowBook()
        {
            InitializeComponent();
        }

        private void Loadbook()
        {
            Dao dao = new Dao();
            dao.connect();
            string sql = "select * from T_Book";
            SqlDataReader reader = dao.read(sql);
            while (reader.Read())
            {
                dgv.Rows.Add(
                    reader[0].ToString(),
                    reader[1].ToString(),
                    reader[2].ToString(),
                    reader[3].ToString(),
                    reader[4].ToString(),
                    reader[9].ToString(), //类型
                    reader[5].ToString(),
                    reader[6].ToString(),
                    reader[7].ToString(),
                    reader[8].ToString()
                );
            }
            reader.Close();
            dao.DaoClose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //加载显示数据
        private void FormBorrowBook_Load(object sender, EventArgs e)
        {
            Loadbook();
            cobNum.Text = "1";
            if (dgv.Rows.Count == 1)
            {
                ;
            }
            else
            {
                lbName.Text = dgv.CurrentRow.Cells[1].Value.ToString();
            }
        }

        //租借
        private void button1_Click(object sender, EventArgs e)
        {
            //获取要租借书的信息
            string name = dgv.CurrentRow.Cells[1].Value.ToString();
            int id = int.Parse(dgv.CurrentRow.Cells[0].Value.ToString());

            int num = int.Parse(cobNum.Text); //租借数量
            DateTime date = DateTime.Now;
            int key = 1;

            Dao dao = new Dao();
            dao.connect();
            //查询key是否有某本书 key为sql关键字加中括号
            string sql = $"select keys from T_Borrow where keys = '{key}'";
            SqlDataReader reader = dao.read(sql);
            reader.Read();

            while (true)
            {
                key++;
                sql = $"select keys from T_Borrow where keys = '{key}'";
                reader = dao.read(sql);
                reader.Read();

                if (!reader.HasRows) //有无数据
                {
                    break;
                }
            }
            reader.Close();

            //判断库存是否充足 库存不足取消
            string sqlFlag = $"select Bid from T_Book where Num-'{num}'>=0 and Bid = '{id}'";
            SqlDataReader readerFlag = dao.read(sqlFlag);
            if (!readerFlag.Read())
            {
                MessageBox.Show("库存不足！", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                readerFlag.Close();
             
                return;
            }
            //租借       T_Book T_Borrow
            string sqlInsert =
                $"insert into T_Borrow values('{key}','{Form1.name}','{Form1.id}','{name}','{date}','{num}','{id}')";
            string sqlUpdate =
                $"update T_Book set Num=Num-'{num}',BorrowCount=BorrowCount+'{num}' where Bid = '{id}'";
            if (dao.Execute(sqlInsert) > 0 && dao.Execute(sqlUpdate) > 0)
            {
                dao.DaoClose();
                MessageBox.Show("租借成功！", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgv.Rows.Clear();
                Loadbook();
                
            }
            else
            {
                MessageBox.Show("租借失败！", "消息", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                dao.DaoClose();
            }
        }

        //选中单元格事件 改标题
        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv.CurrentRow == null || dgv.CurrentRow.Cells[0].Value == null)
            {
                MessageBox.Show("选择无效数据！", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            lbName.Text = dgv.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
