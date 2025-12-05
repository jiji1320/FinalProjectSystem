namespace FinalProjectSystem.UserControls
{
    partial class UC_SalesHistory
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
            this.dgvLists = new System.Windows.Forms.DataGridView();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StyleType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLists)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLists
            // 
            this.dgvLists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLists.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductName,
            this.StyleType,
            this.Color,
            this.Size,
            this.Quantity});
            this.dgvLists.Location = new System.Drawing.Point(65, 74);
            this.dgvLists.Name = "dgvLists";
            this.dgvLists.RowHeadersWidth = 51;
            this.dgvLists.RowTemplate.Height = 24;
            this.dgvLists.Size = new System.Drawing.Size(705, 472);
            this.dgvLists.TabIndex = 0;
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.MinimumWidth = 6;
            this.ProductName.Name = "ProductName";
            this.ProductName.Width = 125;
            // 
            // StyleType
            // 
            this.StyleType.HeaderText = "Style Type";
            this.StyleType.MinimumWidth = 6;
            this.StyleType.Name = "StyleType";
            this.StyleType.Width = 125;
            // 
            // Color
            // 
            this.Color.HeaderText = "Color";
            this.Color.MinimumWidth = 6;
            this.Color.Name = "Color";
            this.Color.Width = 125;
            // 
            // Size
            // 
            this.Size.HeaderText = "Size";
            this.Size.MinimumWidth = 6;
            this.Size.Name = "Size";
            this.Size.Width = 125;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 125;
            // 
            // UC_SalesHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.dgvLists);
            this.Name = "UC_SalesHistory";
            //this.Size = new System.Drawing.Size(1017, 640);
            this.Load += new System.EventHandler(this.UC_SalesHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLists)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLists;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StyleType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color;
        private System.Windows.Forms.DataGridViewTextBoxColumn Size;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
    }
}
