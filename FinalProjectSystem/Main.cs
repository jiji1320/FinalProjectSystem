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

        private static Main _instance = new Main();

        public Main()
        {
            InitializeComponent();

        }

        public static Main Instance
        {
            get
            {
                return _instance;
            }
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
            btnDashboard_Click_1(null, null);
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

        public void btnSalesHistory_Click(object sender, EventArgs e)
        {
            instance.SH = new UC_SalesHistory();
            LoadUc(instance.SH);
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            instance.P = new UC_Products();
            LoadUc(instance.P);
        }

        private void btnMaterials_Click(object sender, EventArgs e)
        {
            instance.Mat = new UC_Inventory();
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

