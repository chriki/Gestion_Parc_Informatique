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
    public partial class Form_ServiceCentre_Ajouter : Form
    {
        public Form_ServiceCentre_Ajouter()
        {
            InitializeComponent();
        }

        //********************************************
        Base_DonneeDataContext mabase = new Base_DonneeDataContext();
        BindingSource bsservicecentre = new BindingSource();
        Service_Centre serv = null;
        //********************************************

        private void pictureBox4_Click(object sender, EventArgs e)
        {

            Form_ServiceCentre_Modifier fsm = new Form_ServiceCentre_Modifier();
            fsm.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Service_Centre ser = new Service_Centre();
            Boolean i = false;
            bsservicecentre.DataSource = mabase.Service_Centre;
            try
            {
                //foreach (Service_Centre s in mabase.Service_Centre)
                //{
                //    if (s. == textBox1_Entiter_Utilisateur.Text)
                //        i = true;
                //}

                //if (i == true)
                //{
                //    MessageBox.Show("existe deja !");
                //}

                if (TxtBoxServiceCentre_ServiceCentre.Text == "")
                {
                    i = true;
                    MessageBox.Show("remplir tout les champs !");
                }

                //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                string m2t;
                if (RadBotnOui_M2t_ServiceCentre.Checked)
                    m2t = RadBotnOui_M2t_ServiceCentre.Text;
                else
                    m2t = RadBotnNon_M2t_ServiceCentre.Text;
                //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

                if (i == false)
                {
                    bsservicecentre.AddNew();
                    serv = (Service_Centre)bsservicecentre.Current;
                    serv.ServiceCentre = TxtBoxServiceCentre_ServiceCentre.Text;
                    serv.M2t = m2t;
                    bsservicecentre.EndEdit();
                    mabase.SubmitChanges();
                    MessageBox.Show("ajouer avec succes");
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("existe déjà " + ser.CodeServiceCentre + "  " + ser.ServiceCentre + x.ToString());
            }


        }

        private void Form_ServiceCentre_Ajouter_Load(object sender, EventArgs e)
        {
            comboBoxEnregistrement.Items.Clear();
            comboBoxEnregistrement.DataSource = from uu in mabase.Service_Centre select uu.ServiceCentre;
            //comboBoxEnregistrement.Items.Clear();
            //foreach (Service_Centre en in mabase.Service_Centre)
            //{
            //    comboBoxEnregistrement.Items.Add(en.ServiceCentre);
            //}
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form_Materiel_Ajouter f = new Form_Materiel_Ajouter();
            f.ShowDialog();
        }
    }
}
