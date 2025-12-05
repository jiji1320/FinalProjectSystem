namespace FinalProjectSystem
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.Titlebar = new System.Windows.Forms.Panel();
            this.btnMinimize = new Guna.UI2.WinForms.Guna2Button();
            this.BtnMaximize = new Guna.UI2.WinForms.Guna2Button();
            this.BtnExit = new Guna.UI2.WinForms.Guna2Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnSignOut = new Guna.UI2.WinForms.Guna2Button();
            this.btnSalesHistory = new Guna.UI2.WinForms.Guna2Button();
            this.btnInventory = new Guna.UI2.WinForms.Guna2Button();
            this.btnProducts = new Guna.UI2.WinForms.Guna2Button();
            this.DisplayPanel = new System.Windows.Forms.Panel();
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.btnSlide = new System.Windows.Forms.PictureBox();
            this.btnDashboard = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Titlebar.SuspendLayout();
            this.panel8.SuspendLayout();
            this.MenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSlide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.Titlebar;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // Titlebar
            // 
            this.Titlebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.Titlebar.Controls.Add(this.btnMinimize);
            this.Titlebar.Controls.Add(this.BtnMaximize);
            this.Titlebar.Controls.Add(this.BtnExit);
            this.Titlebar.Controls.Add(this.btnSlide);
            this.Titlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Titlebar.Location = new System.Drawing.Point(274, 0);
            this.Titlebar.Name = "Titlebar";
            this.Titlebar.Size = new System.Drawing.Size(1013, 45);
            this.Titlebar.TabIndex = 13;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.btnMinimize.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.btnMinimize.BorderRadius = 8;
            this.btnMinimize.BorderThickness = 1;
            this.btnMinimize.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMinimize.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMinimize.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMinimize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMinimize.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.btnMinimize.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(865, 4);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(223)))), ((int)(((byte)(207)))));
            this.btnMinimize.Size = new System.Drawing.Size(52, 37);
            this.btnMinimize.TabIndex = 4;
            this.btnMinimize.Text = "−";
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click_1);
            // 
            // BtnMaximize
            // 
            this.BtnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.BtnMaximize.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.BtnMaximize.BorderRadius = 8;
            this.BtnMaximize.BorderThickness = 1;
            this.BtnMaximize.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnMaximize.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnMaximize.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnMaximize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnMaximize.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.BtnMaximize.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMaximize.ForeColor = System.Drawing.Color.White;
            this.BtnMaximize.Location = new System.Drawing.Point(912, 4);
            this.BtnMaximize.Name = "BtnMaximize";
            this.BtnMaximize.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(223)))), ((int)(((byte)(207)))));
            this.BtnMaximize.Size = new System.Drawing.Size(52, 37);
            this.BtnMaximize.TabIndex = 5;
            this.BtnMaximize.Text = "☐";
            this.BtnMaximize.Click += new System.EventHandler(this.BtnMaximize_Click_1);
            // 
            // BtnExit
            // 
            this.BtnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.BtnExit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.BtnExit.BorderRadius = 8;
            this.BtnExit.BorderThickness = 1;
            this.BtnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnExit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.BtnExit.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.ForeColor = System.Drawing.Color.White;
            this.BtnExit.Location = new System.Drawing.Point(961, 3);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.PressedColor = System.Drawing.Color.Red;
            this.BtnExit.Size = new System.Drawing.Size(52, 37);
            this.BtnExit.TabIndex = 6;
            this.BtnExit.Text = "X";
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.panel8.Controls.Add(this.btnDashboard);
            this.panel8.Controls.Add(this.btnSignOut);
            this.panel8.Controls.Add(this.btnSalesHistory);
            this.panel8.Controls.Add(this.btnInventory);
            this.panel8.Controls.Add(this.btnProducts);
            this.panel8.Location = new System.Drawing.Point(0, 117);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(274, 673);
            this.panel8.TabIndex = 11;
            // 
            // btnSignOut
            // 
            this.btnSignOut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSignOut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSignOut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSignOut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSignOut.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.btnSignOut.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignOut.ForeColor = System.Drawing.Color.White;
            this.btnSignOut.Location = new System.Drawing.Point(3, 283);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(223)))), ((int)(((byte)(207)))));
            this.btnSignOut.Size = new System.Drawing.Size(265, 64);
            this.btnSignOut.TabIndex = 9;
            this.btnSignOut.Text = "Sign Out";
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // btnSalesHistory
            // 
            this.btnSalesHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.btnSalesHistory.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSalesHistory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSalesHistory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSalesHistory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSalesHistory.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.btnSalesHistory.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalesHistory.ForeColor = System.Drawing.Color.White;
            this.btnSalesHistory.Location = new System.Drawing.Point(6, 73);
            this.btnSalesHistory.Name = "btnSalesHistory";
            this.btnSalesHistory.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(223)))), ((int)(((byte)(207)))));
            this.btnSalesHistory.Size = new System.Drawing.Size(265, 64);
            this.btnSalesHistory.TabIndex = 4;
            this.btnSalesHistory.Text = "Sales History";
            this.btnSalesHistory.Click += new System.EventHandler(this.btnSalesHistory_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnInventory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnInventory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnInventory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnInventory.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.btnInventory.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventory.ForeColor = System.Drawing.Color.White;
            this.btnInventory.Location = new System.Drawing.Point(6, 213);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(223)))), ((int)(((byte)(207)))));
            this.btnInventory.Size = new System.Drawing.Size(265, 64);
            this.btnInventory.TabIndex = 8;
            this.btnInventory.Text = "Inventory";
            this.btnInventory.Click += new System.EventHandler(this.btnMaterials_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnProducts.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnProducts.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnProducts.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnProducts.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.btnProducts.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducts.ForeColor = System.Drawing.Color.White;
            this.btnProducts.Location = new System.Drawing.Point(6, 143);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(223)))), ((int)(((byte)(207)))));
            this.btnProducts.Size = new System.Drawing.Size(268, 64);
            this.btnProducts.TabIndex = 5;
            this.btnProducts.Text = "Products";
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // DisplayPanel
            // 
            this.DisplayPanel.Location = new System.Drawing.Point(274, 44);
            this.DisplayPanel.Name = "DisplayPanel";
            this.DisplayPanel.Size = new System.Drawing.Size(1014, 644);
            this.DisplayPanel.TabIndex = 12;
            // 
            // MenuVertical
            // 
            this.MenuVertical.Controls.Add(this.panel8);
            this.MenuVertical.Controls.Add(this.pictureBox1);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 0);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(274, 687);
            this.MenuVertical.TabIndex = 12;
            // 
            // btnSlide
            // 
            this.btnSlide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.btnSlide.Image = global::FinalProjectSystem.Properties.Resources.align_justify_svgrepo_com;
            this.btnSlide.Location = new System.Drawing.Point(3, 3);
            this.btnSlide.Name = "btnSlide";
            this.btnSlide.Size = new System.Drawing.Size(48, 38);
            this.btnSlide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSlide.TabIndex = 2;
            this.btnSlide.TabStop = false;
            this.btnSlide.Click += new System.EventHandler(this.btnSlide_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.btnDashboard.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDashboard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDashboard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDashboard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDashboard.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Image = global::FinalProjectSystem.Properties.Resources.column_white;
            this.btnDashboard.Location = new System.Drawing.Point(3, 3);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(223)))), ((int)(((byte)(207)))));
            this.btnDashboard.Size = new System.Drawing.Size(268, 64);
            this.btnDashboard.TabIndex = 2;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.pictureBox1.Image = global::FinalProjectSystem.Properties.Resources.Designer__1_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(274, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 687);
            this.Controls.Add(this.Titlebar);
            this.Controls.Add(this.MenuVertical);
            this.Controls.Add(this.DisplayPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Main_Load);
            this.Titlebar.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.MenuVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnSlide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel8;
        private Guna.UI2.WinForms.Guna2Button btnDashboard;
        private Guna.UI2.WinForms.Guna2Button btnSignOut;
        private Guna.UI2.WinForms.Guna2Button btnSalesHistory;
        private Guna.UI2.WinForms.Guna2Button btnInventory;
        private Guna.UI2.WinForms.Guna2Button btnProducts;
        private System.Windows.Forms.Panel DisplayPanel;
        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.Panel Titlebar;
        private Guna.UI2.WinForms.Guna2Button btnMinimize;
        private Guna.UI2.WinForms.Guna2Button BtnMaximize;
        private Guna.UI2.WinForms.Guna2Button BtnExit;
        private System.Windows.Forms.PictureBox btnSlide;
    }
}