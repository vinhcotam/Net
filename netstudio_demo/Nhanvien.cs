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
            conn = new SqlConnection(@connstr);
            conn.Open();
            string sql = "select * from HoaDon";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DGVHoaDon.DataSource = dt;
            sql = "select * from User_tk";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);
            DGVUser_tk.DataSource = dt;
        }

    }
}
