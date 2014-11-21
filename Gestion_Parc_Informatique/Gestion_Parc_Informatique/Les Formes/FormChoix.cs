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
    public partial class FormChoix : Form
    {
        public FormChoix()
        {
            InitializeComponent();
        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Utilisateur_Ajouter fAj = new Form_Utilisateur_Ajouter();
            fAj.ShowDialog();
        }

        private void afficherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Utilisateur_Affichier fAj = new Form_Utilisateur_Affichier();
            fAj.ShowDialog();
        }

        private void ajouterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form_Materiel_Ajouter Fmj = new Form_Materiel_Ajouter();
            Fmj.ShowDialog();
        }

        private void afficherToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form_Materiel_Afficher fmf = new Form_Materiel_Afficher();
            fmf.ShowDialog();
        }

        private void ajouterToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form_ServiceCentre_Ajouter fSC = new Form_ServiceCentre_Ajouter();
            fSC.ShowDialog();
        }

        private void afficherToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form_ServiceCentre_Afficher fsc = new Form_ServiceCentre_Afficher();
            fsc.ShowDialog();
        }

        private void afficherToutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_AfficherTout fft = new Form_AfficherTout();
            fft.ShowDialog();
        }

        private void fichierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
