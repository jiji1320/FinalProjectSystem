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
        private static UC_Dashboard instance;

        public static UC_Dashboard Instance
        {
            get
            {
                if (instance == null)
                    instance = new UC_Dashboard();
                return instance;
            }
        }


        public UC_Dashboard()
        {
            InitializeComponent();
        }

        private void UC_Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        private void btnDashboard_Click(object sender, EventArgs e)
        {

        }

        private void btnMyProfile_Click(object sender, EventArgs e)
        {

        }

        private void btnSlide_Click(object sender, EventArgs e)
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

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnMaximize_Click(object sender, EventArgs e)
        {
           
        }
    }
}
