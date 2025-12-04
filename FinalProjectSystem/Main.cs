using FinalProjectSystem.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectSystem
{
    public partial class Main : Form
    {

        public Main()
        {
            InitializeComponent();

        }
        
        public void LoadUC(UserControl uc)
        {
            uc.Show();
            DisplayPanel.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            DisplayPanel.Controls.Add(uc);

        }
        public void LoadUc(UserControl uc)
        {
            uc.Show();
            DisplayPanel.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            DisplayPanel.Controls.Add(uc);

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnSlide_Click_1(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 200)
            {
                MenuVertical.Width = 35;
            }
            else
            {
                MenuVertical.Width = 200;
            }
        }

        private void btnDashboard_Click_1(object sender, EventArgs e)
        {
            instance.id = new UC_Dashboard();
            LoadUC(instance.id);
        }

        private void btnMyProfile_Click(object sender, EventArgs e)
        {
            instance.MP = new UC_MyProfile();
            LoadUc(instance.MP);
        }

        private void btnSlide_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 205)
            {
                MenuVertical.Width = 35;
            }
            else
            {
                MenuVertical.Width = 205;
            }
        }

        private void BtnMaximize_Click_1(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnMinimize_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSalesHistory_Click(object sender, EventArgs e)
        {
            instance.SH = new UC_SalesHistory();
            LoadUc(instance.SH);
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            instance.P = new UC_Products();
            LoadUc(instance.P);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            instance.Rep = new UC_Reports();
            LoadUc(instance.Rep);
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            instance.Cust = new UC_Customers();
            LoadUc(instance.Cust);

        }

        private void btnMaterials_Click(object sender, EventArgs e)
        {
            instance.Mat = new UC_Materials();
            LoadUc(instance.Mat);
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            instance.SO = new UC_SignOut();
            LoadUc(instance.SO);
        }
        
  

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }

