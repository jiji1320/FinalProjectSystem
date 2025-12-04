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

namespace FinalProjectSystem.UserControls
{
    public partial class UC_Inventory : UserControl
    {
        public UC_Inventory()
        {
            InitializeComponent();
            LoadData();
            SetupComboBoxes();
            txtProductID.ReadOnly = true;
            dgvProduct.SelectionChanged += dgvProduct_SelectionChanged;

        }


        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            string query = @"INSERT INTO TshirtsInventory (ProductName, StyleType, Color, Size, Status, Stock, Price) 
                             VALUES (@Name, @StyleType, @Color, @Size, @Status, @Stock, @Price)";

            ExecuteNonQuery(query, "T-shirt added successfully!");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProductID.Text) || !ValidateInput())
            {
                MessageBox.Show("Select a product to update.", "Error");
                return;
            }

            string query = @"UPDATE TshirtsInventory SET 
                                 ProductName = @Name, 
                                 StyleType = @StyleType, 
                                 Color = @Color,
                                 Size = @Size,
                                 Status = @Status, 
                                 Stock = @Stock, 
                                 Price = @Price 
                             WHERE ProductID = @ID";

            ExecuteNonQuery(query, "T-shirt updated successfully!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProductID.Text))
            {
                MessageBox.Show("Select a product to delete.", "Error");
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete this T-shirt?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string query = "DELETE FROM TshirtsInventory WHERE ProductID = @ID";
                ExecuteNonQuery(query, "T-shirt deleted successfully!", isDelete: true);
            }
        }

        private void SetupComboBoxes()
        {
            // Preset common T-shirt options
            cmbStyleType.Items.AddRange(new object[] { "Crew-neck", "V-neck", "Polo", "Henley", "Hoodie" });
            cmbColor.Items.AddRange(new object[] { "Black", "White", "Blue", "Red", "Grey", "Green" });
            cmbSize.Items.AddRange(new object[] { "XS", "S", "M", "L", "XL", "2XL" });
            cmbStatus.Items.AddRange(new object[] { "Active", "Discontinued", "Low Stock" });

            // Set defaults if items exist
            if (cmbStyleType.Items.Count > 0) cmbStyleType.SelectedIndex = 0;
            if (cmbColor.Items.Count > 0) cmbColor.SelectedIndex = 0;
            if (cmbSize.Items.Count > 0) cmbSize.SelectedIndex = 0;
            if (cmbStatus.Items.Count > 0) cmbStatus.SelectedIndex = 0;
        }

        private void LoadData()
        {
            string query = "SELECT ProductID, ProductName, StyleType, Color, Size, Stock, Price, Status FROM TshirtsInventory";
            dgvProduct.DataSource = DbHelper.GetDataTable(query);
            // Optionally auto-size columns for better viewing
            dgvProduct.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
        private void dgvProduct_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProduct.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvProduct.SelectedRows[0];

                // Populate the detail fields from the selected row
                txtProductID.Text = row.Cells["ProductID"].Value.ToString();
                txtProductName.Text = row.Cells["ProductName"].Value.ToString();
                txtStock.Text = row.Cells["Stock"].Value.ToString();
                txtPrice.Text = row.Cells["Price"].Value.ToString();

                // New Fields
                cmbStyleType.SelectedItem = row.Cells["StyleType"].Value.ToString();
                cmbColor.SelectedItem = row.Cells["Color"].Value.ToString();
                cmbSize.SelectedItem = row.Cells["Size"].Value.ToString();
                cmbStatus.SelectedItem = row.Cells["Status"].Value.ToString();
            }
        
       }
        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtProductName.Text) ||
                !int.TryParse(txtStock.Text, out _) ||
                !decimal.TryParse(txtPrice.Text, out _) ||
                cmbStyleType.SelectedItem == null ||
                cmbColor.SelectedItem == null ||
                cmbSize.SelectedItem == null)
            {
                MessageBox.Show("Please fill all fields correctly. Stock and Price must be valid numbers.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void ExecuteNonQuery(string query, string successMessage, bool isDelete = false)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(DbHelper.ConnectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameters to prevent SQL injection
                    if (!string.IsNullOrWhiteSpace(txtProductID.Text))
                        command.Parameters.AddWithValue("@ID", int.Parse(txtProductID.Text));

                    if (!isDelete)
                    {
                        command.Parameters.AddWithValue("@Name", txtProductName.Text);
                        command.Parameters.AddWithValue("@StyleType", cmbStyleType.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@Color", cmbColor.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@Size", cmbSize.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@Status", cmbStatus.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@Stock", int.Parse(txtStock.Text));
                        command.Parameters.AddWithValue("@Price", decimal.Parse(txtPrice.Text));
                    }

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show(successMessage, "Success");
                        LoadData(); // Refresh the DataGridView
                        ClearFields();
                    }
                    else
                    {
                        MessageBox.Show("Operation failed. No rows were affected.", "Failure");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearFields()
        {
            txtProductID.Clear();
            txtProductName.Clear();
            txtStock.Clear();
            txtPrice.Clear();
            // Reset ComboBoxes to first item or blank
            if (cmbStyleType.Items.Count > 0) cmbStyleType.SelectedIndex = 0;
            if (cmbColor.Items.Count > 0) cmbColor.SelectedIndex = 0;
            if (cmbSize.Items.Count > 0) cmbSize.SelectedIndex = 0;
            if (cmbStatus.Items.Count > 0) cmbStatus.SelectedIndex = 0;
            dgvProduct.ClearSelection();
        }
    }
}
