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
    public partial class Form_Utilisateur_Affichier : Form
    {

        //********************************************
        Base_DonneeDataContext mabase = new Base_DonneeDataContext();
        BindingSource bsutilistauer = new BindingSource();
        BindingSource bsEntite = new BindingSource();
        BindingSource bsmateriel = new BindingSource();
        BindingSource bsservicecentre = new BindingSource();
        Entite et = null;
        //********************************************
        public Form_Utilisateur_Affichier()
        {
            InitializeComponent();
        }

        //private void Afficher_Entiter()
        //{
        //    dataGridViewAfficher_Utilisateur.Rows.Clear();
        //   // var list = from u in mabase.Entite select u;
        //    foreach (Entite uu in mabase.Entite)
        //    {
        //        dataGridViewAfficher_Utilisateur.Rows.Add(uu.Entite1);
        //    }
        //}
        private void AfficherUtilisateur()
        {
            dataGridViewAfficher_Utilisateur.Rows.Clear();
            //var list = from u in mabase.Utilisateur select u;
            foreach (Utilisateur u in mabase.Utilisateur)
            {
                dataGridViewAfficher_Utilisateur.Rows.Add(u.Entite,u.Matricule,u.Nom,u.Prenom);
            }
        }

        private void Form_Utilisateur_Affichier_Load(object sender, EventArgs e)
        {
            //Afficher_Entiter();
            AfficherUtilisateur();
           
        }
    }
}
