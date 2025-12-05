using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalProjectSystem.UserControls;
using System.Data.SqlClient;

namespace FinalProjectSystem
{
     
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            txtPassword.PlaceholderText = "Password";
            this.txtPassword.UseSystemPasswordChar = true;
        }
        
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both Username and Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection conn = new SqlConnection(DbHelper.LoginConnectionString))
            {
                conn.Open();
                string query = "SELECT Password FROM Users WHERE Username = @Username";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    var result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        string storedHashedPassword = result.ToString();

                        if (PasswordHasher.VerifyPassword(password, storedHashedPassword))
                        {
                            MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Main dashboard = new Main();
                            dashboard.Show();
                            Hide();
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Invalid Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
            }

            //if (username == "admin" && password == "123")
            //{
            //    MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    Main dashboard = new Main();
            //    dashboard.Show();

            //}
            //else
            //{
            //    MessageBox.Show("Invalid Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new CreateAccount().Show();
            this.Hide();
            
        }
    }
}
