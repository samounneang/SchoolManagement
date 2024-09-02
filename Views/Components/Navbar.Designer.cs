namespace SchoolManagement.Views.Components
{
    partial class Navbar
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelSidebar = new Panel();
            MasterDropdown = new Panel();
            subMenu6 = new CustomControl.subMenu();
            subMenu5 = new CustomControl.subMenu();
            subMenu4 = new CustomControl.subMenu();
            subMenu3 = new CustomControl.subMenu();
            subMenu2 = new CustomControl.subMenu();
            subMenu1 = new CustomControl.subMenu();
            btnMasterInfo = new Button();
            panelSidebar.SuspendLayout();
            MasterDropdown.SuspendLayout();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = SystemColors.ControlLightLight;
            panelSidebar.Controls.Add(MasterDropdown);
            panelSidebar.Controls.Add(btnMasterInfo);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(133, 436);
            panelSidebar.TabIndex = 1;
            // 
            // MasterDropdown
            // 
            MasterDropdown.Controls.Add(subMenu6);
            MasterDropdown.Controls.Add(subMenu5);
            MasterDropdown.Controls.Add(subMenu4);
            MasterDropdown.Controls.Add(subMenu3);
            MasterDropdown.Controls.Add(subMenu2);
            MasterDropdown.Controls.Add(subMenu1);
            MasterDropdown.Dock = DockStyle.Top;
            MasterDropdown.Location = new Point(0, 30);
            MasterDropdown.Name = "MasterDropdown";
            MasterDropdown.Size = new Size(133, 141);
            MasterDropdown.TabIndex = 1;
            MasterDropdown.Visible = false;
            // 
            // subMenu6
            // 
            subMenu6.Dock = DockStyle.Top;
            subMenu6.FlatAppearance.BorderSize = 0;
            subMenu6.FlatStyle = FlatStyle.Flat;
            subMenu6.Location = new Point(0, 115);
            subMenu6.Name = "subMenu6";
            subMenu6.Padding = new Padding(0, 0, 10, 0);
            subMenu6.Size = new Size(133, 23);
            subMenu6.TabIndex = 5;
            subMenu6.Text = "subMenu6";
            subMenu6.TextAlign = ContentAlignment.MiddleRight;
            subMenu6.UseVisualStyleBackColor = true;
            // 
            // subMenu5
            // 
            subMenu5.Dock = DockStyle.Top;
            subMenu5.FlatAppearance.BorderSize = 0;
            subMenu5.FlatStyle = FlatStyle.Flat;
            subMenu5.Location = new Point(0, 92);
            subMenu5.Name = "subMenu5";
            subMenu5.Padding = new Padding(0, 0, 10, 0);
            subMenu5.Size = new Size(133, 23);
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
            subMenu4.Size = new Size(133, 23);
            subMenu4.TabIndex = 3;
            subMenu4.Text = "subMenu4";
            subMenu4.TextAlign = ContentAlignment.MiddleRight;
            subMenu4.UseVisualStyleBackColor = true;
            // 
            // subMenu3
            // 
            subMenu3.Dock = DockStyle.Top;
            subMenu3.FlatAppearance.BorderSize = 0;
            subMenu3.FlatStyle = FlatStyle.Flat;
            subMenu3.Location = new Point(0, 46);
            subMenu3.Name = "subMenu3";
            subMenu3.Padding = new Padding(0, 0, 10, 0);
            subMenu3.Size = new Size(133, 23);
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
            subMenu2.Size = new Size(133, 23);
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
            subMenu1.Size = new Size(133, 23);
            subMenu1.TabIndex = 0;
            subMenu1.Text = "subMenu1";
            subMenu1.TextAlign = ContentAlignment.MiddleRight;
            subMenu1.UseVisualStyleBackColor = true;
            subMenu1.Click += subMenu1_Click;
            // 
            // btnMasterInfo
            // 
            btnMasterInfo.Dock = DockStyle.Top;
            btnMasterInfo.FlatAppearance.BorderSize = 0;
            btnMasterInfo.FlatStyle = FlatStyle.Flat;
            btnMasterInfo.Location = new Point(0, 0);
            btnMasterInfo.Margin = new Padding(0);
            btnMasterInfo.Name = "btnMasterInfo";
            btnMasterInfo.Padding = new Padding(1, 0, 0, 0);
            btnMasterInfo.Size = new Size(133, 30);
            btnMasterInfo.TabIndex = 0;
            btnMasterInfo.Text = "Master info";
            btnMasterInfo.UseVisualStyleBackColor = true;
            btnMasterInfo.Click += btnMasterInfo_Click;
            // 
            // Navbar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelSidebar);
            Name = "Navbar";
            Size = new Size(135, 436);
            panelSidebar.ResumeLayout(false);
            MasterDropdown.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSidebar;
        private Panel MasterDropdown;
        private CustomControl.subMenu subMenu6;
        private CustomControl.subMenu subMenu5;
        private CustomControl.subMenu subMenu4;
        private CustomControl.subMenu subMenu3;
        private CustomControl.subMenu subMenu2;
        private CustomControl.subMenu subMenu1;
        private Button btnMasterInfo;
    }
}
