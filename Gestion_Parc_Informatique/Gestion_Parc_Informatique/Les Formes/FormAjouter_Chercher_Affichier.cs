using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gestion_Parc_Informatique
{
    public partial class FormAjouter_Chercher_Affichier : Form
    {
        public FormAjouter_Chercher_Affichier()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ajouterDesEnregistrementsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Form1 f = new Form1();
            f.ShowDialog();
        }

        private void afficherToutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_AfficherTout aft = new Form_AfficherTout();
            aft.ShowDialog();
        }

        private void affichierToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormChoix fch = new FormChoix();
            fch.ShowDialog();
        }

        private void affiUtlisateurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Utilisateur_Affichier futiAf = new Form_Utilisateur_Affichier();
            futiAf.ShowDialog();
        }

        private void affiMaterielToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Materiel_Afficher fmaf = new Form_Materiel_Afficher();
            fmaf.ShowDialog();
        }

        private void affiServiceCentreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_ServiceCentre_Afficher fsca=new Form_ServiceCentre_Afficher();
            fsca.ShowDialog();
        }
    }
}
