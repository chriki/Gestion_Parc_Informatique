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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoModePasse.Text == "123456")
            {
                FormAjouter_Chercher_Affichier f = new FormAjouter_Chercher_Affichier();
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Code invalide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
