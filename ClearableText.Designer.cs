﻿namespace SchoolManagement
{
    partial class ClearableText
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
            lblTitle = new Label();
            txtValue = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(3, 5);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(38, 15);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "label1";
            // 
            // txtValue
            // 
            txtValue.Location = new Point(2, 23);
            txtValue.Name = "txtValue";
            txtValue.Size = new Size(148, 23);
            txtValue.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(157, 23);
            button1.Name = "button1";
            button1.Size = new Size(31, 23);
            button1.TabIndex = 2;
            button1.Text = "↻";
            button1.UseVisualStyleBackColor = true;
            // 
            // ClearableText
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(txtValue);
            Controls.Add(lblTitle);
            MinimumSize = new Size(84, 53);
            Name = "ClearableText";
            Size = new Size(191, 53);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private TextBox txtValue;
        private Button button1;
    }
}
