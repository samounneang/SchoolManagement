namespace SchoolManagement.Views
{
    partial class StudentDashboard
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
            maskedTextBox1 = new MaskedTextBox();
            maskedTextBox2 = new MaskedTextBox();
            maskedTextBox5 = new MaskedTextBox();
            maskedTextBox6 = new MaskedTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            comboBox1 = new ComboBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(201, 129);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(133, 23);
            maskedTextBox1.TabIndex = 0;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(201, 169);
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(133, 23);
            maskedTextBox2.TabIndex = 1;
            // 
            // maskedTextBox5
            // 
            maskedTextBox5.Location = new Point(470, 129);
            maskedTextBox5.Mask = "(999) 000-0000";
            maskedTextBox5.Name = "maskedTextBox5";
            maskedTextBox5.Size = new Size(133, 23);
            maskedTextBox5.TabIndex = 3;
            // 
            // maskedTextBox6
            // 
            maskedTextBox6.Location = new Point(470, 169);
            maskedTextBox6.Name = "maskedTextBox6";
            maskedTextBox6.Size = new Size(133, 23);
            maskedTextBox6.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(136, 137);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 1;
            label1.Text = "StudentID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(136, 177);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(136, 225);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 1;
            label3.Text = "Gender";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(405, 137);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 1;
            label5.Text = "Phone";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(405, 177);
            label6.Name = "label6";
            label6.Size = new Size(49, 15);
            label6.TabIndex = 1;
            label6.Text = "Address";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Male", "Female" });
            comboBox1.Location = new Point(202, 226);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(132, 23);
            comboBox1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(205, 282);
            button1.Name = "button1";
            button1.Size = new Size(129, 42);
            button1.TabIndex = 3;
            button1.Text = "&Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // StudentDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(maskedTextBox2);
            Controls.Add(maskedTextBox6);
            Controls.Add(maskedTextBox5);
            Controls.Add(maskedTextBox1);
            Name = "StudentDashboard";
            Text = "StudentDashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox maskedTextBox1;
        private MaskedTextBox maskedTextBox2;
        private MaskedTextBox maskedTextBox5;
        private MaskedTextBox maskedTextBox6;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private ComboBox comboBox1;
        private Button button1;
    }
}