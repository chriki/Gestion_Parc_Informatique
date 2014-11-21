namespace Gestion_Parc_Informatique
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBoModePasse = new System.Windows.Forms.TextBox();
            this.buttonEntrer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "entrez votre mot de passe ";
            // 
            // textBoModePasse
            // 
            this.textBoModePasse.Location = new System.Drawing.Point(150, 21);
            this.textBoModePasse.Name = "textBoModePasse";
            this.textBoModePasse.Size = new System.Drawing.Size(138, 20);
            this.textBoModePasse.TabIndex = 1;
            // 
            // buttonEntrer
            // 
            this.buttonEntrer.Location = new System.Drawing.Point(300, 18);
            this.buttonEntrer.Name = "buttonEntrer";
            this.buttonEntrer.Size = new System.Drawing.Size(79, 23);
            this.buttonEntrer.TabIndex = 2;
            this.buttonEntrer.Text = "Entrer";
            this.buttonEntrer.UseVisualStyleBackColor = true;
            this.buttonEntrer.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 61);
            this.Controls.Add(this.buttonEntrer);
            this.Controls.Add(this.textBoModePasse);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoModePasse;
        private System.Windows.Forms.Button buttonEntrer;
    }
}

