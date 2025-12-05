namespace FinalProjectSystem.UserControls
{
    partial class UC_SignOut
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNoSignOut = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnYesSignout = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.btnNoSignOut);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnYesSignout);
            this.panel1.Location = new System.Drawing.Point(255, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(509, 416);
            this.panel1.TabIndex = 6;
            // 
            // btnNoSignOut
            // 
            this.btnNoSignOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnNoSignOut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNoSignOut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNoSignOut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNoSignOut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNoSignOut.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.btnNoSignOut.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNoSignOut.ForeColor = System.Drawing.Color.White;
            this.btnNoSignOut.Location = new System.Drawing.Point(267, 255);
            this.btnNoSignOut.Name = "btnNoSignOut";
            this.btnNoSignOut.Size = new System.Drawing.Size(168, 31);
            this.btnNoSignOut.TabIndex = 7;
            this.btnNoSignOut.Text = "No";
            this.btnNoSignOut.Click += new System.EventHandler(this.btnNoSignOut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Are you sure you want to sign out?";
            // 
            // btnYesSignout
            // 
            this.btnYesSignout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.btnYesSignout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnYesSignout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnYesSignout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnYesSignout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnYesSignout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.btnYesSignout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnYesSignout.ForeColor = System.Drawing.Color.White;
            this.btnYesSignout.Location = new System.Drawing.Point(78, 255);
            this.btnYesSignout.Name = "btnYesSignout";
            this.btnYesSignout.Size = new System.Drawing.Size(168, 31);
            this.btnYesSignout.TabIndex = 5;
            this.btnYesSignout.Text = "Yes";
            this.btnYesSignout.Click += new System.EventHandler(this.btnYesSignout_Click);
            // 
            // UC_SignOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "UC_SignOut";
            this.Size = new System.Drawing.Size(1017, 640);
            this.Load += new System.EventHandler(this.UC_SignOut_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnYesSignout;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnNoSignOut;
    }
}
