using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;

namespace SchoolManagement.CustomControl
{
    internal class CustomTextBox:TextBox
    {
        private int borderRadius = 4;

        public int BorderRadius
        {
            get { return borderRadius; }
            set
            {
                borderRadius = value;
                this.Invalidate(); // Redraw the control when the border radius is changed.
            }
        }

        public CustomTextBox()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Create a path that represents the rounded rectangle
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddArc(0, 0, borderRadius, borderRadius, 180, 90);
                path.AddArc(this.Width - borderRadius - 1, 0, borderRadius, borderRadius, 270, 90);
                path.AddArc(this.Width - borderRadius - 1, this.Height - borderRadius - 1, borderRadius, borderRadius, 0, 90);
                path.AddArc(0, this.Height - borderRadius - 1, borderRadius, borderRadius, 90, 90);
                path.CloseAllFigures();

                // Set the region of the TextBox to the rounded rectangle path
                this.Region = new Region(path);

                // Draw the border
                using (Pen pen = new Pen(Color.Gray, 1))
                {
                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }
    }
}
