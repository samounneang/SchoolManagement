using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
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

        private void MainForm_Load(object sender, EventArgs e)
        {



            //var s = "";
            //foreach (var i in Application.OpenForms) { 
            //    s += i;
            //}


            // Application.OpenForms["UserLogin"].Close();
            //foreach (Form form in Application.OpenForms)
            //{
            //    if (form.Name == "LoginForm")  // or use any condition to identify the form
            //    {
            //        form.Close();
            //    }
            //}

            //Application.OpenForms["LoginForm"].Close();
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (panelDropdown.Visible == true)
                panelDropdown.Visible = false;
            else
                panelDropdown.Visible = true;
        }

        private void Master_Click(object sender, EventArgs e)
        {
            if (panelDropdown.Visible == true)
                panelDropdown.Visible = false;
            else
                panelDropdown.Visible = true;
        }

        private void subMenu1_Click(object sender, EventArgs e)
        {
            subMenu1.BackColor = Color.Red;

            // Clear others button style
            subMenu2.BackColor = SystemColors.ActiveCaption;
            subMenu3.BackColor = SystemColors.ActiveCaption;
            subMenu4.BackColor = SystemColors.ActiveCaption;
            subMenu5.BackColor = SystemColors.ActiveCaption;
        }

        private void subMenu2_Click(object sender, EventArgs e)
        {

            subMenu2.BackColor = Color.Red;

            // Clear others button style
            subMenu1.BackColor = SystemColors.ActiveCaption;
            subMenu3.BackColor = SystemColors.ActiveCaption;
            subMenu4.BackColor = SystemColors.ActiveCaption;
            subMenu5.BackColor = SystemColors.ActiveCaption;
        }

        private void subMenu3_Click(object sender, EventArgs e)
        {
            subMenu3.BackColor = Color.Red;

            // Clear others button style
            subMenu1.BackColor = SystemColors.ActiveCaption;
            subMenu2.BackColor = SystemColors.ActiveCaption;
            subMenu4.BackColor = SystemColors.ActiveCaption;
            subMenu5.BackColor = SystemColors.ActiveCaption;
        }

        private void subMenu4_Click(object sender, EventArgs e)
        {
            subMenu4.BackColor = Color.Red;

            // Clear others button style
            subMenu1.BackColor = SystemColors.ActiveCaption;
            subMenu3.BackColor = SystemColors.ActiveCaption;
            subMenu2.BackColor = SystemColors.ActiveCaption;
            subMenu5.BackColor = SystemColors.ActiveCaption;
        }

        private void subMenu5_Click(object sender, EventArgs e)
        {
            subMenu5.BackColor = Color.Red;

            // Clear others button style
            subMenu1.BackColor = SystemColors.ActiveCaption;
            subMenu3.BackColor = SystemColors.ActiveCaption;
            subMenu4.BackColor = SystemColors.ActiveCaption;
            subMenu2.BackColor = SystemColors.ActiveCaption;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = 0;
            i = int.Parse(totalStudent.Text);
            i++;
            totalStudent.Text = i.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            UserLogin userLogin = new UserLogin();
            userLogin.Show();
            this.Hide();
        }
    }
}
