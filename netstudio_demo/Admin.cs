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
    public partial class Admin : Form
    {
        SqlConnection conn = null;
        public Admin(string connstr, string Acc)
        {
            InitializeComponent();
            /*conn = new SqlConnection(@connstr);
            conn.Open();
            string sql = "select * from TaiKhoan";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DGVTaiKhoan.DataSource = dt;
            sql = "select * from HoaDon";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);
            DGVHoaDon.DataSource = dt;
            sql = "select * from DichVu";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);
            DGVDichVu.DataSource = dt;*/
        }
        public Admin()
        {
            InitializeComponent();
            
        }
        private void Admin_Load(object sender, EventArgs e)
        {
            string connstr = "Data Source=LAPTOP-Q5ASBT2Q\\SQLEXPRESS;Initial Catalog=BTL_net;Integrated Security=True";
            conn = new SqlConnection(@connstr);
            conn.Open();
            load();
            load1();
            load2();
        }
        public void load()
        {
            string sql = "select mahd,taikhoansudung,madv,soluong,manv,ngay,dbo.thanhtoan(taikhoansudung) as thanhtoan from HoaDon";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            DGVHoaDon.DataSource = dt;
        }
        public void load1()
        {
            string sql = "select * from taikhoan";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            DGVTaiKhoan.DataSource = dt;
        }
        public void load2()
        {
            string sql = "select * from dichvu";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            DGVDichVu.DataSource = dt;
        }

        private void DGVTaiKhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = DGVTaiKhoan.CurrentRow.Index;
            textBox4.Text = DGVTaiKhoan.Rows[i].Cells[0].Value.ToString();
            textBox2.Text = DGVTaiKhoan.Rows[i].Cells[1].Value.ToString();
            textBox1.Text = DGVTaiKhoan.Rows[i].Cells[2].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sqlinsert = "insert into hoadon values (@mahd,@taikhoansudung,@madv,@soluong,@manv,@ngay,@thanhtoan)";
            SqlCommand cmd = new SqlCommand(sqlinsert, conn);
            cmd.Parameters.AddWithValue("mahd", textBox5.Text);
            cmd.Parameters.AddWithValue("taikhoansudung", textBox6.Text);
            cmd.Parameters.AddWithValue("madv", textBox7.Text);
            cmd.Parameters.AddWithValue("soluong", textBox8.Text);
            cmd.Parameters.AddWithValue("manv", textBox9.Text);
            cmd.Parameters.AddWithValue("ngay", textBox10.Text);
            //cmd.Parameters.AddWithValue("thanhtoan", textBox11.Text);
            cmd.ExecuteNonQuery();
            load();
        }

        private void DGVHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = DGVHoaDon.CurrentRow.Index;
            textBox5.Text = DGVHoaDon.Rows[i].Cells[0].Value.ToString();
            textBox6.Text = DGVHoaDon.Rows[i].Cells[1].Value.ToString();
            textBox7.Text = DGVHoaDon.Rows[i].Cells[2].Value.ToString();
            textBox8.Text = DGVHoaDon.Rows[i].Cells[3].Value.ToString();
            textBox9.Text = DGVHoaDon.Rows[i].Cells[4].Value.ToString();
            textBox10.Text = DGVHoaDon.Rows[i].Cells[5].Value.ToString();
            //textBox11.Text = DGVHoaDon.Rows[i].Cells[6].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sqlupdate = "update hoadon set taikhoansudung=@taikhoansudung,madv=@madv,soluong=@soluong,manv=@manv,ngay=@ngay,thanhtoan=@thanhtoan where mahd=@mahd";
            SqlCommand cmd = new SqlCommand(sqlupdate, conn);
            cmd.Parameters.AddWithValue("mahd", textBox5.Text);
            cmd.Parameters.AddWithValue("taikhoansudung", textBox6.Text);
            cmd.Parameters.AddWithValue("madv", textBox7.Text);
            cmd.Parameters.AddWithValue("soluong", textBox8.Text);
            cmd.Parameters.AddWithValue("manv", textBox9.Text);
            cmd.Parameters.AddWithValue("ngay", textBox10.Text);
            //cmd.Parameters.AddWithValue("thanhtoan", textBox11.Text);
            cmd.ExecuteNonQuery();
            load();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sqldelete = "delete from hoadon where mahd=@mahd";
            SqlCommand cmd = new SqlCommand(sqldelete, conn);
            cmd.Parameters.AddWithValue("mahd", textBox5.Text);
            cmd.ExecuteNonQuery();
            load();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string sqlinsert = "insert into taikhoan values (@tentk,@matkhau,@level_tk)";
            SqlCommand cmd = new SqlCommand(sqlinsert, conn);
            cmd.Parameters.AddWithValue("tentk", textBox4.Text);
            cmd.Parameters.AddWithValue("matkhau", textBox2.Text);
            cmd.Parameters.AddWithValue("level_tk", textBox1.Text);
            cmd.ExecuteNonQuery();
            load1();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string sqlupdate = "update taikhoan set MatKhau=@matkhau, level_tk=@level_tk where TenTK=@tentk";
            SqlCommand cmd = new SqlCommand(sqlupdate, conn);
            cmd.Parameters.AddWithValue("tentk", textBox4.Text);
            cmd.Parameters.AddWithValue("matkhau", textBox2.Text);
            cmd.Parameters.AddWithValue("level_tk", textBox1.Text);
            cmd.ExecuteNonQuery();
            load1();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string sqldelete = "delete from taikhoan where tentk=@tentk";
            SqlCommand cmd = new SqlCommand(sqldelete, conn);
            cmd.Parameters.AddWithValue("tentk", textBox4.Text);
            cmd.ExecuteNonQuery();
            load1();
        }

        private void DGVDichVu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = DGVDichVu.CurrentRow.Index;
            textBox3.Text = DGVDichVu.Rows[i].Cells[0].Value.ToString();
            textBox11.Text = DGVDichVu.Rows[i].Cells[1].Value.ToString();
            textBox12.Text = DGVDichVu.Rows[i].Cells[2].Value.ToString();
            textBox13.Text = DGVDichVu.Rows[i].Cells[3].Value.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string sqlinsert = "insert into dichvu values (@madv,@tendv,@mota,@gia)";
            SqlCommand cmd = new SqlCommand(sqlinsert, conn);
            cmd.Parameters.AddWithValue("madv", textBox3.Text);
            cmd.Parameters.AddWithValue("tendv", textBox11.Text);
            cmd.Parameters.AddWithValue("mota", textBox12.Text);
            cmd.Parameters.AddWithValue("gia", textBox13.Text);
            cmd.ExecuteNonQuery();
            load2();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string sqlupdate = "update dichvu set tendv=@tendv, mota=@mota,gia=@gia where madv=@madv";
            SqlCommand cmd = new SqlCommand(sqlupdate, conn);
            cmd.Parameters.AddWithValue("madv", textBox3.Text);
            cmd.Parameters.AddWithValue("tendv", textBox11.Text);
            cmd.Parameters.AddWithValue("mota", textBox12.Text);
            cmd.Parameters.AddWithValue("gia", textBox13.Text);
            cmd.ExecuteNonQuery();
            load2();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string sqldelete = "delete from dichvu where madv=@madv";
            SqlCommand cmd = new SqlCommand(sqldelete, conn);
            cmd.Parameters.AddWithValue("madv", textBox3.Text);
            cmd.ExecuteNonQuery();
            load2();
        }






    }
}
