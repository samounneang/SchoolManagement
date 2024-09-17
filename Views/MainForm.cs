using SchoolManagement.Models;
using System.Data.SqlClient;

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
            if (studentdropdown.Visible == true)
                studentdropdown.Visible = false;
            else
                studentdropdown.Visible = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            List<Users> users = new List<Users>();
 
            //1. Connection String
            
            SqlConnection connection = null;
            connection = new SqlConnection("Server=.;Database=SchoolManagement;User Id=sa;Password=Pa$$w0rd@admin;");
            connection.Open(); // Open the connection

            //2. Sql command
            
            SqlCommand command = new SqlCommand("SELECT * FROM users", connection);
            //command.ExecuteNonQuery();
            
            //3. Data reader
            SqlDataReader sqlDataReader = command.ExecuteReader();
            
            while (sqlDataReader.Read())
            {

                //user.UserId = Convert.ToInt32(sqlDataReader[0]);
                //user.Username = sqlDataReader[1].ToString();
                //user.Role = sqlDataReader[4].ToString();

                users.Add(new Users {
                    UserId = Convert.ToInt32(sqlDataReader["UserID"]),
                    Username = sqlDataReader["Username"].ToString(),
                    Role = sqlDataReader["Role"].ToString()
                });
                
            }

            connection.Close();

           
            dataGridView1.DataSource = users;

            lblTotalStudent.Text = users.Count.ToString();
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
        }

        private void myButton3_Click(object sender, EventArgs e)
        {

            if (instructordropdown.Visible == true)
                instructordropdown.Visible = false;
            else
                instructordropdown.Visible = true;
        }

        private void myButton6_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalStudent_Click(object sender, EventArgs e)
        {

        }
    }
}
