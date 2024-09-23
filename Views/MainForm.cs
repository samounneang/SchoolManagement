using SchoolManagement.Repositories;
using SchoolManagement.Views.Component;
using SchoolManagement.Views.Students;

namespace SchoolManagement.Views
{
    public partial class MainForm : Form
    {
        string RoleMenu = string.Empty;
        public MainForm(string role)
        {
            RoleMenu = role;
            InitializeComponent();
        }

        private void miniMenu_Click(object sender, EventArgs e)
        {
            if (panelMenu.Width == 151)
            {
                panelMenu.Size = new Size(50, 450);
                lblBrand.Text = "NIT";

            }
            else
            {
                panelMenu.Size = new Size(151, 450);
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
            if (StudentMenuItem.Visible == true)
                StudentMenuItem.Visible = false;
            else
                StudentMenuItem.Visible = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
          
            // Role check // 
            LoadMenuButtons();

            //dataGridView1.DataSource =  UserRepository.GetAllUsers();
            lblTotalStudent.Text = UserRepository.GetAllUsers().Count.ToString();
        }

        private void LoadMenuButtons()
        {
            var visibleButtons = UserRepository.GetMenuItemsByRole(RoleMenu);

            HideAllMenuButtons();

            foreach (var buttonName in visibleButtons)
            {
                Control[] foundControls = this.Controls.Find(buttonName, true);
                if (foundControls.Length > 0)
                {
                    foundControls[0].Visible = true; // Make the button visible
                }
            }
        }
        private void HideAllMenuButtons()
        {
            DashboardMenu.Visible = false;
            StudentMenu.Visible = false;
            StudentMenuItem.Visible = false;
            InstructorMenu.Visible = false;
            InstructorMenuItem.Visible = false;
            ParentsMenu.Visible = false;
            LibraryMenu.Visible = false;
            ReportMenu.Visible = false;
            SettingMenu.Visible = false;
            EmployeeMenu.Visible = false;
        }
        private void circularPictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            //openFileDialog.ShowDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                circularPictureBox1.Image = Image.FromFile(openFileDialog.FileName);
            }

            //using (OpenFileDialog openFileDialog = new OpenFileDialog())
            //{
            //    openFileDialog.InitialDirectory = "c:\\";
            //    openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            //    openFileDialog.Title = "Select Student Photo";

            //    if (openFileDialog.ShowDialog() == DialogResult.OK)
            //    {
            //        // Save the selected photo path
            //        string photoPath = openFileDialog.FileName;
            //        // Upload the photo for a specific student (e.g., studentId is retrieved from your form)
            //        UploadStudentPhoto(studentId, photoPath);
            //    }
            //}


        }

        private void LoadStudentPhoto(int studentId)
        {
            string photoPath = new StudentRepository().GetStudentPhotoPath(studentId);
            if (!string.IsNullOrEmpty(photoPath))
            {
                string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, photoPath.TrimStart('/').Replace('/', '\\'));
                if (File.Exists(fullPath))
                {
                    circularPictureBox1.Image = Image.FromFile(fullPath);
                }
            }
        }

        private void myButton3_Click(object sender, EventArgs e)
        {

            if (InstructorMenuItem.Visible == true)
                InstructorMenuItem.Visible = false;
            else
                InstructorMenuItem.Visible = true;
        }

        private void myButton6_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalStudent_Click(object sender, EventArgs e)
        {

        }

        private void EmployeeMenu_Click(object sender, EventArgs e)
        {

            UserList childForm = new UserList();
            childForm.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(childForm);
            childForm.Dock = DockStyle.Fill;
            childForm.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void subMenu2_Click(object sender, EventArgs e)
        {
            replaceform(new StudentList());
        }

        private void subMenu1_Click(object sender, EventArgs e)
        {
            replaceform(new AddStudent());
        }

        void replaceform(Form childForm)
        {
            //StudentList childForm = new StudentList();
            childForm.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(childForm);
            childForm.Dock = DockStyle.Fill;
            childForm.Show();
        }

        private void InstructorMenuItem_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
