using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectSystem.UserControls
{
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text != txtCPassword.Text)
            {
                MessageBox.Show("Passwords do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var connection = new System.Data.SqlClient.SqlConnection(DbHelper.LoginConnectionString))
            {
                //connection.Open();

                var hashPassowrd = PasswordHasher.HashPassword(txtPassword.Text);

                string query = "INSERT INTO Users (Username, Password, Roles) VALUES (@Username, @Password, 'User')";
                using (var command = new System.Data.SqlClient.SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", txtUserName.Text);
                    command.Parameters.AddWithValue("@Password", hashPassowrd);
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Account created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();

                }
            }
        }
    }
}
