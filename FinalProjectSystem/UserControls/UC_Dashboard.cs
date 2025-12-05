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
    public partial class UC_Dashboard : UserControl
    {
        public UC_Dashboard()
        {
            InitializeComponent();
        }

        public static UC_Dashboard GetInstance { get; internal set; }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UC_Dashboard_Load(object sender, EventArgs e)
        {
            using (var connection = new System.Data.SqlClient.SqlConnection(DbHelper.LoginConnectionString))
            {
                connection.Open();
                string query = "SELECT Username, Roles FROM Users";
                using (var command = new System.Data.SqlClient.SqlCommand(query, connection))
                {
                    var dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        int rowIndex = dgvUsers.Rows.Add();
                        var row = dgvUsers.Rows[rowIndex];

                        row.Cells["Username"].Value = dataReader["Username"].ToString();
                        row.Cells["Role"].Value = dataReader["Roles"].ToString();
                    }
                }
            }
        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
