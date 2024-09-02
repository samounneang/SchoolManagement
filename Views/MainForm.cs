using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void MainForm_Load(object sender, EventArgs e)
        {

            int activeFormsCount = Application.OpenForms.Count;

            //var s = "";
            //foreach (var i in Application.OpenForms) { 
            //    s += i;
            //}

            string str = @$"Number of active forms: {activeFormsCount}
                {Application.OpenForms["Text"]}
            ";

            MessageBox.Show(str);
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
    }
}
