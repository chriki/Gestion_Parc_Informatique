namespace Gestion_Parc_Informatique
{
    partial class Form_ServiceCentre_Afficher
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
            this.dataGridView_ServiceCentre = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ServiceCentre)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_ServiceCentre
            // 
            this.dataGridView_ServiceCentre.AllowUserToAddRows = false;
            this.dataGridView_ServiceCentre.AllowUserToDeleteRows = false;
            this.dataGridView_ServiceCentre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ServiceCentre.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView_ServiceCentre.Location = new System.Drawing.Point(22, 36);
            this.dataGridView_ServiceCentre.Name = "dataGridView_ServiceCentre";
            this.dataGridView_ServiceCentre.ReadOnly = true;
            this.dataGridView_ServiceCentre.Size = new System.Drawing.Size(297, 169);
            this.dataGridView_ServiceCentre.TabIndex = 61;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Service & Centre";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "M2T";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Form_ServiceCentre_Afficher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 232);
            this.Controls.Add(this.dataGridView_ServiceCentre);
            this.Name = "Form_ServiceCentre_Afficher";
            this.Text = "Form_ServiceCentre_Afficher";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ServiceCentre)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_ServiceCentre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}