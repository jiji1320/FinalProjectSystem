using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectSystem.UserControls.Components
{
    public partial class ProductConfirm : Form
    {

        private string productName;
        private string styleType;
        private string size;
        private string color;
        private int price;

        public ProductConfirm()
        {
            InitializeComponent();
        }

        public void SetProductDetails(string productName, string styleType, string size, string color, int price)
        {
            this.productName = productName;
            this.styleType = styleType;
            this.size = size;
            this.color = color;
            this.price = price;

            lblProductName.Text = productName;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            var quantity = Convert.ToInt32(tbQty.Text);

            using (var connection = new System.Data.SqlClient.SqlConnection(DbHelper.ConnectionString))
            {

                string query = "INSERT INTO ProductC (ProductName, StyleType, Size, Color, Price, Quantity) VALUES (@ProductName, @StyleType, @Size, @Color, @Price, @Quantity)";
                using (var command = new System.Data.SqlClient.SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ProductName", productName);
                    command.Parameters.AddWithValue("@StyleType", styleType);
                    command.Parameters.AddWithValue("@Size", size);
                    command.Parameters.AddWithValue("@Color", color);
                    command.Parameters.AddWithValue("@Price", price);
                    command.Parameters.AddWithValue("@Quantity", quantity);
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Product confirmed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }

                string queryQuantity = "UPDATE TshirtsInventory SET Stock = Stock - @Quantity WHERE ProductName = @ProductName";
                using (var command = new System.Data.SqlClient.SqlCommand(queryQuantity, connection))
                {
                    command.Parameters.AddWithValue("@Quantity", quantity);
                    command.Parameters.AddWithValue("@ProductName", productName);
                    command.ExecuteNonQuery();
                }

            }
        }
    }
}
