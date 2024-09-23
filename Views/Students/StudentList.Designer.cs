namespace SchoolManagement.Views.Students
{
    partial class StudentList
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
            panel1 = new Panel();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            btnAddStudent = new Button();
            StudentID = new DataGridViewTextBoxColumn();
            StudentName = new DataGridViewTextBoxColumn();
            Gender = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            Contact = new DataGridViewTextBoxColumn();
            Action = new DataGridViewButtonColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnAddStudent);
            panel1.Controls.Add(textBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 94);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 94);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 356);
            panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { StudentID, StudentName, Gender, Address, Contact, Action });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(800, 356);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 52);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Search by ID";
            textBox1.Size = new Size(192, 23);
            textBox1.TabIndex = 0;
            // 
            // btnAddStudent
            // 
            btnAddStudent.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddStudent.Location = new Point(615, 44);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(100, 31);
            btnAddStudent.TabIndex = 1;
            btnAddStudent.Text = "Add New";
            btnAddStudent.UseVisualStyleBackColor = true;
            // 
            // StudentID
            // 
            StudentID.HeaderText = "StudentID";
            StudentID.Name = "StudentID";
            StudentID.ReadOnly = true;
            // 
            // StudentName
            // 
            StudentName.HeaderText = "Student Name";
            StudentName.Name = "StudentName";
            StudentName.ReadOnly = true;
            // 
            // Gender
            // 
            Gender.HeaderText = "Gender";
            Gender.Name = "Gender";
            Gender.ReadOnly = true;
            // 
            // Address
            // 
            Address.HeaderText = "Address";
            Address.Name = "Address";
            Address.ReadOnly = true;
            // 
            // Contact
            // 
            Contact.HeaderText = "Contact";
            Contact.Name = "Contact";
            Contact.ReadOnly = true;
            // 
            // Action
            // 
            Action.HeaderText = "Action";
            Action.Name = "Action";
            Action.ReadOnly = true;
            Action.Resizable = DataGridViewTriState.True;
            Action.SortMode = DataGridViewColumnSortMode.Automatic;
            Action.Text = "Detail";
            Action.ToolTipText = "View student detail";
            // 
            // StudentList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StudentList";
            Text = "StudentList";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Button btnAddStudent;
        private DataGridViewTextBoxColumn StudentID;
        private DataGridViewTextBoxColumn StudentName;
        private DataGridViewTextBoxColumn Gender;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn Contact;
        private DataGridViewButtonColumn Action;
    }
}