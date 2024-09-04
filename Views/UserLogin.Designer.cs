namespace SchoolManagement.Views
{
    partial class UserLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserLogin));
            btnLogin = new Button();
            btnRegister = new Button();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            linkForgetPassword = new LinkLabel();
            lblLogin = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.BackgroundImage = (Image)resources.GetObject("btnLogin.BackgroundImage");
            btnLogin.BackgroundImageLayout = ImageLayout.Stretch;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Khmer OS Battambang", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = SystemColors.ButtonHighlight;
            btnLogin.Location = new Point(100, 221);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(119, 30);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "ចូលប្រើ";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += button1_Click;
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Khmer OS Battambang", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegister.Location = new Point(225, 221);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(113, 30);
            btnRegister.TabIndex = 3;
            btnRegister.Text = "ចុះឈ្មោះ";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += button2_Click;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Khmer OS Battambang", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(100, 126);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "ឈ្មោះអ្នកប្រើ";
            txtUsername.Size = new Size(238, 30);
            txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Khmer OS Battambang", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(100, 162);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "លេខសម្ងាត់";
            txtPassword.Size = new Size(238, 30);
            txtPassword.TabIndex = 1;
            // 
            // linkForgetPassword
            // 
            linkForgetPassword.AutoSize = true;
            linkForgetPassword.Font = new Font("Khmer OS Battambang", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkForgetPassword.Location = new Point(168, 291);
            linkForgetPassword.Name = "linkForgetPassword";
            linkForgetPassword.Size = new Size(97, 22);
            linkForgetPassword.TabIndex = 4;
            linkForgetPassword.TabStop = true;
            linkForgetPassword.Text = " ភ្លេចលេខសម្ងាត់?";
            linkForgetPassword.LinkClicked += linkForgetPassword_LinkClicked;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Khmer OS Content", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.Location = new Point(132, 60);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(171, 31);
            lblLogin.TabIndex = 5;
            lblLogin.Text = "ប្រព័ន្ធគ្របគ្រងសាលា";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // UserLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(457, 354);
            ControlBox = false;
            Controls.Add(lblLogin);
            Controls.Add(linkForgetPassword);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(btnRegister);
            Controls.Add(btnLogin);
            FormBorderStyle = FormBorderStyle.None;
            MinimizeBox = false;
            Name = "UserLogin";
            ShowInTaskbar = false;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserLogin";
            TransparencyKey = Color.Lime;
            Load += LoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private Button btnRegister;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private LinkLabel linkForgetPassword;
        private Label lblLogin;
        private PictureBox pictureBox1;
    }
}