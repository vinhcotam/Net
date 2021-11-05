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
            string connstr = "Data Source=THINKPADT430\\SQLEXPRESS;Initial Catalog=BTL_net;Integrated Security=True";
            //string sqlstr = "Data Source=LAPTOP-Q5ASBT2Q\\SQLEXPRESS;Initial Catalog=BTL_net;Integrated Security=True";
            SqlConnection conn = new SqlConnection(@connstr);
            try {
                conn.Open();
                string tk = tbtkdn.Text;
                string mk = tbmkdn.Text;
               // int level = int.Parse(numericUpDown1.Value);
                string sql = "select * from taikhoan where TenTK='"+tk+"'and matkhau='"+mk+"'";
                SqlCommand cmd = new SqlCommand(sql,conn);
                SqlDataReader dt= cmd.ExecuteReader();
                if (dt.Read() == true)
                {
                    int level = (int)dt["level_tk"];
                    Form f = null;
                    if (level == 0)
                    {
                        MessageBox.Show("dang nhap thanh cong");
                        conn.Close();
                        f = new Admin(connstr, tk);
                    } else if (level == 1)
                    {
                        MessageBox.Show("dang nhap thanh cong");
                        conn.Close();
                        f = new Nhanvien(connstr, tk);
                    } else if (level == 2)
                    {
                        MessageBox.Show("dang nhap thanh cong");
                        conn.Close();
                        f = new User(connstr, tk);
                    }
                    f.ShowDialog();
                    /*string sql1="select level_tk from taikhoan where TenTK='"+tk+"'and matkhau='"+mk+"'";
                    SqlCommand cmd1 = new SqlCommand(sql1, conn);*/
                    
                }
                else
                {
                    MessageBox.Show("dang nhap that bai");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi kết nối");
            }
        }

    }
}
