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

namespace netstudio_demo
{
    public partial class Nhanvien : Form
    {
        SqlConnection conn = null;
        public Nhanvien(string connstr, string Acc)
        {
            InitializeComponent();
        }
        private void Nhanvien_Load(object sender, EventArgs e)
        {
            string connstr = "Data Source=LAPTOP-Q5ASBT2Q\\SQLEXPRESS;Initial Catalog=BTL_net;Integrated Security=True";
            conn = new SqlConnection(@connstr);
            conn.Open();
            /*string sql; //= "select mahd,taikhoansudung,madv,soluong,manv,ngay,dbo.thanhtoan(taikhoansudung) as thanhtoan from HoaDon";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);*/
            //SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            /*DataTable dt = new DataTable();
            da.Fill(dt);
            DGVHoaDon.DataSource = dt;
            sql = "select * from User_tk";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DGVUser_tk.DataSource = dt;
            load();*/

            load();
            load1();
        }
        public void load()
        {
            string sql= "select mahd,taikhoansudung,madv,soluong,manv,ngay,dbo.thanhtoan(taikhoansudung) as thanhtoan from HoaDon";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            DGVHoaDon.DataSource = dt;
            //SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            /*DataTable dt = new DataTable();
            da.Fill(dt);
            DGVHoaDon.DataSource = dt;*/
        }
        public void load1()
        {
            string sql = "select * from user_tk";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            DGVUser_tk.DataSource = dt;
        }
        private void DGVHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = DGVHoaDon.CurrentRow.Index;
            textBox1.Text = DGVHoaDon.Rows[i].Cells[0].Value.ToString();
            textBox2.Text = DGVHoaDon.Rows[i].Cells[1].Value.ToString();
            textBox4.Text = DGVHoaDon.Rows[i].Cells[2].Value.ToString();
            textBox5.Text = DGVHoaDon.Rows[i].Cells[3].Value.ToString();
            textBox6.Text = DGVHoaDon.Rows[i].Cells[4].Value.ToString();
            textBox7.Text = DGVHoaDon.Rows[i].Cells[5].Value.ToString();
            textBox8.Text = DGVHoaDon.Rows[i].Cells[6].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sqlinsert = "insert into hoadon values (@mahd,@taikhoansudung,@madv,@soluong,@manv,@ngay,@thanhtoan)";
            SqlCommand cmd = new SqlCommand(sqlinsert, conn);
            cmd.Parameters.AddWithValue("mahd", textBox1.Text);
            cmd.Parameters.AddWithValue("taikhoansudung", textBox2.Text);
            cmd.Parameters.AddWithValue("madv", textBox4.Text);
            cmd.Parameters.AddWithValue("soluong", textBox5.Text);
            cmd.Parameters.AddWithValue("manv", textBox6.Text);
            cmd.Parameters.AddWithValue("ngay", textBox7.Text);
            cmd.Parameters.AddWithValue("thanhtoan", textBox8.Text);
            cmd.ExecuteNonQuery();
            load();

            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string sqldelete = "delete from hoadon where mahd=@mahd";
            SqlCommand cmd = new SqlCommand(sqldelete, conn);
            cmd.Parameters.AddWithValue("mahd", textBox1.Text);
            cmd.ExecuteNonQuery();
            load();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sqlupdate = "update hoadon set taikhoansudung=@taikhoansudung,madv=@madv,soluong=@soluong,manv=@manv,ngay=@ngay,thanhtoan=@thanhtoan where mahd=@mahd";
            SqlCommand cmd = new SqlCommand(sqlupdate, conn);
            cmd.Parameters.AddWithValue("mahd", textBox1.Text);
            cmd.Parameters.AddWithValue("taikhoansudung", textBox2.Text);
            cmd.Parameters.AddWithValue("madv", textBox4.Text);
            cmd.Parameters.AddWithValue("soluong", textBox5.Text);
            cmd.Parameters.AddWithValue("manv", textBox6.Text);
            cmd.Parameters.AddWithValue("ngay", textBox7.Text);
            cmd.Parameters.AddWithValue("thanhtoan", textBox8.Text);
            cmd.ExecuteNonQuery();
            load();
        }

        private void DGVUser_tk_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



    }
}
