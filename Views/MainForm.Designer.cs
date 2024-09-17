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
            panel2 = new Panel();
            myButton7 = new MyButton();
            btnSetting = new MyButton();
            myButton6 = new MyButton();
            myButton5 = new MyButton();
            myButton4 = new MyButton();
            instructordropdown = new Panel();
            myButton3 = new MyButton();
            studentdropdown = new Panel();
            subMenu3 = new subMenu();
            subMenu2 = new subMenu();
            subMenu1 = new subMenu();
            myButton2 = new MyButton();
            myButton1 = new MyButton();
            panel3 = new Panel();
            lblBrand = new Label();
            panelHeader = new Panel();
            label1 = new Label();
            circularPictureBox1 = new CircularPictureBox();
            pictureBox2 = new PictureBox();
            miniMenu = new PictureBox();
            panel1 = new Panel();
            panel5 = new Panel();
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
            panel2.SuspendLayout();
            studentdropdown.SuspendLayout();
            panel3.SuspendLayout();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)circularPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)miniMenu).BeginInit();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
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
            panelMenu.Controls.Add(panel2);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(151, 555);
            panelMenu.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(myButton7);
            panel2.Controls.Add(btnSetting);
            panel2.Controls.Add(myButton6);
            panel2.Controls.Add(myButton5);
            panel2.Controls.Add(myButton4);
            panel2.Controls.Add(instructordropdown);
            panel2.Controls.Add(myButton3);
            panel2.Controls.Add(studentdropdown);
            panel2.Controls.Add(myButton2);
            panel2.Controls.Add(myButton1);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(151, 555);
            panel2.TabIndex = 1;
            // 
            // myButton7
            // 
            myButton7.BackgroundImage = (Image)resources.GetObject("myButton7.BackgroundImage");
            myButton7.BackgroundImageLayout = ImageLayout.Stretch;
            myButton7.Dock = DockStyle.Top;
            myButton7.FlatAppearance.BorderSize = 0;
            myButton7.FlatStyle = FlatStyle.Flat;
            myButton7.Location = new Point(0, 492);
            myButton7.Name = "myButton7";
            myButton7.Size = new Size(151, 37);
            myButton7.TabIndex = 6;
            myButton7.Text = " ";
            myButton7.UseVisualStyleBackColor = true;
            // 
            // btnSetting
            // 
            btnSetting.BackgroundImage = (Image)resources.GetObject("btnSetting.BackgroundImage");
            btnSetting.BackgroundImageLayout = ImageLayout.Stretch;
            btnSetting.Dock = DockStyle.Top;
            btnSetting.FlatAppearance.BorderSize = 0;
            btnSetting.FlatStyle = FlatStyle.Flat;
            btnSetting.Location = new Point(0, 460);
            btnSetting.Name = "btnSetting";
            btnSetting.Size = new Size(151, 32);
            btnSetting.TabIndex = 9;
            btnSetting.Text = " ";
            btnSetting.UseVisualStyleBackColor = true;
            // 
            // myButton6
            // 
            myButton6.BackgroundImage = (Image)resources.GetObject("myButton6.BackgroundImage");
            myButton6.BackgroundImageLayout = ImageLayout.Stretch;
            myButton6.Dock = DockStyle.Top;
            myButton6.FlatAppearance.BorderSize = 0;
            myButton6.FlatStyle = FlatStyle.Flat;
            myButton6.Location = new Point(0, 428);
            myButton6.Name = "myButton6";
            myButton6.Size = new Size(151, 32);
            myButton6.TabIndex = 8;
            myButton6.Text = " ";
            myButton6.UseVisualStyleBackColor = true;
            myButton6.Click += myButton6_Click;
            // 
            // myButton5
            // 
            myButton5.BackgroundImage = (Image)resources.GetObject("myButton5.BackgroundImage");
            myButton5.BackgroundImageLayout = ImageLayout.Stretch;
            myButton5.Dock = DockStyle.Top;
            myButton5.FlatAppearance.BorderSize = 0;
            myButton5.FlatStyle = FlatStyle.Flat;
            myButton5.Location = new Point(0, 394);
            myButton5.Name = "myButton5";
            myButton5.Size = new Size(151, 34);
            myButton5.TabIndex = 7;
            myButton5.Text = " ";
            myButton5.UseVisualStyleBackColor = true;
            // 
            // myButton4
            // 
            myButton4.BackgroundImage = (Image)resources.GetObject("myButton4.BackgroundImage");
            myButton4.BackgroundImageLayout = ImageLayout.Stretch;
            myButton4.Dock = DockStyle.Top;
            myButton4.FlatAppearance.BorderSize = 0;
            myButton4.FlatStyle = FlatStyle.Flat;
            myButton4.Location = new Point(0, 359);
            myButton4.Name = "myButton4";
            myButton4.Size = new Size(151, 35);
            myButton4.TabIndex = 5;
            myButton4.Text = " ";
            myButton4.UseVisualStyleBackColor = true;
            // 
            // instructordropdown
            // 
            instructordropdown.BackColor = SystemColors.ButtonFace;
            instructordropdown.Dock = DockStyle.Top;
            instructordropdown.Location = new Point(0, 251);
            instructordropdown.Name = "instructordropdown";
            instructordropdown.Size = new Size(151, 108);
            instructordropdown.TabIndex = 4;
            // 
            // myButton3
            // 
            myButton3.BackgroundImage = (Image)resources.GetObject("myButton3.BackgroundImage");
            myButton3.BackgroundImageLayout = ImageLayout.Stretch;
            myButton3.Cursor = Cursors.Hand;
            myButton3.Dock = DockStyle.Top;
            myButton3.FlatAppearance.BorderSize = 0;
            myButton3.FlatStyle = FlatStyle.Flat;
            myButton3.Location = new Point(0, 216);
            myButton3.Name = "myButton3";
            myButton3.Size = new Size(151, 35);
            myButton3.TabIndex = 3;
            myButton3.Text = " ";
            myButton3.UseVisualStyleBackColor = true;
            myButton3.Click += myButton3_Click;
            // 
            // studentdropdown
            // 
            studentdropdown.BackColor = SystemColors.ButtonFace;
            studentdropdown.Controls.Add(subMenu3);
            studentdropdown.Controls.Add(subMenu2);
            studentdropdown.Controls.Add(subMenu1);
            studentdropdown.Dock = DockStyle.Top;
            studentdropdown.Location = new Point(0, 112);
            studentdropdown.Name = "studentdropdown";
            studentdropdown.Size = new Size(151, 104);
            studentdropdown.TabIndex = 1;
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
            subMenu3.Text = "subMenu3";
            subMenu3.TextAlign = ContentAlignment.MiddleRight;
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
            subMenu2.Text = "subMenu2";
            subMenu2.TextAlign = ContentAlignment.MiddleRight;
            subMenu2.UseVisualStyleBackColor = false;
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
            subMenu1.Text = "subMenu1";
            subMenu1.TextAlign = ContentAlignment.MiddleRight;
            subMenu1.UseVisualStyleBackColor = false;
            // 
            // myButton2
            // 
            myButton2.BackColor = SystemColors.Control;
            myButton2.BackgroundImage = (Image)resources.GetObject("myButton2.BackgroundImage");
            myButton2.BackgroundImageLayout = ImageLayout.Stretch;
            myButton2.Dock = DockStyle.Top;
            myButton2.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 1, 0);
            myButton2.FlatStyle = FlatStyle.Flat;
            myButton2.Location = new Point(0, 79);
            myButton2.Name = "myButton2";
            myButton2.Size = new Size(151, 33);
            myButton2.TabIndex = 1;
            myButton2.Text = " \r\n";
            myButton2.TextImageRelation = TextImageRelation.ImageAboveText;
            myButton2.UseVisualStyleBackColor = false;
            myButton2.Click += myButton2_Click;
            // 
            // myButton1
            // 
            myButton1.BackColor = Color.Transparent;
            myButton1.BackgroundImage = (Image)resources.GetObject("myButton1.BackgroundImage");
            myButton1.BackgroundImageLayout = ImageLayout.Stretch;
            myButton1.Dock = DockStyle.Top;
            myButton1.FlatAppearance.BorderSize = 0;
            myButton1.FlatStyle = FlatStyle.Flat;
            myButton1.Location = new Point(0, 48);
            myButton1.Name = "myButton1";
            myButton1.Size = new Size(151, 31);
            myButton1.TabIndex = 0;
            myButton1.Text = " ";
            myButton1.UseVisualStyleBackColor = false;
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
            panelHeader.Size = new Size(567, 48);
            panelHeader.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(439, 15);
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
            circularPictureBox1.Location = new Point(403, 12);
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
            pictureBox2.Location = new Point(510, 12);
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
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(151, 48);
            panel1.Name = "panel1";
            panel1.Size = new Size(567, 507);
            panel1.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.Controls.Add(dataGridView1);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 162);
            panel5.Name = "panel5";
            panel5.Size = new Size(567, 345);
            panel5.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(567, 345);
            dataGridView1.TabIndex = 0;
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
            panel4.Size = new Size(567, 162);
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
            ClientSize = new Size(718, 555);
            Controls.Add(panel1);
            Controls.Add(panelHeader);
            Controls.Add(panelMenu);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            panelMenu.ResumeLayout(false);
            panel2.ResumeLayout(false);
            studentdropdown.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)circularPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)miniMenu).EndInit();
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
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
        private Panel panel2;
        private Panel panel3;
        private CustomControl.MyButton myButton2;
        private CustomControl.MyButton myButton1;
        private Panel studentdropdown;
        private Panel panel5;
        private DataGridView dataGridView1;
        private Panel panel4;
        private CustomControl.subMenu subMenu3;
        private CustomControl.subMenu subMenu2;
        private CustomControl.subMenu subMenu1;
        private CustomControl.CircularPictureBox circularPictureBox1;
        private Label label1;
        private Panel instructordropdown;
        private MyButton myButton3;
        private MyButton myButton5;
        private MyButton myButton4;
        private MyButton btnSetting;
        private MyButton myButton6;
        private Panel panel6;
        private Panel panel8;
        private Panel panel7;
        private Label label3;
        private Label lblTotalStudent;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private MyButton myButton7;
    }
}