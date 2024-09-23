namespace SchoolManagement.Views.Component
{
    partial class UserList
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
            btnAddUser = new Button();
            panel1 = new Panel();
            UserGridView = new DataGridView();
            textBox1 = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UserGridView).BeginInit();
            SuspendLayout();
            // 
            // btnAddUser
            // 
            btnAddUser.Location = new Point(517, 54);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(114, 35);
            btnAddUser.TabIndex = 0;
            btnAddUser.Text = "Add User";
            btnAddUser.UseVisualStyleBackColor = true;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(UserGridView);
            panel1.Location = new Point(78, 106);
            panel1.Name = "panel1";
            panel1.Size = new Size(690, 332);
            panel1.TabIndex = 1;
            // 
            // UserGridView
            // 
            UserGridView.BackgroundColor = SystemColors.ButtonHighlight;
            UserGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UserGridView.Dock = DockStyle.Fill;
            UserGridView.Location = new Point(0, 0);
            UserGridView.Name = "UserGridView";
            UserGridView.Size = new Size(690, 332);
            UserGridView.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(80, 63);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Search user";
            textBox1.Size = new Size(145, 23);
            textBox1.TabIndex = 2;
            // 
            // UserList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(textBox1);
            Controls.Add(panel1);
            Controls.Add(btnAddUser);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserList";
            Text = "UserManagement";
            Load += UserList_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)UserGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddUser;
        private Panel panel1;
        private DataGridView UserGridView;
        private TextBox textBox1;
    }
}