namespace FinalProjectSystem.UserControls
{
    partial class UC_MyProfile
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
            this.DisplaypanelMP = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DisplaypanelMP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // DisplaypanelMP
            // 
            this.DisplaypanelMP.Controls.Add(this.dataGridView1);
            this.DisplaypanelMP.Location = new System.Drawing.Point(6, 3);
            this.DisplaypanelMP.Name = "DisplaypanelMP";
            this.DisplaypanelMP.Size = new System.Drawing.Size(1278, 615);
            this.DisplaypanelMP.TabIndex = 18;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-10, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1285, 506);
            this.dataGridView1.TabIndex = 0;
            // 
            // UC_MyProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DisplaypanelMP);
            this.Name = "UC_MyProfile";
            this.Size = new System.Drawing.Size(1287, 687);
            this.Load += new System.EventHandler(this.UC_MyProfile_Load);
            this.DisplaypanelMP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel DisplaypanelMP;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
