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
    public partial class Form_Utilisateur_Ajouter : Form
    {
        public Form_Utilisateur_Ajouter()
        {
            InitializeComponent();
        }
        //********************************************
        Base_DonneeDataContext mabase = new Base_DonneeDataContext();
        BindingSource bsutilistauer = new BindingSource();
        BindingSource bsEntite = new BindingSource();
        BindingSource bsmateriel = new BindingSource();
        BindingSource bsservicecentre = new BindingSource();
        Entite et = null;
        Utilisateur uti = null;
        //********************************************


        private void Form_Utilisateur_Ajouter_Load(object sender, EventArgs e)
        {
            bsutilistauer.DataSource = mabase.Utilisateur;
            bsEntite.DataSource = mabase.Entite;
            //comboBoxUtilisateur_Entite.DataSource = from uu in mabase.Entite select uu.Entite1;
            comboBoxUtilisateur_Entite.Items.Clear();
            foreach (Entite en in mabase.Entite)
            {
                comboBoxUtilisateur_Entite.Items.Add(en.Entite1);
            }

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form_Utilisateur_Mdifier fum = new Form_Utilisateur_Mdifier();
            fum.ShowDialog();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Form_utlisateur_utli_Modifier fuum = new Form_utlisateur_utli_Modifier();
            fuum.ShowDialog();
        }



        #region Button Ajouter Entite
        private void Noveau_Entite()
        {
            textBox_codEntite_Utilisateur.Text = "";
            textBox1_Entiter_Utilisateur.Text = "";
            comboBoxUtilisateur_Entite.Items.Clear();
            foreach (Entite en in mabase.Entite)
            {
                comboBoxUtilisateur_Entite.Items.Add(en.Entite1);
            }
        }
        //********************************************
        //********************************************
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Entite ettt = new Entite();
            Boolean i=false;
            bsEntite.DataSource = mabase.Entite;
            try
            {
                foreach (Entite enn in mabase.Entite)
                {
                    if (enn.Entite1 == textBox1_Entiter_Utilisateur.Text  )
                        i = true; 
                }

                if (i == true)
                {
                    MessageBox.Show("existe deja !");
                }

                if (textBox1_Entiter_Utilisateur.Text == "") {
                    i = true;
                    MessageBox.Show("remplir tout les champs !");
                }
                if(i==false){
                bsEntite.AddNew();
                et = (Entite)bsEntite.Current;
                et.Entite1 = textBox1_Entiter_Utilisateur.Text;
                bsEntite.EndEdit();
                mabase.SubmitChanges();
                MessageBox.Show("ajouer avec succes");
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("existe déjà " + ettt.Entite1 + "  " + ettt.CodEntite + x.ToString());
            }

            Noveau_Entite();
        }
        #endregion





        private void Noveau_Utilisateur()
        {
            TxtBoxUtilisateur_Matricule.Text="";
            TxtBoxUtilisateur_Nom.Text = "";
           TxtBoxUtilisateur_Prenom.Text="";

        }

        private void Bott_Ajouter_Utilisateur_Click(object sender, EventArgs e)
        {
            Utilisateur uti = new Utilisateur();
            Boolean i = false;
            bsutilistauer.DataSource = mabase.Utilisateur;
            try
            {
                foreach (Utilisateur utii in mabase.Utilisateur)
                {
                    if (utii.Matricule == int.Parse(TxtBoxUtilisateur_Matricule.Text))
                        i = true;
                }

                if (i == true)
                {
                    MessageBox.Show("existe deja !");
                }

                if (TxtBoxUtilisateur_Matricule.Text == "")
                {
                    i = true;
                    MessageBox.Show("remplir tout les champs !");
                }
                if (i == false)
                {
                    bsutilistauer.AddNew();
                    uti = (Utilisateur)bsutilistauer.Current; 
                    uti.Matricule = int.Parse(TxtBoxUtilisateur_Matricule.Text);
                    uti.Nom = TxtBoxUtilisateur_Nom.Text;
                    uti.Prenom = TxtBoxUtilisateur_Prenom.Text;
                    bsutilistauer.EndEdit();
                    mabase.SubmitChanges();
                    MessageBox.Show("ajouer avec succes");
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("existe déjà " + uti.Matricule + "  " + uti.CodEntite + x.ToString());
            }














































           /* try
            {
            bsutilistauer.AddNew();
            uti = (Utilisateur)bsutilistauer.Current;
            var selected = from Ent in mabase.Entite where Ent.Entite1 == comboBoxUtilisateur_Entite.SelectedItem.ToString() select Ent;
            foreach (Entite en in selected)
            {
                uti.CodEntite = en.CodEntite;
            }

            
            //mabase.Utilisateur.InsertOnSubmit(uti);
            bsutilistauer.EndEdit(); // on  modifier ce truk la !!! ♥
            mabase.SubmitChanges();
            //comboBoxUtilisateur_Entite.DataSource=mabase.Entite
            }
            catch (Exception x) { MessageBox.Show("Existe Déja", " contenu", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            Noveau_Utilisateur();

            comboBoxUtilisateur_Entite.DataSource = from u in mabase.Entite select u.Entite1;*/
        
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form_Materiel_Ajouter fmj = new Form_Materiel_Ajouter();
            fmj.ShowDialog();

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        }
    }



           