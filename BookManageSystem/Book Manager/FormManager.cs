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
    public partial class FormManager : Form
    {
        public FormManager()
        {
            InitializeComponent();
        }

        //修改图书变量
        public static int Bid;
        public static string Bname;
        public static string Author;
        public static string Publisher;
        public static string PubDate;
        public static string Type;
        public static int Num;
        public static float Price;
        public static string Introduce;

        private void LoadBooks()
        {
            dgv.Rows.Clear();
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

        private void FormManager_Load(object sender, EventArgs e)
        {
            //加载图书信息
            LoadBooks();
        }

        //点击表格数据触发
        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv.CurrentRow == null || dgv.CurrentRow.Cells[0].Value == null)
            {
                MessageBox.Show("选择无效数据！", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string id = dgv.CurrentRow.Cells[0].Value.ToString(); //选中图书编号
            string name = dgv.CurrentRow.Cells[1].Value.ToString(); //选中图书编号
            LbId.Text = id;
            LbName.Text = name;

            //选中将数据赋值修改变量
            Bid = int.Parse(dgv.CurrentRow.Cells[0].Value.ToString());
            Bname = dgv.CurrentRow.Cells[1].Value.ToString();
            Author = dgv.CurrentRow.Cells[2].Value.ToString();
            Publisher = dgv.CurrentRow.Cells[3].Value.ToString();
            PubDate = dgv.CurrentRow.Cells[4].Value.ToString();
            Type = dgv.CurrentRow.Cells[5].Value.ToString();
            Num = int.Parse(dgv.CurrentRow.Cells[7].Value.ToString());
            Price = float.Parse(dgv.CurrentRow.Cells[6].Value.ToString());
            Introduce = dgv.CurrentRow.Cells[8].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LoadBooks();
        }

        //查看简介
        private void button2_Click(object sender, EventArgs e)
        {
            if (LbName.Text == "NULL")
            {
                MessageBox.Show("未选中图书！", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Dao dao = new Dao();
                dao.connect();
                string sql = $"select Introduce from T_Book where Bid='{LbId.Text}'";
                SqlDataReader reader = dao.read(sql);
                reader.Read();
                string introduce = reader[0].ToString();
                //对话框显示简介
                MessageBox.Show(
                    introduce,
                    $"{LbName.Text}",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //关键字模糊查询
            string key = txtKey.Text.Trim();
            Dao dao = new Dao();
            dao.connect();
            string sql =
                $"select * from T_Book where Bname like '%{key}%' or Publisher like '%{key}%' or Author like '%{key}%' ";
            SqlDataReader reader = dao.read(sql);
            //清空表格 将查询数据进行显示
            dgv.Rows.Clear();
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

        private void button4_Click(object sender, EventArgs e)
        {
            //获取图书编号
            string id = LbId.Text;
            if (id == "NULL")
            {
                MessageBox.Show("未选中图书！", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //删除图书 更新表格
            Dao dao = new Dao();
            dao.connect();
            string sql = $"delete from T_Book where Bid='{id}'";
            if (dao.Execute(sql) > 0)
            {
                LbId.Text = "NULL";
                LbName.Text = "NUll";
                LoadBooks();
                dao.DaoClose();
                MessageBox.Show("下架成功！", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("下架失败！", "消息", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormUpdateBook form = new FormUpdateBook();
            form.ShowDialog();
        }
    }
}
