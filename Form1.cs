using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppliGestionTrauvaux
{
    public partial class Form1 : Form
    {
        Encadreur enc = new Encadreur();

        string code;
        string nom ;
        string prenom;
        string grade;
        string telephone;

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
            //enc.Rechercher(this, code);
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
