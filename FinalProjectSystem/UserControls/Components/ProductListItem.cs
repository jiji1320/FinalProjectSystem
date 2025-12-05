using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectSystem.UserControls.Components
{
    public partial class ProductListItem : UserControl
    {

        private string productName;
        private string styleType;
        private string color;
        private string size;
        private int price;

        public ProductListItem()
        {
            InitializeComponent();
        }

        public void SetProductDetails(string productName, string styleType, string color, string size, int price)
        {
            this.productName = productName;
            this.styleType = styleType;
            this.color = color;
            this.size = size;
            this.price = price;
            lblProductName.Text = productName;
            //lblStyleType.Text = styleType;
            //lblColor.Text = color;
            //lblSize.Text = size;
            //lblPrice.Text = price.ToString("C");
        }

        //public void SetProductData(dynamic product)
        //{
        //    productData = product;

        //    lblProductName.Text = product["ProductName"];
        //}

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var productConfirm = new ProductConfirm();
            productConfirm.SetProductDetails(productName, styleType, size, color, price);
            productConfirm.ShowDialog();
        }
    }
}
