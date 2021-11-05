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
    public partial class Service : Form
    {
        public Service()
        {
            InitializeComponent();
        }
        SqlConnection conn = null;
        public Service(string connstr)
        {
            InitializeComponent();
            conn = new SqlConnection(@connstr);
            string sql = "select * from DichVu";
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
