using SchoolManagement.Models;
using SchoolManagement.Repositories;
using SchoolManagement.Services;
using SchoolManagement.Views.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagement.Views.Component
{
    public partial class UserList : Form
    {
        public UserList()
        {
            InitializeComponent();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            UserAdd childForm = new UserAdd();
            childForm.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(childForm);
            childForm.Dock = DockStyle.Fill;
            childForm.Show();
        }

        private void UserList_Load(object sender, EventArgs e)
        {
            UserGridView.DataSource = UserService.GetAllUser();
         
        }
    }
}
