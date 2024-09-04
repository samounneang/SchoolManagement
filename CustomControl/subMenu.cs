using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.CustomControl
{
    //Size: Icons for a control must be a 16x16 bitmap image.
    //File type: The icon can be either a Bitmap(.bmp) or a Windows Icon(.ico) file.
    //Transparency: The magenta color(RGB: 255,0,255, Hex: 0xFF00FF) is rendered transparent.
    //Themes: Visual Studio has multiple themes, but each theme is considered either dark or light.Your icon should be designed for the light theme.When Visual Studio uses a dark theme, the dark and light colors in the icon are automatically inverted.
    //[ToolboxBitmap(typeof(MyButton))]
    //[ToolboxBitmap(typeof(subMenu), "SchoolManagement.CustomControl.MyButton.bmp")]
    //[ToolboxBitmap(@"C:\Files\Resources\MyIcon.bmp")]
    internal class subMenu:Button
    {
        public subMenu()
        {
            Dock = DockStyle.Top;
            FlatStyle = FlatStyle.Flat;
            TextAlign = ContentAlignment.MiddleRight;
            FlatAppearance.BorderSize = 0;
            UseVisualStyleBackColor = true;
            Padding = new Padding(0, 0, 10, 0);
        }
    }
}
