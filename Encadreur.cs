using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AppliGestionTrauvaux
{
   public class Encadreur
    {
        //Attributs
        private string chaine = "server=DESKTOP-E2LOPHB\\MAKABA_SERVER;User Id=sa;pwd=genie;database=bdTravauxISIPA";


        //Méthodes
        public void Enregistrer(string code,string nom,string prenom,string grade,string telephone)
        {
            SqlConnection con = new SqlConnection(chaine);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into Encadreur values('"+code+"','"+nom+"','"+prenom+"','"+grade+"','"+telephone+"')";

            try
            {
                con.Open();
                int n=cmd.ExecuteNonQuery();

                if (n == 1)
                    MessageBox.Show("Encadreur " + nom + " est enregistré avec succès!","Confirmation");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur survenue: "+ex);
            }
        }

        public void Supprimer(string code)
        {
            SqlConnection con = new SqlConnection(chaine);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "delete from Encadreur where codeEnc='"+code+"'";

            try
            {
                con.Open();
                int n = cmd.ExecuteNonQuery();

                if (n == 1)
                    MessageBox.Show("Cet Encadreur est supprimé avec succès!", "Confirmation");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur survenue: " + ex);
            }
        }

        public void Rechercher(parkerUcEncadreur frm,string code)
        {
            SqlConnection con = new SqlConnection(chaine);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from Encadreur where codeEnc='" + code + "'";

            try
            {
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    frm.txtcode.Text=dr.GetValue(0).ToString();
                    frm.txtnom.Text = dr.GetValue(1).ToString();
                    frm.txtprenom.Text = dr.GetValue(2).ToString();
                    frm.cbograde.Text = dr.GetValue(3).ToString();
                    frm.txtphone.Text = dr.GetValue(4).ToString();
                }
                dr.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur survenue: " + ex);
            }
        }

        public void Modifier(string code, string nom, string prenom, string grade, string telephone)
        {
            SqlConnection con = new SqlConnection(chaine);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "update Encadreur set nom='"+nom+ "',prenom='" + prenom + "',grade='" + grade + "',telephone='" + telephone + "' where codeenc='"+code+"'";

            try
            {
                con.Open();
                int n = cmd.ExecuteNonQuery();

                if (n == 1)
                    MessageBox.Show("Les information de l'Encadreur " + nom + " sont mises à jour avec succès!", "Confirmation");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur survenue: " + ex);
            }
        }





        public void RecInfor(parkerFrmMenu frm)
        {
            SqlConnection con = new SqlConnection(chaine);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select COUNT(codeTravail) as Nbre from TravauxAcad where Domaine='INFORMATIQUE'";

            try
            {
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                     frm.pbinfo.Value=int.Parse(dr.GetValue(0).ToString());

                }
                dr.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur survenue: " + ex);
               
            }
        }

        public void RecCom(parkerFrmMenu frm)
        {
            SqlConnection con = new SqlConnection(chaine);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select COUNT(codeTravail) as Nbre from TravauxAcad where Domaine='COMMERCIALE'";

            try
            {
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    frm.pbcom.Value = int.Parse(dr.GetValue(0).ToString());

                }
                dr.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur survenue: " + ex);
                
            }
        }


    }
}
