namespace Gestion_Parc_Informatique
{
    partial class Form_Utilisateur_Affichier
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
            this.dataGridViewAfficher_Utilisateur = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAfficher_Utilisateur)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAfficher_Utilisateur
            // 
            this.dataGridViewAfficher_Utilisateur.AllowUserToAddRows = false;
            this.dataGridViewAfficher_Utilisateur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAfficher_Utilisateur.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridViewAfficher_Utilisateur.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewAfficher_Utilisateur.Name = "dataGridViewAfficher_Utilisateur";
            this.dataGridViewAfficher_Utilisateur.Size = new System.Drawing.Size(444, 207);
            this.dataGridViewAfficher_Utilisateur.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Entite";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Matricul";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Nom";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Prenom";
            this.Column4.Name = "Column4";
            // 
            // Form_Utilisateur_Affichier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(476, 330);
            this.Controls.Add(this.dataGridViewAfficher_Utilisateur);
            this.Name = "Form_Utilisateur_Affichier";
            this.Text = "Form_Utilisateur_Affichier";
            this.Load += new System.EventHandler(this.Form_Utilisateur_Affichier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAfficher_Utilisateur)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAfficher_Utilisateur;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}