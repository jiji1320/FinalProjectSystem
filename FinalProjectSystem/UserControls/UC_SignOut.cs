using System;
using System.Linq;
using System.Windows.Forms;

namespace FinalProjectSystem.UserControls
{
    public partial class UC_SignOut : UserControl
    {
        
        

        public UC_SignOut()
        {
            InitializeComponent();
        }

        private void UC_SignOut_Load(object sender, EventArgs e)
        {
        }

        private void btnYesSignout_Click(object sender, EventArgs e)
        {
            try
            {
               
                var login = new FinalProjectSystem.Login();
                login.Show();

                
                var hostForm = this.FindForm();
                if (hostForm != null)
                {
                    hostForm.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error signing out: {ex.Message}", "Sign out error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static UC_SignOut GetInstance { get; } = new UC_SignOut();
        private void btnNoSignOut_Click(object sender, EventArgs e)
        {
          
            try
            {
                
                var hostForm = this.FindForm();
                if (hostForm == null)
                {
                    MessageBox.Show("Cannot find the host form.", "Navigation error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                
                Panel container = hostForm.Controls.Find("panel2", true).FirstOrDefault() as Panel;

                
                if (container == null)
                {
                    Control p = this.Parent;
                    while (p != null && !(p is Panel))
                        p = p.Parent;
                    container = p as Panel;
                }

                if (container == null)
                {
                    MessageBox.Show("Unable to find the host container to navigate back to Dashboard.", "Navigation error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                
                FinalProjectSystem.UserControls.UC_Dashboard dashboardInstance = null;
                try
                {
                    dashboardInstance = FinalProjectSystem.UserControls.UC_Dashboard.GetInstance;
                }
                catch
                {
                    
                }

                if (dashboardInstance == null)
                {
                    dashboardInstance = new FinalProjectSystem.UserControls.UC_Dashboard();
                }

               
                if (!container.Controls.Contains(dashboardInstance))
                {
                    container.Controls.Add(dashboardInstance);
                    dashboardInstance.Dock = DockStyle.Fill;
                }

                dashboardInstance.BringToFront();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Navigation failed: {ex.Message}", "Navigation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
            
    }
    }
