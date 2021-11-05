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
        int tgchoi = 0;
        double giaphong = 8000;
        string Account = "";
        SqlConnection conn = null;
        string connstr = "";
        double money = 0;
        public User(string connstr, string Acc)
        {
            InitializeComponent();
            Account = Acc;
            this.connstr = connstr;
            conn = new SqlConnection(@connstr);
            conn.Open();
            L_account.Text = "Tài khoản: " + Account;
            string sql = "select * from TaiKhoan, User_tk where User_tk.TenTK = TaiKhoan.TenTK and TaiKhoan.TenTK = '" + Account + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dt = cmd.ExecuteReader();
            dt.Read();
            money = (double)dt["Sotien"];
            L_Money.Text = "Còn lại: " + money;
            L_time.Text = "Thời gian còn: " + moneytotime(giaphong);
            timer1.Interval = 1000;
            timer1.Start();
            dt.Close();
            cmd.Cancel();
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
            L_time.Text = "Thời gian còn: " + moneytotime(giaphong);
            money -= (double)giaphong / 3600;
            L_Money.Text = "Còn lại: " + money.ToString("0.#");
            tgchoi++;
        }

        private void BTN_service_Click(object sender, EventArgs e)
        {
            Form f = new Service(connstr);
            f.ShowDialog();
        }

        private void User_FormClosing(object sender, FormClosingEventArgs e)
        {
            string tgchoistr = TimeSpan.FromSeconds(tgchoi).ToString(@"hh\:mm\:ss");
                string sql = "update user_tk set Sotien = " + money.ToString("0.##") + " where TenTK = '" + Account + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                MessageBox.Show(sql);
                cmd.ExecuteNonQuery();
        }
    }
}
