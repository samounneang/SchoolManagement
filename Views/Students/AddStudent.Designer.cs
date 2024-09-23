namespace SchoolManagement.Views.Students
{
    partial class AddStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStudent));
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            comboBox1 = new ComboBox();
            dateTimePicker2 = new DateTimePicker();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            btnBrowseImg = new Button();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(226, 137);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(121, 23);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(137, 145);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 1;
            label1.Text = "Student ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(116, 199);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 3;
            label2.Text = "Student Name";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(226, 196);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(121, 23);
            textBox2.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(92, 90);
            label3.Name = "label3";
            label3.Size = new Size(107, 15);
            label3.TabIndex = 5;
            label3.Text = "AdmissionNumber";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(226, 87);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(121, 23);
            textBox3.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(119, 298);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 7;
            label4.Text = "DateOfBirth";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(226, 290);
            dateTimePicker1.MinDate = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(125, 23);
            dateTimePicker1.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(152, 254);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 9;
            label5.Text = "Gender";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Male", "Female" });
            comboBox1.Location = new Point(226, 246);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 10;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(226, 342);
            dateTimePicker2.MinDate = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(125, 23);
            dateTimePicker2.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(99, 350);
            label6.Name = "label6";
            label6.Size = new Size(89, 15);
            label6.TabIndex = 11;
            label6.Text = "EnrollmentDate";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(485, 72);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(104, 108);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btnBrowseImg
            // 
            btnBrowseImg.Location = new Point(609, 72);
            btnBrowseImg.Name = "btnBrowseImg";
            btnBrowseImg.Size = new Size(75, 23);
            btnBrowseImg.TabIndex = 14;
            btnBrowseImg.Text = "Browse";
            btnBrowseImg.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(485, 342);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 15;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // AddStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSave);
            Controls.Add(btnBrowseImg);
            Controls.Add(pictureBox1);
            Controls.Add(dateTimePicker2);
            Controls.Add(label6);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(dateTimePicker1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddStudent";
            Text = "AddStudent";
            Load += AddStudent_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private Label label5;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker2;
        private Label label6;
        private PictureBox pictureBox1;
        private Button btnBrowseImg;
        private Button btnSave;
    }
}