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
    public partial class UC_MyProfile : UserControl
    {
        private static UC_MyProfile _instance;
        public static UC_MyProfile Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_MyProfile();
                return _instance;
            }
        }
        public UC_MyProfile()
        {
            InitializeComponent();
        }

        private void UC_MyProfile_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
