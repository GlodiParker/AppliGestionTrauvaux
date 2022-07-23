using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AppliGestionTrauvaux
{
    public partial class parkerFrmMenu : Form
    {
        public parkerFrmMenu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ucEtudiant.BringToFront();
            ucEtudiant.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ucEncadreur.BringToFront();
            ucEncadreur.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ucEncadreur.Visible = false;
            ucEtudiant.Visible = false;

            Encadreur encc = new Encadreur();
            encc.RecCom(this);
            encc.RecInfor(this);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
