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
    public partial class Registration : Form
    {
        public SqlConnection connection;
        public SqlCommand cmd;

        public Registration()
        {
            InitializeComponent();
        }
        private void Registration_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ADMIN\OneDrive\Desktop\Projects\C#Auth\Credentials.mdf;Integrated Security=True");
            connection.Open();
        }
        private void register_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text != string.Empty || txtPass.Text != string.Empty || txtEmail.Text != string.Empty)
            {
                if (txtPass.Text == txtConfirmPass.Text)
                {
                    cmd = new SqlCommand("select * from LoginTable where username='" + txtUserName.Text + "'", connection);
                    var dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        dr.Close();
                        MessageBox.Show("Username already exists please try another", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        dr.Close();
                        cmd = new SqlCommand("insert into LoginTable values(@username,@email,@password)", connection);
                        cmd.Parameters.AddWithValue("username", txtUserName.Text);
                        cmd.Parameters.AddWithValue("email", txtEmail.Text);
                        cmd.Parameters.AddWithValue("password", txtPass.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Account created. Please login now.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Your Passwords do not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please fill in all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void login_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }
    }
}
