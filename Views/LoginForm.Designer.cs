namespace SchoolManagement.Views
{
    partial class LoginForm
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
            button1 = new Button();
            button2 = new Button();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            linkForgetPassword = new LinkLabel();
            cboRole = new ComboBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(148, 216);
            button1.Name = "button1";
            button1.Size = new Size(131, 30);
            button1.TabIndex = 2;
            button1.Text = "&Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(285, 216);
            button2.Name = "button2";
            button2.Size = new Size(113, 30);
            button2.TabIndex = 3;
            button2.Text = "&Register";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(150, 102);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(248, 23);
            txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(150, 131);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(248, 23);
            txtPassword.TabIndex = 1;
            // 
            // linkForgetPassword
            // 
            linkForgetPassword.AutoSize = true;
            linkForgetPassword.Location = new Point(218, 286);
            linkForgetPassword.Name = "linkForgetPassword";
            linkForgetPassword.Size = new Size(102, 15);
            linkForgetPassword.TabIndex = 4;
            linkForgetPassword.TabStop = true;
            linkForgetPassword.Text = "Forget password ?";
            // 
            // cboRole
            // 
            cboRole.FormattingEnabled = true;
            cboRole.Items.AddRange(new object[] { "Admin", "Student", "Parent", "Staff" });
            cboRole.Location = new Point(149, 173);
            cboRole.Name = "cboRole";
            cboRole.Size = new Size(249, 23);
            cboRole.TabIndex = 5;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(558, 331);
            Controls.Add(cboRole);
            Controls.Add(linkForgetPassword);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            WindowState = FormWindowState.Maximized;
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private LinkLabel linkForgetPassword;
        private ComboBox cboRole;
    }
}