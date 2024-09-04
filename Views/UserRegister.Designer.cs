using System.Windows.Forms;

namespace SchoolManagement.Views
{
    partial class UserRegister
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
            lblLogin = new Label();
            linkForgetPassword = new LinkLabel();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            btnRegister = new Button();
            btnLogin = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Khmer OS Content", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.Location = new Point(135, 38);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(171, 31);
            lblLogin.TabIndex = 11;
            lblLogin.Text = "ប្រព័ន្ធគ្របគ្រងសាលា";
            // 
            // linkForgetPassword
            // 
            linkForgetPassword.AutoSize = true;
            linkForgetPassword.Font = new Font("Khmer OS Battambang", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkForgetPassword.Location = new Point(177, 314);
            linkForgetPassword.Name = "linkForgetPassword";
            linkForgetPassword.Size = new Size(97, 22);
            linkForgetPassword.TabIndex = 10;
            linkForgetPassword.TabStop = true;
            linkForgetPassword.Text = " ភ្លេចលេខសម្ងាត់?";
            linkForgetPassword.LinkClicked += linkForgetPassword_LinkClicked;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Khmer OS Battambang", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(103, 177);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "លេខសម្ងាត់";
            txtPassword.Size = new Size(238, 30);
            txtPassword.TabIndex = 7;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Khmer OS Battambang", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(103, 104);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "ឈ្មោះអ្នកប្រើ";
            txtUsername.Size = new Size(238, 30);
            txtUsername.TabIndex = 6;
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Khmer OS Battambang", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegister.Location = new Point(228, 263);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(113, 30);
            btnRegister.TabIndex = 9;
            btnRegister.Text = "&ចុះឈ្មោះ";
            btnRegister.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Khmer OS Battambang", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogin.Location = new Point(103, 263);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(119, 30);
            btnLogin.TabIndex = 8;
            btnLogin.Text = "&ចូលប្រើ";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Khmer OS Battambang", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(103, 213);
            textBox1.Name = "textBox1";
            textBox1.PasswordChar = '*';
            textBox1.PlaceholderText = "បញ្ជាក់លេខសម្ងាត់";
            textBox1.Size = new Size(238, 30);
            textBox1.TabIndex = 12;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Khmer OS Battambang", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(103, 141);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "អ៊ីមែល";
            textBox2.Size = new Size(238, 30);
            textBox2.TabIndex = 6;
            // 
            // UserRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(457, 354);
            ControlBox = false;
            Controls.Add(textBox1);
            Controls.Add(lblLogin);
            Controls.Add(linkForgetPassword);
            Controls.Add(txtPassword);
            Controls.Add(textBox2);
            Controls.Add(txtUsername);
            Controls.Add(btnRegister);
            Controls.Add(btnLogin);
            FormBorderStyle = FormBorderStyle.None;
            MinimizeBox = false;
            Name = "UserRegister";
            ShowInTaskbar = false;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserRegister";
            TransparencyKey = Color.Lime;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLogin;
        private LinkLabel linkForgetPassword;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Button btnRegister;
        private Button btnLogin;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}