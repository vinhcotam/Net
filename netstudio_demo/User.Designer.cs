namespace netstudio_demo
{
    partial class User
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.L_account = new System.Windows.Forms.Label();
            this.BTN_Changepass = new System.Windows.Forms.Button();
            this.L_Money = new System.Windows.Forms.Label();
            this.RTB_Chat = new System.Windows.Forms.RichTextBox();
            this.BTN_Send = new System.Windows.Forms.Button();
            this.BTN_service = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.L_time = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // L_account
            // 
            this.L_account.AutoSize = true;
            this.L_account.Location = new System.Drawing.Point(9, 9);
            this.L_account.Name = "L_account";
            this.L_account.Size = new System.Drawing.Size(58, 13);
            this.L_account.TabIndex = 0;
            this.L_account.Text = " Tài khoản";
            // 
            // BTN_Changepass
            // 
            this.BTN_Changepass.Location = new System.Drawing.Point(122, 259);
            this.BTN_Changepass.Name = "BTN_Changepass";
            this.BTN_Changepass.Size = new System.Drawing.Size(98, 34);
            this.BTN_Changepass.TabIndex = 1;
            this.BTN_Changepass.Text = " Đổi mật khẩu";
            this.BTN_Changepass.UseVisualStyleBackColor = true;
            // 
            // L_Money
            // 
            this.L_Money.AutoSize = true;
            this.L_Money.Location = new System.Drawing.Point(13, 41);
            this.L_Money.Name = "L_Money";
            this.L_Money.Size = new System.Drawing.Size(29, 13);
            this.L_Money.TabIndex = 2;
            this.L_Money.Text = "Còn:";
            // 
            // RTB_Chat
            // 
            this.RTB_Chat.Location = new System.Drawing.Point(16, 88);
            this.RTB_Chat.Name = "RTB_Chat";
            this.RTB_Chat.Size = new System.Drawing.Size(300, 146);
            this.RTB_Chat.TabIndex = 3;
            this.RTB_Chat.Text = "";
            // 
            // BTN_Send
            // 
            this.BTN_Send.Location = new System.Drawing.Point(226, 259);
            this.BTN_Send.Name = "BTN_Send";
            this.BTN_Send.Size = new System.Drawing.Size(109, 34);
            this.BTN_Send.TabIndex = 4;
            this.BTN_Send.Text = "Nhắn tin";
            this.BTN_Send.UseVisualStyleBackColor = true;
            // 
            // BTN_service
            // 
            this.BTN_service.Location = new System.Drawing.Point(254, 20);
            this.BTN_service.Name = "BTN_service";
            this.BTN_service.Size = new System.Drawing.Size(62, 55);
            this.BTN_service.TabIndex = 5;
            this.BTN_service.Text = "Dịch vụ";
            this.BTN_service.UseVisualStyleBackColor = true;
            this.BTN_service.Click += new System.EventHandler(this.BTN_service_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 34);
            this.button1.TabIndex = 6;
            this.button1.Text = " Đăng xuất";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // L_time
            // 
            this.L_time.AutoSize = true;
            this.L_time.Location = new System.Drawing.Point(13, 62);
            this.L_time.Name = "L_time";
            this.L_time.Size = new System.Drawing.Size(51, 13);
            this.L_time.TabIndex = 7;
            this.L_time.Text = "Thời gian";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 321);
            this.Controls.Add(this.L_time);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BTN_service);
            this.Controls.Add(this.BTN_Send);
            this.Controls.Add(this.RTB_Chat);
            this.Controls.Add(this.L_Money);
            this.Controls.Add(this.BTN_Changepass);
            this.Controls.Add(this.L_account);
            this.Name = "User";
            this.Text = "User";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.User_FormClosing);
            this.Load += new System.EventHandler(this.User_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label L_account;
        private System.Windows.Forms.Button BTN_Changepass;
        private System.Windows.Forms.Label L_Money;
        private System.Windows.Forms.RichTextBox RTB_Chat;
        private System.Windows.Forms.Button BTN_Send;
        private System.Windows.Forms.Button BTN_service;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label L_time;
        private System.Windows.Forms.Timer timer1;
    }
}