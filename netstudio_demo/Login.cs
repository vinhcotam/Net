using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace netstudio_demo
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn =new SqlConnection(@"Data Source=LAPTOP-Q5ASBT2Q\SQLEXPRESS;Initial Catalog=BTL_net;Integrated Security=True");
            try {
                conn.Open();
                string tk = tbtkdn.Text;
                string mk = tbmkdn.Text;
                string sql = "select * from taikhoan where TenTK='"+tk+"'and matkhau='"+mk+"'";
                SqlCommand cmd = new SqlCommand(sql,conn);
                SqlDataReader dt= cmd.ExecuteReader();
                if (dt.Read() == true)
                {
                    
                    //MessageBox.Show("dang nhap thanh cong");
                }
                else
                {
                    MessageBox.Show("dang nhap that bai");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối");
            }
        }
    }
}
