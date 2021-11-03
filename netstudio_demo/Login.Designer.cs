
namespace netstudio_demo
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbtkdn = new System.Windows.Forms.TextBox();
            this.tbmkdn = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btdn = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên tài khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu";
            // 
            // tbtkdn
            // 
            this.tbtkdn.Location = new System.Drawing.Point(118, 47);
            this.tbtkdn.Name = "tbtkdn";
            this.tbtkdn.Size = new System.Drawing.Size(250, 22);
            this.tbtkdn.TabIndex = 2;
            this.tbtkdn.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbmkdn
            // 
            this.tbmkdn.Location = new System.Drawing.Point(118, 102);
            this.tbmkdn.Name = "tbmkdn";
            this.tbmkdn.Size = new System.Drawing.Size(250, 22);
            this.tbmkdn.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btdn);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.tbtkdn);
            this.groupBox1.Controls.Add(this.tbmkdn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(27, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 237);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đăng nhập";
            // 
            // btdn
            // 
            this.btdn.Location = new System.Drawing.Point(265, 145);
            this.btdn.Name = "btdn";
            this.btdn.Size = new System.Drawing.Size(103, 46);
            this.btdn.TabIndex = 5;
            this.btdn.Text = " Đăng nhập";
            this.btdn.UseVisualStyleBackColor = true;
            this.btdn.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(22, 159);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(119, 21);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "hiện mật khẩu";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 254);
            this.Controls.Add(this.groupBox1);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbtkdn;
        private System.Windows.Forms.TextBox tbmkdn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button log;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btdn;
    }
}