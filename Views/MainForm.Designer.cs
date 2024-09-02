namespace SchoolManagement.Views
{
    partial class MainForm
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
            panelDropdown = new Panel();
            subMenu5 = new CustomControl.subMenu();
            subMenu4 = new CustomControl.subMenu();
            subMenu3 = new CustomControl.subMenu();
            subMenu2 = new CustomControl.subMenu();
            subMenu1 = new CustomControl.subMenu();
            Master = new Button();
            panel2 = new Panel();
            label3 = new Label();
            button1 = new Button();
            label1 = new Label();
            panel3 = new Panel();
            button2 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel4 = new Panel();
            totalStudent = new Label();
            label2 = new Label();
            panel5 = new Panel();
            panel6 = new Panel();
            panel1.SuspendLayout();
            panelDropdown.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panelDropdown);
            panel1.Controls.Add(Master);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(151, 450);
            panel1.TabIndex = 1;
            // 
            // panelDropdown
            // 
            panelDropdown.BackColor = SystemColors.ActiveCaption;
            panelDropdown.Controls.Add(subMenu5);
            panelDropdown.Controls.Add(subMenu4);
            panelDropdown.Controls.Add(subMenu3);
            panelDropdown.Controls.Add(subMenu2);
            panelDropdown.Controls.Add(subMenu1);
            panelDropdown.Dock = DockStyle.Top;
            panelDropdown.Location = new Point(0, 44);
            panelDropdown.Name = "panelDropdown";
            panelDropdown.Size = new Size(151, 119);
            panelDropdown.TabIndex = 5;
            // 
            // subMenu5
            // 
            subMenu5.Dock = DockStyle.Top;
            subMenu5.FlatAppearance.BorderSize = 0;
            subMenu5.FlatStyle = FlatStyle.Flat;
            subMenu5.Location = new Point(0, 92);
            subMenu5.Name = "subMenu5";
            subMenu5.Padding = new Padding(0, 0, 10, 0);
            subMenu5.Size = new Size(151, 23);
            subMenu5.TabIndex = 4;
            subMenu5.Text = "subMenu5";
            subMenu5.TextAlign = ContentAlignment.MiddleRight;
            subMenu5.UseVisualStyleBackColor = true;
            subMenu5.Click += subMenu5_Click;
            // 
            // subMenu4
            // 
            subMenu4.Dock = DockStyle.Top;
            subMenu4.FlatAppearance.BorderSize = 0;
            subMenu4.FlatStyle = FlatStyle.Flat;
            subMenu4.Location = new Point(0, 69);
            subMenu4.Name = "subMenu4";
            subMenu4.Padding = new Padding(0, 0, 10, 0);
            subMenu4.Size = new Size(151, 23);
            subMenu4.TabIndex = 3;
            subMenu4.Text = "subMenu4";
            subMenu4.TextAlign = ContentAlignment.MiddleRight;
            subMenu4.UseVisualStyleBackColor = true;
            subMenu4.Click += subMenu4_Click;
            // 
            // subMenu3
            // 
            subMenu3.Dock = DockStyle.Top;
            subMenu3.FlatAppearance.BorderSize = 0;
            subMenu3.FlatStyle = FlatStyle.Flat;
            subMenu3.Location = new Point(0, 46);
            subMenu3.Name = "subMenu3";
            subMenu3.Padding = new Padding(0, 0, 10, 0);
            subMenu3.Size = new Size(151, 23);
            subMenu3.TabIndex = 2;
            subMenu3.Text = "subMenu3";
            subMenu3.TextAlign = ContentAlignment.MiddleRight;
            subMenu3.UseVisualStyleBackColor = true;
            subMenu3.Click += subMenu3_Click;
            // 
            // subMenu2
            // 
            subMenu2.Dock = DockStyle.Top;
            subMenu2.FlatAppearance.BorderSize = 0;
            subMenu2.FlatStyle = FlatStyle.Flat;
            subMenu2.Location = new Point(0, 23);
            subMenu2.Name = "subMenu2";
            subMenu2.Padding = new Padding(0, 0, 10, 0);
            subMenu2.Size = new Size(151, 23);
            subMenu2.TabIndex = 1;
            subMenu2.Text = "subMenu2";
            subMenu2.TextAlign = ContentAlignment.MiddleRight;
            subMenu2.UseVisualStyleBackColor = true;
            subMenu2.Click += subMenu2_Click;
            // 
            // subMenu1
            // 
            subMenu1.Dock = DockStyle.Top;
            subMenu1.FlatAppearance.BorderSize = 0;
            subMenu1.FlatStyle = FlatStyle.Flat;
            subMenu1.Location = new Point(0, 0);
            subMenu1.Name = "subMenu1";
            subMenu1.Padding = new Padding(0, 0, 10, 0);
            subMenu1.Size = new Size(151, 23);
            subMenu1.TabIndex = 0;
            subMenu1.Text = "subMenu1";
            subMenu1.TextAlign = ContentAlignment.MiddleRight;
            subMenu1.UseVisualStyleBackColor = true;
            subMenu1.Click += subMenu1_Click;
            // 
            // Master
            // 
            Master.Dock = DockStyle.Top;
            Master.FlatStyle = FlatStyle.Flat;
            Master.Location = new Point(0, 0);
            Master.Name = "Master";
            Master.Size = new Size(151, 44);
            Master.TabIndex = 4;
            Master.Text = "Master";
            Master.UseVisualStyleBackColor = true;
            Master.Click += Master_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.GradientActiveCaption;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(151, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(649, 41);
            panel2.TabIndex = 0;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(475, 15);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 2;
            label3.Text = "User: Lok Lak";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.Location = new Point(562, 11);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Log out";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 12);
            label1.Name = "label1";
            label1.Size = new Size(119, 15);
            label1.TabIndex = 0;
            label1.Text = "Branch: Phnom penh";
            // 
            // panel3
            // 
            panel3.Controls.Add(button2);
            panel3.Controls.Add(flowLayoutPanel1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(151, 41);
            panel3.Name = "panel3";
            panel3.Size = new Size(649, 409);
            panel3.TabIndex = 2;
            // 
            // button2
            // 
            button2.Location = new Point(9, 124);
            button2.Name = "button2";
            button2.Size = new Size(187, 70);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(panel4);
            flowLayoutPanel1.Controls.Add(panel5);
            flowLayoutPanel1.Controls.Add(panel6);
            flowLayoutPanel1.Location = new Point(6, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(640, 115);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.InactiveBorder;
            panel4.Controls.Add(totalStudent);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(167, 112);
            panel4.TabIndex = 0;
            // 
            // totalStudent
            // 
            totalStudent.AutoSize = true;
            totalStudent.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            totalStudent.Location = new Point(41, 43);
            totalStudent.Name = "totalStudent";
            totalStudent.Size = new Size(33, 37);
            totalStudent.TabIndex = 1;
            totalStudent.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 20);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 0;
            label2.Text = "Total Student:";
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.InactiveBorder;
            panel5.Location = new Point(176, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(167, 112);
            panel5.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.InactiveBorder;
            panel6.Location = new Point(349, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(167, 112);
            panel6.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            Shown += MainForm_Shown;
            panel1.ResumeLayout(false);
            panelDropdown.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        private Panel panel1;
        private Panel panelDropdown;
        private CustomControl.subMenu subMenu5;
        private CustomControl.subMenu subMenu4;
        private CustomControl.subMenu subMenu3;
        private CustomControl.subMenu subMenu2;
        private CustomControl.subMenu subMenu1;
        private Button Master;
        private Panel panel2;
        private Button button1;
        private Label label1;
        private Panel panel3;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel4;
        private Label totalStudent;
        private Label label2;
        private Panel panel5;
        private Panel panel6;
        private Button button2;
        private Label label3;

        #endregion
        // private Components.Navbar navbar1;
    }
}