namespace Gestion_Parc_Informatique
{
    partial class FormChoix
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChoix));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.utilisateurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materielleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.centreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherToutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.menuStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuStrip1.BackgroundImage")));
            this.menuStrip1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.utilisateurToolStripMenuItem,
            this.materielleToolStripMenuItem,
            this.centreToolStripMenuItem,
            this.afficherToutToolStripMenuItem,
            this.fichierToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(857, 101);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // utilisateurToolStripMenuItem
            // 
            this.utilisateurToolStripMenuItem.AutoSize = false;
            this.utilisateurToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem,
            this.afficherToolStripMenuItem});
            this.utilisateurToolStripMenuItem.Name = "utilisateurToolStripMenuItem";
            this.utilisateurToolStripMenuItem.Size = new System.Drawing.Size(120, 97);
            this.utilisateurToolStripMenuItem.Text = "Utilisateur";
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(131, 24);
            this.ajouterToolStripMenuItem.Text = "Ajouter";
            this.ajouterToolStripMenuItem.Click += new System.EventHandler(this.ajouterToolStripMenuItem_Click);
            // 
            // afficherToolStripMenuItem
            // 
            this.afficherToolStripMenuItem.Name = "afficherToolStripMenuItem";
            this.afficherToolStripMenuItem.Size = new System.Drawing.Size(131, 24);
            this.afficherToolStripMenuItem.Text = "Afficher";
            this.afficherToolStripMenuItem.Click += new System.EventHandler(this.afficherToolStripMenuItem_Click);
            // 
            // materielleToolStripMenuItem
            // 
            this.materielleToolStripMenuItem.AutoSize = false;
            this.materielleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem1,
            this.afficherToolStripMenuItem1});
            this.materielleToolStripMenuItem.Name = "materielleToolStripMenuItem";
            this.materielleToolStripMenuItem.Size = new System.Drawing.Size(94, 97);
            this.materielleToolStripMenuItem.Text = "Materielle";
            // 
            // ajouterToolStripMenuItem1
            // 
            this.ajouterToolStripMenuItem1.Name = "ajouterToolStripMenuItem1";
            this.ajouterToolStripMenuItem1.Size = new System.Drawing.Size(152, 24);
            this.ajouterToolStripMenuItem1.Text = "Ajouter";
            this.ajouterToolStripMenuItem1.Click += new System.EventHandler(this.ajouterToolStripMenuItem1_Click);
            // 
            // afficherToolStripMenuItem1
            // 
            this.afficherToolStripMenuItem1.Name = "afficherToolStripMenuItem1";
            this.afficherToolStripMenuItem1.Size = new System.Drawing.Size(152, 24);
            this.afficherToolStripMenuItem1.Text = "Afficher";
            this.afficherToolStripMenuItem1.Click += new System.EventHandler(this.afficherToolStripMenuItem1_Click);
            // 
            // centreToolStripMenuItem
            // 
            this.centreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem2,
            this.afficherToolStripMenuItem2});
            this.centreToolStripMenuItem.Name = "centreToolStripMenuItem";
            this.centreToolStripMenuItem.Size = new System.Drawing.Size(123, 97);
            this.centreToolStripMenuItem.Text = "Service & Centre";
            // 
            // ajouterToolStripMenuItem2
            // 
            this.ajouterToolStripMenuItem2.Name = "ajouterToolStripMenuItem2";
            this.ajouterToolStripMenuItem2.Size = new System.Drawing.Size(131, 24);
            this.ajouterToolStripMenuItem2.Text = "Ajouter";
            this.ajouterToolStripMenuItem2.Click += new System.EventHandler(this.ajouterToolStripMenuItem2_Click);
            // 
            // afficherToolStripMenuItem2
            // 
            this.afficherToolStripMenuItem2.Name = "afficherToolStripMenuItem2";
            this.afficherToolStripMenuItem2.Size = new System.Drawing.Size(131, 24);
            this.afficherToolStripMenuItem2.Text = "Afficher";
            this.afficherToolStripMenuItem2.Click += new System.EventHandler(this.afficherToolStripMenuItem2_Click);
            // 
            // afficherToutToolStripMenuItem
            // 
            this.afficherToutToolStripMenuItem.Name = "afficherToutToolStripMenuItem";
            this.afficherToutToolStripMenuItem.Size = new System.Drawing.Size(113, 97);
            this.afficherToutToolStripMenuItem.Text = "Afficher Tout ";
            this.afficherToutToolStripMenuItem.Click += new System.EventHandler(this.afficherToutToolStripMenuItem_Click);
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.AutoSize = false;
            this.fichierToolStripMenuItem.BackColor = System.Drawing.Color.IndianRed;
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(94, 97);
            this.fichierToolStripMenuItem.Text = "Quitter";
            this.fichierToolStripMenuItem.Click += new System.EventHandler(this.fichierToolStripMenuItem_Click);
            // 
            // FormChoix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(857, 412);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormChoix";
            this.Text = "FormChoix";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem utilisateurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materielleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem centreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afficherToutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afficherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem afficherToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem afficherToolStripMenuItem2;

    }
}