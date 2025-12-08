namespace FinalProjectSystem.UserControls
{
    partial class UC_Products
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
            this.panelLists = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.productListItem1 = new FinalProjectSystem.UserControls.Components.ProductListItem();
            this.panelLists.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLists
            // 
            this.panelLists.Controls.Add(this.productListItem1);
            this.panelLists.Location = new System.Drawing.Point(16, 71);
            this.panelLists.Name = "panelLists";
            this.panelLists.Size = new System.Drawing.Size(974, 584);
            this.panelLists.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "STOCKS";
            // 
            // productListItem1
            // 
            this.productListItem1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.productListItem1.Location = new System.Drawing.Point(642, 123);
            this.productListItem1.Name = "productListItem1";
            this.productListItem1.Size = new System.Drawing.Size(300, 366);
            this.productListItem1.TabIndex = 0;
            this.productListItem1.Load += new System.EventHandler(this.productListItem1_Load);
            // 
            // UC_Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelLists);
            this.Name = "UC_Products";
            this.Size = new System.Drawing.Size(1017, 640);
            this.Load += new System.EventHandler(this.UC_Products_Load);
            this.panelLists.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Components.ProductListItem productListItem1;
        private System.Windows.Forms.Panel panelLists;
        private System.Windows.Forms.Label label1;
    }
}
