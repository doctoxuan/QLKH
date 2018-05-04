using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace thlvn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btlogin_Click(object sender, EventArgs e)

        {
            SqlConnection conn = new SqlConnection(@"Data Source=THANHXUAN\SQLEXPRESS;Initial Catalog=thlvn;Integrated Security=True");
            try
            {
                conn.Open();
                string tk= txtTaiKhoan.Text;
                string mk = txtMatKhau.Text;
                string sql = "select * from Qlks where TaiKhoan='" + tk + "' and MatKhau='" + mk + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dta = cmd.ExecuteReader();
                if(dta.Read()==true)
                {
                    MessageBox.Show("Đăng Nhập Thành Công","Chúc Mừng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form2 home = new Form2();
                    this.Hide();
                    conn.Close();
                    home.Show();
                }
                else
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu", "Xin Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Lỗi Kết Nối");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
