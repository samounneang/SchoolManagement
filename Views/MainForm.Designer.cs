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
            studentdropdown = new Panel();
            myButton2 = new CustomControl.MyButton();
            myButton1 = new CustomControl.MyButton();
            panel3 = new Panel();
            lblBrand = new Label();
            panelHeader = new Panel();
            pictureBox2 = new PictureBox();
            miniMenu = new PictureBox();
            panel1 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            dataGridView1 = new DataGridView();
            panelMenu.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)miniMenu).BeginInit();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = SystemColors.Control;
            panelMenu.Controls.Add(panel2);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(117, 450);
            panelMenu.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(studentdropdown);
            panel2.Controls.Add(myButton2);
            panel2.Controls.Add(myButton1);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(117, 450);
            panel2.TabIndex = 1;
            // 
            // studentdropdown
            // 
            studentdropdown.BackColor = SystemColors.ActiveCaption;
            studentdropdown.Dock = DockStyle.Top;
            studentdropdown.Location = new Point(0, 118);
            studentdropdown.Name = "studentdropdown";
            studentdropdown.Size = new Size(117, 130);
            studentdropdown.TabIndex = 1;
            // 
            // myButton2
            // 
            myButton2.Dock = DockStyle.Top;
            myButton2.FlatAppearance.BorderSize = 0;
            myButton2.FlatStyle = FlatStyle.Flat;
            myButton2.Location = new Point(0, 87);
            myButton2.Name = "myButton2";
            myButton2.Size = new Size(117, 31);
            myButton2.TabIndex = 0;
            myButton2.Text = "Student";
            myButton2.UseVisualStyleBackColor = true;
            myButton2.Click += myButton2_Click;
            // 
            // myButton1
            // 
            myButton1.Dock = DockStyle.Top;
            myButton1.FlatAppearance.BorderSize = 0;
            myButton1.FlatStyle = FlatStyle.Flat;
            myButton1.Location = new Point(0, 51);
            myButton1.Name = "myButton1";
            myButton1.Size = new Size(117, 36);
            myButton1.TabIndex = 0;
            myButton1.Text = "Dashboard";
            myButton1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(lblBrand);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(117, 51);
            panel3.TabIndex = 0;
            // 
            // lblBrand
            // 
            lblBrand.AutoSize = true;
            lblBrand.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblBrand.ForeColor = Color.White;
            lblBrand.Location = new Point(32, 12);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(46, 28);
            lblBrand.TabIndex = 0;
            lblBrand.Text = "NIT";
            lblBrand.Click += label1_Click;
            // 
            // panelHeader
            // 
            panelHeader.BackgroundImage = (Image)resources.GetObject("panelHeader.BackgroundImage");
            panelHeader.Controls.Add(pictureBox2);
            panelHeader.Controls.Add(miniMenu);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(117, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(683, 51);
            panelHeader.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(626, 12);
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
            miniMenu.Location = new Point(15, 12);
            miniMenu.Name = "miniMenu";
            miniMenu.Size = new Size(31, 30);
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
            panel1.Location = new Point(117, 51);
            panel1.Name = "panel1";
            panel1.Size = new Size(683, 399);
            panel1.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(683, 118);
            panel4.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.Controls.Add(dataGridView1);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 118);
            panel5.Name = "panel5";
            panel5.Size = new Size(683, 281);
            panel5.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(683, 281);
            dataGridView1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(panelHeader);
            Controls.Add(panelMenu);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            panelMenu.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)miniMenu).EndInit();
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
    }
}