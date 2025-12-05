using FinalProjectSystem.UserControls.Components;
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
    public partial class UC_Products : UserControl
    {
        public UC_Products()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void UC_Products_Load(object sender, EventArgs e)
        {
            panelLists.Controls.Clear();

            using (var connection = new System.Data.SqlClient.SqlConnection(DbHelper.ConnectionString))
            {
                connection.Open();
                string query = "SELECT * FROM TshirtsInventory";
                using (var command = new System.Data.SqlClient.SqlCommand(query, connection))
                {
                    var dataReader = command.ExecuteReader();

                    while(dataReader.Read()) {
                        var item = new ProductListItem();
                        item.Location = new Point((item.Width + 10) * panelLists.Controls.Count, 0);
                        // StyleType, Color, Size, Price

                        item.SetProductDetails(dataReader["ProductName"].ToString(), dataReader["StyleType"].ToString(), dataReader["Color"].ToString(), dataReader["Size"].ToString(), Convert.ToInt32(dataReader["Price"]));
                        panelLists.Controls.Add(item);
                    }

                    dataReader.Close();
                }
            }

        }

        private void productListItem1_Load(object sender, EventArgs e)
        {
                
        }
    }
}
