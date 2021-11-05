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
            conn = new SqlConnection(@connstr);
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
            DGVDichVu.DataSource = dt;
        }
        public Admin()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
