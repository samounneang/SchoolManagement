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
    public partial class AdminDashboard : Form
    {
        string text;
        public AdminDashboard()
        {
            //resignToolStripMenuItem.Visible = false;
            InitializeComponent();
            resignToolStripMenuItem.Visible = false;


        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentControl studentControl = new StudentControl();
            panel1.Controls.Clear();
            panel1.Controls.Add(studentControl);
        }
    }
}
