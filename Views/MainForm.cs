using SchoolManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagement.Views
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void miniMenu_Click(object sender, EventArgs e)
        {
            if (panelMenu.Width == 141)
            {
                panelMenu.Size = new Size(50, 450);
                lblBrand.Text = "NIT";

            }
            else
            {
                panelMenu.Size = new Size(141, 450);
                lblBrand.Text = "NIT Traning Center";
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new UserLogin().Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void myButton2_Click(object sender, EventArgs e)
        {
            if (studentdropdown.Visible == true)
                studentdropdown.Visible = false;
            else
                studentdropdown.Visible = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            List<Users> users = new List<Users>();
            
            //Users users1 = new Users();
            //users1.Role = "admin";
            //users1.UserId = 2;
            //users1.Username = "username";

            //users.Add(users1);

            users.Add(new Users { Role = "Admin", UserId=1, Username= "useradmin"});
            users.Add(new Users { Role = "Admin", UserId = 1, Username = "useradmin" });
            users.Add(new Users { Role = "Admin", UserId = 1, Username = "useradmin" });
            users.Add(new Users { Role = "Admin", UserId = 1, Username = "useradmin" });

            dataGridView1.DataSource = users;
        }
    }
}
