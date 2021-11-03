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
    public partial class User : Form
    {
        string Account = "";
        SqlConnection conn = null;
        double money = 0;
        public User(string connstr, string Acc)
        {
            InitializeComponent();
            Account = Acc;
            conn = new SqlConnection(@connstr);
            conn.Open();
            L_account.Text = "Tài khoản: " + Account;
            string sql = "select * from TaiKhoan, User_tk where User_tk.TenTK = TaiKhoan.TenTK and TaiKhoan.TenTK = '" + Account + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dt = cmd.ExecuteReader();
            dt.Read();
            money = (double)dt["Sotien"];
            L_Money.Text = "Còn lại: " + money;
            L_time.Text = "Thời gian còn: " + moneytotime(4000);
            timer1.Interval = 1000;
            timer1.Start();
        }
        public User()
        {
            InitializeComponent();
        }
        string moneytotime(double priceperhour)
        {
            string str = "Thời gian còn: ";
            double time = money / priceperhour;
            return TimeSpan.FromHours(time).ToString(@"hh\:mm\:ss");
        }
        private void User_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            L_time.Text = "Thời gian còn: " + moneytotime(4000);
            money -= 4000 / 3600;
        }
    }
}
