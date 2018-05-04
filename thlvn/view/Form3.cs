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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

        }
        SqlConnection conn= new SqlConnection(@"Data Source=THANHXUAN\SQLEXPRESS;Initial Catalog=thlvn;Integrated Security=True");
        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("delete from dbo.Qlkh where cmnd = '" + textBox2.Text + "'", conn);
            sda.SelectCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Delete Complete!!!!");
        }

        private void lnkhome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 home = new Form2();
            this.Hide();
            home.ShowDialog();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public String chuyen (String a)
        {
            String[] date = a.Split(' ');
           if(date[2].Equals("Giêng"))
           {
               date[2] = "1";
           }
           else if (date[2].Equals("Hai"))
           {
               date[2] = "2";
           }
           else if (date[2].Equals("Ba"))
           {
               date[2] = "3";
           }
           else if (date[2].Equals("Tư"))
           {
               date[2] = "4";
           }
           else if(date[2].Equals("Năm"))
           {
               date[2] = "5";
           }
           else if(date[2].Equals("Sáu"))
           {
               date[2] = "6";
           }
           else if(date[2].Equals("Bảy"))
           {
               date[2] = "7";
           }
           else if(date[2].Equals("Tám"))
           {
               date[2] = "8";
           }
           else if(date[2].Equals("Chín"))
           {
               date[2] = "9";
           }
           else if(date[2].Equals("Mười"))
           {
               date[2] = "10";
           }
           else if(date[2].Equals("Mười Một"))
           {
               date[2] = "11";
           }
            else if(date[2].Equals("Mười 2"))
           {
               date[2] = "12";
           }

           return date[3]+"-"+date[2]+"-"+date[0];
        }
        private void button5_Click(object sender, EventArgs e)
        {
            String a = chuyen(dateTimePicker1.Text);
            String b = chuyen(dateTimePicker2.Text);      
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("update dbo.Qlkh set tenkh='" + textBox1.Text + "',ngaysinh='" + a + "',sophong='" + textBox3.Text + "',giaphong=" + textBox4.Text + ",ngayden='" + b + "' where cmnd='" + textBox2.Text +"'", conn);
            sda.SelectCommand.ExecuteNonQuery();//cái này cũng vậy, chỗ giá phòng nó phải có giá trị số thì mới dc.nảy ở nhà nhạp số mà nó vẫn bị ấy chứ.có cần mình code thêm phần  nếu chưa nhạp nó yêu cầu nhạp k
            conn.Close();
            MessageBox.Show("Sửa thành công");
        }
        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String a = chuyen(dateTimePicker1.Text);
            String b = chuyen(dateTimePicker2.Text);
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("insert into dbo.Qlkh (tenkh,ngaysinh,cmnd,sophong,giaphong,ngayden) values ('" + textBox1.Text + "','" + a + "','" + textBox2.Text + "','" + textBox3.Text + "'," + textBox4.Text + ",'" +b +"')", conn);
            sda.SelectCommand.ExecuteNonQuery();// sửa lại bắt buộc llaf số mặc định là 0 nếu ko là sai
            conn.Close();
            MessageBox.Show("Đăng Ký Thành Công!!!!");
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * from dbo.Qlkh", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource=dt;
            conn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
