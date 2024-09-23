using SchoolManagement.CustomControl;
using System.Drawing.Drawing2D;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panelMenu = new Panel();
            AllMenuItems = new Panel();
            EmployeeMenu = new MyButton();
            SettingMenu = new MyButton();
            ReportMenu = new MyButton();
            LibraryMenu = new MyButton();
            ParentsMenu = new MyButton();
            InstructorMenuItem = new Panel();
            InstructorMenu = new MyButton();
            StudentMenuItem = new Panel();
            subMenu4 = new subMenu();
            subMenu3 = new subMenu();
            subMenu2 = new subMenu();
            subMenu1 = new subMenu();
            StudentMenu = new MyButton();
            DashboardMenu = new MyButton();
            panel3 = new Panel();
            lblBrand = new Label();
            panelHeader = new Panel();
            label1 = new Label();
            circularPictureBox1 = new CircularPictureBox();
            pictureBox2 = new PictureBox();
            miniMenu = new PictureBox();
            panel1 = new Panel();
            PanelBody = new Panel();
            dataGridView1 = new DataGridView();
            panel4 = new Panel();
            panel8 = new Panel();
            label7 = new Label();
            label6 = new Label();
            panel7 = new Panel();
            label5 = new Label();
            label4 = new Label();
            panel6 = new Panel();
            label3 = new Label();
            lblTotalStudent = new Label();
            panelMenu.SuspendLayout();
            AllMenuItems.SuspendLayout();
            StudentMenuItem.SuspendLayout();
            panel3.SuspendLayout();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)circularPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)miniMenu).BeginInit();
            panel1.SuspendLayout();
            PanelBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel4.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = SystemColors.Control;
            panelMenu.Controls.Add(AllMenuItems);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(151, 555);
            panelMenu.TabIndex = 2;
            // 
            // AllMenuItems
            // 
            AllMenuItems.BackColor = SystemColors.ButtonHighlight;
            AllMenuItems.Controls.Add(EmployeeMenu);
            AllMenuItems.Controls.Add(SettingMenu);
            AllMenuItems.Controls.Add(ReportMenu);
            AllMenuItems.Controls.Add(LibraryMenu);
            AllMenuItems.Controls.Add(ParentsMenu);
            AllMenuItems.Controls.Add(InstructorMenuItem);
            AllMenuItems.Controls.Add(InstructorMenu);
            AllMenuItems.Controls.Add(StudentMenuItem);
            AllMenuItems.Controls.Add(StudentMenu);
            AllMenuItems.Controls.Add(DashboardMenu);
            AllMenuItems.Controls.Add(panel3);
            AllMenuItems.Dock = DockStyle.Fill;
            AllMenuItems.Location = new Point(0, 0);
            AllMenuItems.Name = "AllMenuItems";
            AllMenuItems.Size = new Size(151, 555);
            AllMenuItems.TabIndex = 1;
            // 
            // EmployeeMenu
            // 
            EmployeeMenu.BackgroundImage = (Image)resources.GetObject("EmployeeMenu.BackgroundImage");
            EmployeeMenu.BackgroundImageLayout = ImageLayout.Stretch;
            EmployeeMenu.Dock = DockStyle.Top;
            EmployeeMenu.FlatAppearance.BorderSize = 0;
            EmployeeMenu.FlatStyle = FlatStyle.Flat;
            EmployeeMenu.Location = new Point(0, 515);
            EmployeeMenu.Name = "EmployeeMenu";
            EmployeeMenu.Size = new Size(151, 37);
            EmployeeMenu.TabIndex = 6;
            EmployeeMenu.Text = " ";
            EmployeeMenu.UseVisualStyleBackColor = true;
            EmployeeMenu.Click += EmployeeMenu_Click;
            // 
            // SettingMenu
            // 
            SettingMenu.BackgroundImage = (Image)resources.GetObject("SettingMenu.BackgroundImage");
            SettingMenu.BackgroundImageLayout = ImageLayout.Stretch;
            SettingMenu.Dock = DockStyle.Top;
            SettingMenu.FlatAppearance.BorderSize = 0;
            SettingMenu.FlatStyle = FlatStyle.Flat;
            SettingMenu.Location = new Point(0, 483);
            SettingMenu.Name = "SettingMenu";
            SettingMenu.Size = new Size(151, 32);
            SettingMenu.TabIndex = 9;
            SettingMenu.Text = " ";
            SettingMenu.UseVisualStyleBackColor = true;
            // 
            // ReportMenu
            // 
            ReportMenu.BackgroundImage = (Image)resources.GetObject("ReportMenu.BackgroundImage");
            ReportMenu.BackgroundImageLayout = ImageLayout.Stretch;
            ReportMenu.Dock = DockStyle.Top;
            ReportMenu.FlatAppearance.BorderSize = 0;
            ReportMenu.FlatStyle = FlatStyle.Flat;
            ReportMenu.Location = new Point(0, 451);
            ReportMenu.Name = "ReportMenu";
            ReportMenu.Size = new Size(151, 32);
            ReportMenu.TabIndex = 8;
            ReportMenu.Text = " ";
            ReportMenu.UseVisualStyleBackColor = true;
            ReportMenu.Click += myButton6_Click;
            // 
            // LibraryMenu
            // 
            LibraryMenu.BackgroundImage = (Image)resources.GetObject("LibraryMenu.BackgroundImage");
            LibraryMenu.BackgroundImageLayout = ImageLayout.Stretch;
            LibraryMenu.Dock = DockStyle.Top;
            LibraryMenu.FlatAppearance.BorderSize = 0;
            LibraryMenu.FlatStyle = FlatStyle.Flat;
            LibraryMenu.Location = new Point(0, 417);
            LibraryMenu.Name = "LibraryMenu";
            LibraryMenu.Size = new Size(151, 34);
            LibraryMenu.TabIndex = 7;
            LibraryMenu.Text = " ";
            LibraryMenu.UseVisualStyleBackColor = true;
            // 
            // ParentsMenu
            // 
            ParentsMenu.BackgroundImage = (Image)resources.GetObject("ParentsMenu.BackgroundImage");
            ParentsMenu.BackgroundImageLayout = ImageLayout.Stretch;
            ParentsMenu.Dock = DockStyle.Top;
            ParentsMenu.FlatAppearance.BorderSize = 0;
            ParentsMenu.FlatStyle = FlatStyle.Flat;
            ParentsMenu.Location = new Point(0, 382);
            ParentsMenu.Name = "ParentsMenu";
            ParentsMenu.Size = new Size(151, 35);
            ParentsMenu.TabIndex = 5;
            ParentsMenu.Text = " ";
            ParentsMenu.UseVisualStyleBackColor = true;
            // 
            // InstructorMenuItem
            // 
            InstructorMenuItem.BackColor = SystemColors.ButtonHighlight;
            InstructorMenuItem.Dock = DockStyle.Top;
            InstructorMenuItem.Location = new Point(0, 280);
            InstructorMenuItem.Name = "InstructorMenuItem";
            InstructorMenuItem.Size = new Size(151, 102);
            InstructorMenuItem.TabIndex = 4;
            InstructorMenuItem.Paint += InstructorMenuItem_Paint;
            // 
            // InstructorMenu
            // 
            InstructorMenu.BackgroundImage = (Image)resources.GetObject("InstructorMenu.BackgroundImage");
            InstructorMenu.BackgroundImageLayout = ImageLayout.Stretch;
            InstructorMenu.Cursor = Cursors.Hand;
            InstructorMenu.Dock = DockStyle.Top;
            InstructorMenu.FlatAppearance.BorderSize = 0;
            InstructorMenu.FlatStyle = FlatStyle.Flat;
            InstructorMenu.Location = new Point(0, 245);
            InstructorMenu.Name = "InstructorMenu";
            InstructorMenu.Size = new Size(151, 35);
            InstructorMenu.TabIndex = 3;
            InstructorMenu.Text = " ";
            InstructorMenu.UseVisualStyleBackColor = true;
            InstructorMenu.Click += myButton3_Click;
            // 
            // StudentMenuItem
            // 
            StudentMenuItem.BackColor = SystemColors.ButtonFace;
            StudentMenuItem.Controls.Add(subMenu4);
            StudentMenuItem.Controls.Add(subMenu3);
            StudentMenuItem.Controls.Add(subMenu2);
            StudentMenuItem.Controls.Add(subMenu1);
            StudentMenuItem.Dock = DockStyle.Top;
            StudentMenuItem.Location = new Point(0, 112);
            StudentMenuItem.Name = "StudentMenuItem";
            StudentMenuItem.Size = new Size(151, 133);
            StudentMenuItem.TabIndex = 1;
            // 
            // subMenu4
            // 
            subMenu4.BackColor = SystemColors.ButtonHighlight;
            subMenu4.Dock = DockStyle.Top;
            subMenu4.FlatAppearance.BorderSize = 0;
            subMenu4.FlatStyle = FlatStyle.Flat;
            subMenu4.Location = new Point(0, 100);
            subMenu4.Name = "subMenu4";
            subMenu4.Padding = new Padding(0, 0, 10, 0);
            subMenu4.Size = new Size(151, 33);
            subMenu4.TabIndex = 3;
            subMenu4.Text = "              Grades and Results";
            subMenu4.TextAlign = ContentAlignment.MiddleLeft;
            subMenu4.UseVisualStyleBackColor = false;
            // 
            // subMenu3
            // 
            subMenu3.BackColor = SystemColors.ButtonHighlight;
            subMenu3.Dock = DockStyle.Top;
            subMenu3.FlatAppearance.BorderSize = 0;
            subMenu3.FlatStyle = FlatStyle.Flat;
            subMenu3.Location = new Point(0, 67);
            subMenu3.Name = "subMenu3";
            subMenu3.Padding = new Padding(0, 0, 10, 0);
            subMenu3.Size = new Size(151, 33);
            subMenu3.TabIndex = 2;
            subMenu3.Text = "              Attendance";
            subMenu3.TextAlign = ContentAlignment.MiddleLeft;
            subMenu3.UseVisualStyleBackColor = false;
            // 
            // subMenu2
            // 
            subMenu2.BackColor = SystemColors.ButtonHighlight;
            subMenu2.Dock = DockStyle.Top;
            subMenu2.FlatAppearance.BorderSize = 0;
            subMenu2.FlatStyle = FlatStyle.Flat;
            subMenu2.Location = new Point(0, 34);
            subMenu2.Name = "subMenu2";
            subMenu2.Padding = new Padding(0, 0, 10, 0);
            subMenu2.Size = new Size(151, 33);
            subMenu2.TabIndex = 1;
            subMenu2.Text = "              Student list";
            subMenu2.TextAlign = ContentAlignment.MiddleLeft;
            subMenu2.UseVisualStyleBackColor = false;
            subMenu2.Click += subMenu2_Click;
            // 
            // subMenu1
            // 
            subMenu1.BackColor = SystemColors.ButtonHighlight;
            subMenu1.Dock = DockStyle.Top;
            subMenu1.FlatAppearance.BorderSize = 0;
            subMenu1.FlatStyle = FlatStyle.Flat;
            subMenu1.Location = new Point(0, 0);
            subMenu1.Name = "subMenu1";
            subMenu1.Padding = new Padding(0, 0, 10, 0);
            subMenu1.Size = new Size(151, 34);
            subMenu1.TabIndex = 0;
            subMenu1.Text = "               Register";
            subMenu1.TextAlign = ContentAlignment.MiddleLeft;
            subMenu1.UseVisualStyleBackColor = false;
            subMenu1.Click += subMenu1_Click;
            // 
            // StudentMenu
            // 
            StudentMenu.BackColor = SystemColors.Control;
            StudentMenu.BackgroundImage = (Image)resources.GetObject("StudentMenu.BackgroundImage");
            StudentMenu.BackgroundImageLayout = ImageLayout.Stretch;
            StudentMenu.Dock = DockStyle.Top;
            StudentMenu.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 1, 0);
            StudentMenu.FlatStyle = FlatStyle.Flat;
            StudentMenu.Location = new Point(0, 79);
            StudentMenu.Name = "StudentMenu";
            StudentMenu.Size = new Size(151, 33);
            StudentMenu.TabIndex = 1;
            StudentMenu.Text = " \r\n";
            StudentMenu.TextImageRelation = TextImageRelation.ImageAboveText;
            StudentMenu.UseVisualStyleBackColor = false;
            StudentMenu.Click += myButton2_Click;
            // 
            // DashboardMenu
            // 
            DashboardMenu.BackColor = Color.Transparent;
            DashboardMenu.BackgroundImage = (Image)resources.GetObject("DashboardMenu.BackgroundImage");
            DashboardMenu.BackgroundImageLayout = ImageLayout.Stretch;
            DashboardMenu.Dock = DockStyle.Top;
            DashboardMenu.FlatAppearance.BorderSize = 0;
            DashboardMenu.FlatStyle = FlatStyle.Flat;
            DashboardMenu.Location = new Point(0, 48);
            DashboardMenu.Name = "DashboardMenu";
            DashboardMenu.Size = new Size(151, 31);
            DashboardMenu.TabIndex = 0;
            DashboardMenu.Text = " ";
            DashboardMenu.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.Controls.Add(lblBrand);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(151, 48);
            panel3.TabIndex = 0;
            // 
            // lblBrand
            // 
            lblBrand.AutoSize = true;
            lblBrand.BackColor = Color.Transparent;
            lblBrand.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblBrand.ForeColor = Color.White;
            lblBrand.Location = new Point(3, 12);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(122, 21);
            lblBrand.TabIndex = 0;
            lblBrand.Text = "Traning Center";
            lblBrand.Click += label1_Click;
            // 
            // panelHeader
            // 
            panelHeader.BackgroundImage = (Image)resources.GetObject("panelHeader.BackgroundImage");
            panelHeader.Controls.Add(label1);
            panelHeader.Controls.Add(circularPictureBox1);
            panelHeader.Controls.Add(pictureBox2);
            panelHeader.Controls.Add(miniMenu);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(151, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(776, 48);
            panelHeader.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(648, 15);
            label1.Name = "label1";
            label1.Size = new Size(48, 19);
            label1.TabIndex = 3;
            label1.Text = "Jacob";
            // 
            // circularPictureBox1
            // 
            circularPictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            circularPictureBox1.BackColor = Color.Transparent;
            circularPictureBox1.Image = (Image)resources.GetObject("circularPictureBox1.Image");
            circularPictureBox1.Location = new Point(612, 12);
            circularPictureBox1.Name = "circularPictureBox1";
            circularPictureBox1.Size = new Size(30, 30);
            circularPictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            circularPictureBox1.TabIndex = 2;
            circularPictureBox1.TabStop = false;
            circularPictureBox1.Click += circularPictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(719, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(31, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // miniMenu
            // 
            miniMenu.BackColor = Color.Transparent;
            miniMenu.Image = (Image)resources.GetObject("miniMenu.Image");
            miniMenu.Location = new Point(11, 9);
            miniMenu.Name = "miniMenu";
            miniMenu.Size = new Size(25, 30);
            miniMenu.SizeMode = PictureBoxSizeMode.StretchImage;
            miniMenu.TabIndex = 1;
            miniMenu.TabStop = false;
            miniMenu.Click += miniMenu_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(PanelBody);
            panel1.Controls.Add(panel4);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(151, 48);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 507);
            panel1.TabIndex = 2;
            // 
            // PanelBody
            // 
            PanelBody.Controls.Add(dataGridView1);
            PanelBody.Dock = DockStyle.Fill;
            PanelBody.Location = new Point(0, 162);
            PanelBody.Name = "PanelBody";
            PanelBody.Size = new Size(776, 345);
            PanelBody.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(776, 345);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ButtonHighlight;
            panel4.Controls.Add(panel8);
            panel4.Controls.Add(panel7);
            panel4.Controls.Add(panel6);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(776, 162);
            panel4.TabIndex = 0;
            // 
            // panel8
            // 
            panel8.BackgroundImage = (Image)resources.GetObject("panel8.BackgroundImage");
            panel8.BackgroundImageLayout = ImageLayout.Stretch;
            panel8.Controls.Add(label7);
            panel8.Controls.Add(label6);
            panel8.Location = new Point(521, 6);
            panel8.Name = "panel8";
            panel8.Size = new Size(214, 138);
            panel8.TabIndex = 0;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label7.Location = new Point(49, 76);
            label7.Name = "label7";
            label7.Size = new Size(131, 25);
            label7.TabIndex = 0;
            label7.Text = "Total Student";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label6.Location = new Point(87, 26);
            label6.Name = "label6";
            label6.Size = new Size(45, 25);
            label6.TabIndex = 0;
            label6.Text = "200";
            // 
            // panel7
            // 
            panel7.BackgroundImage = (Image)resources.GetObject("panel7.BackgroundImage");
            panel7.BackgroundImageLayout = ImageLayout.Stretch;
            panel7.Controls.Add(label5);
            panel7.Controls.Add(label4);
            panel7.Location = new Point(290, 6);
            panel7.Name = "panel7";
            panel7.Size = new Size(214, 138);
            panel7.TabIndex = 0;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label5.Location = new Point(45, 83);
            label5.Name = "label5";
            label5.Size = new Size(131, 25);
            label5.TabIndex = 0;
            label5.Text = "Total Student";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label4.Location = new Point(83, 33);
            label4.Name = "label4";
            label4.Size = new Size(45, 25);
            label4.TabIndex = 0;
            label4.Text = "200";
            // 
            // panel6
            // 
            panel6.BackgroundImage = (Image)resources.GetObject("panel6.BackgroundImage");
            panel6.BackgroundImageLayout = ImageLayout.Stretch;
            panel6.Controls.Add(label3);
            panel6.Controls.Add(lblTotalStudent);
            panel6.Location = new Point(38, 6);
            panel6.Name = "panel6";
            panel6.Size = new Size(214, 138);
            panel6.TabIndex = 0;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label3.Location = new Point(43, 83);
            label3.Name = "label3";
            label3.Size = new Size(131, 25);
            label3.TabIndex = 0;
            label3.Text = "Total Student";
            // 
            // lblTotalStudent
            // 
            lblTotalStudent.AccessibleRole = AccessibleRole.TitleBar;
            lblTotalStudent.Anchor = AnchorStyles.Top;
            lblTotalStudent.AutoSize = true;
            lblTotalStudent.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTotalStudent.Location = new Point(81, 33);
            lblTotalStudent.Name = "lblTotalStudent";
            lblTotalStudent.Size = new Size(45, 25);
            lblTotalStudent.TabIndex = 0;
            lblTotalStudent.Text = "200";
            lblTotalStudent.Click += lblTotalStudent_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(927, 555);
            Controls.Add(panel1);
            Controls.Add(panelHeader);
            Controls.Add(panelMenu);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            panelMenu.ResumeLayout(false);
            AllMenuItems.ResumeLayout(false);
            StudentMenuItem.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)circularPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)miniMenu).EndInit();
            panel1.ResumeLayout(false);
            PanelBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel4.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panelHeader;
        private Panel panel1;
        private PictureBox miniMenu;
        private PictureBox pictureBox2;
        private Label lblBrand;
        private Panel AllMenuItems;
        private Panel panel3;
        private CustomControl.MyButton StudentMenu;
        private CustomControl.MyButton DashboardMenu;
        private Panel StudentMenuItem;
        private Panel PanelBody;
        private DataGridView dataGridView1;
        private Panel panel4;
        private CustomControl.subMenu subMenu3;
        private CustomControl.subMenu subMenu2;
        private CustomControl.subMenu subMenu1;
        private CustomControl.CircularPictureBox circularPictureBox1;
        private Label label1;
        private Panel InstructorMenuItem;
        private MyButton InstructorMenu;
        private MyButton LibraryMenu;
        private MyButton ParentsMenu;
        private MyButton SettingMenu;
        private MyButton ReportMenu;
        private Panel panel6;
        private Panel panel8;
        private Panel panel7;
        private Label label3;
        private Label lblTotalStudent;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private MyButton EmployeeMenu;
        private subMenu subMenu4;
    }
}