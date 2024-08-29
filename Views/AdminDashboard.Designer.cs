namespace SchoolManagement.Views
{
    partial class AdminDashboard
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
            menuStrip1 = new MenuStrip();
            masterInformationToolStripMenuItem = new ToolStripMenuItem();
            studentToolStripMenuItem = new ToolStripMenuItem();
            registerToolStripMenuItem = new ToolStripMenuItem();
            dropToolStripMenuItem = new ToolStripMenuItem();
            teacherToolStripMenuItem = new ToolStripMenuItem();
            masterOrginzationToolStripMenuItem = new ToolStripMenuItem();
            masterTeacherToolStripMenuItem = new ToolStripMenuItem();
            masterCourseToolStripMenuItem = new ToolStripMenuItem();
            registerToolStripMenuItem1 = new ToolStripMenuItem();
            resignToolStripMenuItem = new ToolStripMenuItem();
            paymentToolStripMenuItem = new ToolStripMenuItem();
            cerficateToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { masterInformationToolStripMenuItem, studentToolStripMenuItem, teacherToolStripMenuItem, paymentToolStripMenuItem, cerficateToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // masterInformationToolStripMenuItem
            // 
            masterInformationToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { masterOrginzationToolStripMenuItem, masterTeacherToolStripMenuItem, masterCourseToolStripMenuItem });
            masterInformationToolStripMenuItem.Name = "masterInformationToolStripMenuItem";
            masterInformationToolStripMenuItem.Size = new Size(121, 20);
            masterInformationToolStripMenuItem.Text = "Master Information";
            // 
            // studentToolStripMenuItem
            // 
            studentToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { registerToolStripMenuItem, dropToolStripMenuItem });
            studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            studentToolStripMenuItem.Size = new Size(60, 20);
            studentToolStripMenuItem.Text = "Student";
            // 
            // registerToolStripMenuItem
            // 
            registerToolStripMenuItem.Name = "registerToolStripMenuItem";
            registerToolStripMenuItem.Size = new Size(116, 22);
            registerToolStripMenuItem.Text = "Register";
            // 
            // dropToolStripMenuItem
            // 
            dropToolStripMenuItem.Name = "dropToolStripMenuItem";
            dropToolStripMenuItem.Size = new Size(116, 22);
            dropToolStripMenuItem.Text = "Drop";
            // 
            // teacherToolStripMenuItem
            // 
            teacherToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { registerToolStripMenuItem1, resignToolStripMenuItem });
            teacherToolStripMenuItem.Name = "teacherToolStripMenuItem";
            teacherToolStripMenuItem.Size = new Size(59, 20);
            teacherToolStripMenuItem.Text = "Teacher";
            // 
            // masterOrginzationToolStripMenuItem
            // 
            masterOrginzationToolStripMenuItem.Name = "masterOrginzationToolStripMenuItem";
            masterOrginzationToolStripMenuItem.Size = new Size(173, 22);
            masterOrginzationToolStripMenuItem.Text = "Master orginzation";
            // 
            // masterTeacherToolStripMenuItem
            // 
            masterTeacherToolStripMenuItem.Name = "masterTeacherToolStripMenuItem";
            masterTeacherToolStripMenuItem.Size = new Size(173, 22);
            masterTeacherToolStripMenuItem.Text = "Master teacher";
            // 
            // masterCourseToolStripMenuItem
            // 
            masterCourseToolStripMenuItem.Name = "masterCourseToolStripMenuItem";
            masterCourseToolStripMenuItem.Size = new Size(173, 22);
            masterCourseToolStripMenuItem.Text = "Master course";
            // 
            // registerToolStripMenuItem1
            // 
            registerToolStripMenuItem1.Name = "registerToolStripMenuItem1";
            registerToolStripMenuItem1.Size = new Size(180, 22);
            registerToolStripMenuItem1.Text = "Register";
            // 
            // resignToolStripMenuItem
            // 
            resignToolStripMenuItem.Name = "resignToolStripMenuItem";
            resignToolStripMenuItem.Size = new Size(180, 22);
            resignToolStripMenuItem.Text = "Resign";
            // 
            // paymentToolStripMenuItem
            // 
            paymentToolStripMenuItem.Name = "paymentToolStripMenuItem";
            paymentToolStripMenuItem.Size = new Size(66, 20);
            paymentToolStripMenuItem.Text = "Payment";
            // 
            // cerficateToolStripMenuItem
            // 
            cerficateToolStripMenuItem.Name = "cerficateToolStripMenuItem";
            cerficateToolStripMenuItem.Size = new Size(66, 20);
            cerficateToolStripMenuItem.Text = "Cerficate";
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "AdminDashboard";
            Text = "AdminDashboard";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem masterInformationToolStripMenuItem;
        private ToolStripMenuItem studentToolStripMenuItem;
        private ToolStripMenuItem registerToolStripMenuItem;
        private ToolStripMenuItem dropToolStripMenuItem;
        private ToolStripMenuItem teacherToolStripMenuItem;
        private ToolStripMenuItem masterOrginzationToolStripMenuItem;
        private ToolStripMenuItem masterTeacherToolStripMenuItem;
        private ToolStripMenuItem masterCourseToolStripMenuItem;
        private ToolStripMenuItem registerToolStripMenuItem1;
        private ToolStripMenuItem resignToolStripMenuItem;
        private ToolStripMenuItem paymentToolStripMenuItem;
        private ToolStripMenuItem cerficateToolStripMenuItem;
    }
}