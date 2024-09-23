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
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            btnRegister = new Button();
            btnLogin = new Button();
            txtConPassword = new TextBox();
            txtEmail = new TextBox();
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
            // txtPassword
            // 
            txtPassword.Font = new Font("Khmer OS Battambang", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(103, 177);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "លេខសម្ងាត់";
            txtPassword.Size = new Size(238, 30);
            txtPassword.TabIndex = 2;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Khmer OS Battambang", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(103, 104);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "ឈ្មោះអ្នកប្រើ";
            txtUsername.Size = new Size(238, 30);
            txtUsername.TabIndex = 0;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = SystemColors.AppWorkspace;
            btnRegister.Font = new Font("Khmer OS Battambang", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegister.Location = new Point(228, 263);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(113, 30);
            btnRegister.TabIndex = 4;
            btnRegister.Text = "&ចុះឈ្មោះ";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Khmer OS Battambang", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogin.Location = new Point(103, 263);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(119, 30);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "&ចូលប្រើ";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtConPassword
            // 
            txtConPassword.Font = new Font("Khmer OS Battambang", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConPassword.Location = new Point(103, 213);
            txtConPassword.Name = "txtConPassword";
            txtConPassword.PasswordChar = '*';
            txtConPassword.PlaceholderText = "បញ្ជាក់លេខសម្ងាត់";
            txtConPassword.Size = new Size(238, 30);
            txtConPassword.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Khmer OS Battambang", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(103, 141);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "អ៊ីមែល";
            txtEmail.Size = new Size(238, 30);
            txtEmail.TabIndex = 1;
            // 
            // UserRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(457, 354);
            ControlBox = false;
            Controls.Add(txtConPassword);
            Controls.Add(lblLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
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
        protected TextBox txtPassword;
        protected TextBox txtUsername;
        private Button btnRegister;
        private Button btnLogin;
        protected TextBox txtConPassword;
        protected TextBox txtEmail;
    }
}