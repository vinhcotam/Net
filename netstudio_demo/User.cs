﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace netstudio_demo
{
    public partial class User : Form
    {
        string Account = "";
        public User(string Acc)
        {
            InitializeComponent();
            Account = Acc;

        }
        public User()
        {
            InitializeComponent();
        }

        private void User_Load(object sender, EventArgs e)
        {

        }
    }
}
