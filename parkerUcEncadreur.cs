using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AppliGestionTrauvaux
{
    public partial class parkerUcEncadreur : UserControl
    {
        Encadreur enc = new Encadreur();

        string code;
        string nom;
        string prenom;
        string grade;
        string telephone;
        public parkerUcEncadreur()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            code = txtcode.Text;
            nom = txtnom.Text.ToUpper();
            prenom = txtprenom.Text.ToUpper();
            grade = cbograde.Text;
            telephone = txtphone.Text;

            enc.Enregistrer(code, nom, prenom, grade, telephone);
            Effacer();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            code = txtcode.Text;

            enc.Supprimer(code);
            Effacer();
        }

        private void parkerUcEncadreur_Load(object sender, EventArgs e)
        {

        }
        public void Effacer()
        {
            txtcode.Text = "";
            txtnom.Text = "";
            txtprenom.Text = "";
            cbograde.Text = "------CHOIX-------";
            txtphone.Text = "";
            txtcode.Focus();
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            code = txtcode.Text;
            enc.Rechercher(this, code);
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            code = txtcode.Text;
            nom = txtnom.Text.ToUpper();
            prenom = txtprenom.Text.ToUpper();
            grade = cbograde.Text;
            telephone = txtphone.Text;

            enc.Modifier(code, nom, prenom, grade, telephone);
            Effacer();
        }
    }
}
