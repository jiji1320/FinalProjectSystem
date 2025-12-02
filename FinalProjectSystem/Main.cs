using FinalProjectSystem.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            panel2.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panel2.Controls.Add(uc);

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
            WindowState = FormWindowState.Minimized;
        }

        private void BtnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            LoadUC(UC_Dashboard.Instance);

        }

        private void btnMyProfile_Click(object sender, EventArgs e)
        {
            LoadUC(UC_MyProfile.Instance);
        }
    }
}
