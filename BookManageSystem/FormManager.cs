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

        private void LoadBooks()
        {
            Dao dao = new Dao();
            dao.connect();
            string sql = "select * from T_Book";
            SqlDataReader reader = dao.read(sql);
            while (reader.Read())
            {
                dgv.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(),
                             reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString());
            }   

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
            string id = dgv.CurrentRow.Cells[0].Value.ToString();//选中图书编号
            string name = dgv.CurrentRow.Cells[1].Value.ToString();//选中图书编号
            LbId.Text = id;
            LbName.Text = name;
           
        }
    }
}
