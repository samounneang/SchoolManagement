using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagement.Views.Components
{
    public partial class Navbar : UserControl
    {
        public Navbar()
        {
            InitializeComponent();
        }

        private void btnMasterInfo_Click(object sender, EventArgs e)
        {
            if (!MasterDropdown.Visible)
            {
                // Interact style
                MasterDropdown.Visible = true;
                MasterDropdown.Size = new Size(160, 141);
                btnMasterInfo.BackColor = Color.DarkGray;

            }
            else
            {
                MasterDropdown.Visible = false;
                btnMasterInfo.BackColor = Color.Transparent;
            }
        }

        public event EventHandler ButtonClicked;
        private void subMenu1_Click(object sender, EventArgs e)
        {
            setSubMenuTodefault();
            subMenu1.ForeColor = Color.DarkBlue;
            
            // Invoke from MainForm
            ButtonClicked?.Invoke(this, e);

        }

        private void subMenu2_Click(object sender, EventArgs e)
        {
            setSubMenuTodefault();
            subMenu2.ForeColor = Color.DarkBlue;
        }

        private void subMenu3_Click(object sender, EventArgs e)
        {
            setSubMenuTodefault();
            subMenu3.ForeColor = Color.DarkBlue;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!MasterDropdown.Visible)
            {
                // Interact style
                MasterDropdown.Visible = true;
                MasterDropdown.Size = new Size(160, 141);
                btnMasterInfo.BackColor = Color.DarkGray;

            }
            else
            {
                MasterDropdown.Visible = false;
                btnMasterInfo.BackColor = Color.Transparent;
            }
        }

        //private void subMenu1_Click(object sender, EventArgs e)
        //{
        //    setSubMenuTodefault();
        //    subMenu1.ForeColor = Color.DarkBlue;

        //}
        private void setSubMenuTodefault()
        {
            subMenu1.ForeColor = new CustomControl.subMenu().ForeColor;
            subMenu2.ForeColor = new CustomControl.subMenu().ForeColor;
            subMenu3.ForeColor = new CustomControl.subMenu().ForeColor;
            subMenu4.ForeColor = new CustomControl.subMenu().ForeColor;
            subMenu5.ForeColor = new CustomControl.subMenu().ForeColor;
            subMenu6.ForeColor = new CustomControl.subMenu().ForeColor;
        }

        private void subMenu5_Click(object sender, EventArgs e)
        {

        }

        //private void subMenu2_Click(object sender, EventArgs e)
        //{
        //    setSubMenuTodefault();
        //    subMenu2.ForeColor = Color.DarkBlue;
        //}

        //private void subMenu3_Click(object sender, EventArgs e)
        //{
        //    setSubMenuTodefault();
        //    subMenu3.ForeColor = Color.DarkBlue;
        //}
    }
}
