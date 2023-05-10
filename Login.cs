using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Auth
{
    public partial class Login : Form
    {
        public SqlConnection connection;
        public SqlCommand cmd;
      
        public Login()
        {
            InitializeComponent();
        }
        private void Login_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ADMIN\OneDrive\Desktop\Projects\C#Auth\Credentials.mdf;Integrated Security=True");
            connection.Open();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text != string.Empty || txtPass.Text != string.Empty)
            {
                cmd = new SqlCommand("select * from LoginTable where username='" + txtUserName.Text + "' and password='" + txtPass.Text + "'", connection);
                var dr = cmd.ExecuteReader();
                if(dr.Read())
                {
                    dr.Close();
                    this.Hide();
                    Homepage homepage = new Homepage();
                    homepage.ShowDialog();
                }
                else
                {
                    dr.Close();
                    MessageBox.Show("No Account avilable with this username and password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please fill in all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration registration = new Registration();
            registration.ShowDialog();
        }
    }
}
