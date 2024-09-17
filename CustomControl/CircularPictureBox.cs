using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.CustomControl
{
    internal class CircularPictureBox: PictureBox
    {
        protected override void OnPaint(PaintEventArgs pe)
        {
            // Create a circular region
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, this.Width, this.Height);
            pe.Graphics.SetClip(path);

            base.OnPaint(pe);
        }

        protected override void OnResize(System.EventArgs e)
        {
            base.OnResize(e);
            // Force the control to be square by setting its height and width to the same value
            if (this.Width != this.Height)
            {
                this.Width = this.Height;
            }
        }
    }
}
