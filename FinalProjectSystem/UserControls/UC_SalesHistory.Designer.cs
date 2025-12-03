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
            this.DisplaypanelSH = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.DisplaypanelSH.SuspendLayout();
            this.SuspendLayout();
            // 
            // DisplaypanelSH
            // 
            this.DisplaypanelSH.Controls.Add(this.label1);
            this.DisplaypanelSH.Location = new System.Drawing.Point(67, 3);
            this.DisplaypanelSH.Name = "DisplaypanelSH";
            this.DisplaypanelSH.Size = new System.Drawing.Size(1162, 491);
            this.DisplaypanelSH.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(479, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "SAMPLE";
            // 
            // UC_SalesHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DisplaypanelSH);
            this.Name = "UC_SalesHistory";
            this.Size = new System.Drawing.Size(1287, 687);
            this.DisplaypanelSH.ResumeLayout(false);
            this.DisplaypanelSH.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel DisplaypanelSH;
        private System.Windows.Forms.Label label1;
    }
}
