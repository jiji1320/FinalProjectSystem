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
    public partial class UC_SalesHistory : UserControl
    {
        public UC_SalesHistory()
        {
            InitializeComponent();
        }

        private void UC_SalesHistory_Load(object sender, EventArgs e)
        {
            using (var connection = new System.Data.SqlClient.SqlConnection(DbHelper.LoginConnectionString))
            {
                connection.Open();
                string query = "SELECT * FROM ProductC";
                using (var command = new System.Data.SqlClient.SqlCommand(query, connection))
                {
                    var dataReader = command.ExecuteReader();

                    while (dataReader.Read()) {
                        int rowIndex = dgvLists.Rows.Add();
                        var row = dgvLists.Rows[rowIndex]; 
                        
                        row.Cells["ProductName"].Value = dataReader["ProductName"].ToString();
                        row.Cells["StyleType"].Value = dataReader["StyleType"].ToString();
                        row.Cells["Size"].Value = dataReader["Size"];
                        row.Cells["Color"].Value = dataReader["Color"].ToString();
                        row.Cells["Quantity"].Value = dataReader["Quantity"].ToString();


                    }

                    //dataTable.Load(dataReader);
                    //dgvLists.DataSource = dataTable;

                }
            }
        }
    }
}
