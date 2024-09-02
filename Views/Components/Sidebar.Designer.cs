namespace SchoolManagement.Views.Components
{
    partial class Sidebar
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
            button1 = new Button();
            panelDropdown = new Panel();
            subMenu1 = new CustomControl.subMenu();
            subMenu2 = new CustomControl.subMenu();
            subMenu3 = new CustomControl.subMenu();
            subMenu4 = new CustomControl.subMenu();
            subMenu5 = new CustomControl.subMenu();
            panelDropdown.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(149, 44);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panelDropdown
            // 
            panelDropdown.BackColor = SystemColors.ActiveCaption;
            panelDropdown.Controls.Add(subMenu5);
            panelDropdown.Controls.Add(subMenu4);
            panelDropdown.Controls.Add(subMenu3);
            panelDropdown.Controls.Add(subMenu2);
            panelDropdown.Controls.Add(subMenu1);
            panelDropdown.Location = new Point(6, 46);
            panelDropdown.Name = "panelDropdown";
            panelDropdown.Size = new Size(146, 166);
            panelDropdown.TabIndex = 1;
            // 
            // subMenu1
            // 
            subMenu1.Dock = DockStyle.Top;
            subMenu1.FlatAppearance.BorderSize = 0;
            subMenu1.FlatStyle = FlatStyle.Flat;
            subMenu1.Location = new Point(0, 0);
            subMenu1.Name = "subMenu1";
            subMenu1.Padding = new Padding(0, 0, 10, 0);
            subMenu1.Size = new Size(146, 23);
            subMenu1.TabIndex = 0;
            subMenu1.Text = "subMenu1";
            subMenu1.TextAlign = ContentAlignment.MiddleRight;
            subMenu1.UseVisualStyleBackColor = true;
            // 
            // subMenu2
            // 
            subMenu2.Dock = DockStyle.Top;
            subMenu2.FlatAppearance.BorderSize = 0;
            subMenu2.FlatStyle = FlatStyle.Flat;
            subMenu2.Location = new Point(0, 23);
            subMenu2.Name = "subMenu2";
            subMenu2.Padding = new Padding(0, 0, 10, 0);
            subMenu2.Size = new Size(146, 23);
            subMenu2.TabIndex = 1;
            subMenu2.Text = "subMenu2";
            subMenu2.TextAlign = ContentAlignment.MiddleRight;
            subMenu2.UseVisualStyleBackColor = true;
            // 
            // subMenu3
            // 
            subMenu3.Dock = DockStyle.Top;
            subMenu3.FlatAppearance.BorderSize = 0;
            subMenu3.FlatStyle = FlatStyle.Flat;
            subMenu3.Location = new Point(0, 46);
            subMenu3.Name = "subMenu3";
            subMenu3.Padding = new Padding(0, 0, 10, 0);
            subMenu3.Size = new Size(146, 23);
            subMenu3.TabIndex = 2;
            subMenu3.Text = "subMenu3";
            subMenu3.TextAlign = ContentAlignment.MiddleRight;
            subMenu3.UseVisualStyleBackColor = true;
            // 
            // subMenu4
            // 
            subMenu4.Dock = DockStyle.Top;
            subMenu4.FlatAppearance.BorderSize = 0;
            subMenu4.FlatStyle = FlatStyle.Flat;
            subMenu4.Location = new Point(0, 69);
            subMenu4.Name = "subMenu4";
            subMenu4.Padding = new Padding(0, 0, 10, 0);
            subMenu4.Size = new Size(146, 23);
            subMenu4.TabIndex = 3;
            subMenu4.Text = "subMenu4";
            subMenu4.TextAlign = ContentAlignment.MiddleRight;
            subMenu4.UseVisualStyleBackColor = true;
            // 
            // subMenu5
            // 
            subMenu5.Dock = DockStyle.Top;
            subMenu5.FlatAppearance.BorderSize = 0;
            subMenu5.FlatStyle = FlatStyle.Flat;
            subMenu5.Location = new Point(0, 92);
            subMenu5.Name = "subMenu5";
            subMenu5.Padding = new Padding(0, 0, 10, 0);
            subMenu5.Size = new Size(146, 23);
            subMenu5.TabIndex = 4;
            subMenu5.Text = "subMenu5";
            subMenu5.TextAlign = ContentAlignment.MiddleRight;
            subMenu5.UseVisualStyleBackColor = true;
            // 
            // Sidebar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelDropdown);
            Controls.Add(button1);
            Name = "Sidebar";
            Size = new Size(155, 419);
            panelDropdown.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Panel panelDropdown;
        private CustomControl.subMenu subMenu5;
        private CustomControl.subMenu subMenu4;
        private CustomControl.subMenu subMenu3;
        private CustomControl.subMenu subMenu2;
        private CustomControl.subMenu subMenu1;
    }
}
