using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

namespace WinFormsADO
{
    public partial class FicheAuteur : Form
    {
        private MySqlCommand maRequete;
        private MySqlDataReader monReader;
        private int numAuteur;

        public FicheAuteur(bool type, int num)
        {
            InitializeComponent();

            numAuteur = num;

            try
            {
                Connection.MaConnection.Open();

                maRequete = Connection.MaConnection.CreateCommand();
                maRequete.CommandText = "select * from auteur where num=@paramNum";
                maRequete.Parameters.AddWithValue("@paramNum", num);
                maRequete.Prepare();

                monReader = maRequete.ExecuteReader();

                if (monReader.Read())
                {
                    txt_Num.Text = num.ToString();
                    txt_Nom.Text = monReader["nom"].ToString();
                    txt_Prenom.Text = monReader["prenom"].ToString();
                    txt_Nationalite.Text = monReader["nationalite"].ToString();
                }
                else
                {
                    MessageBox.Show("Erreur : Auteur introuvable");
                }

                if (type == false)
                {
                    txt_Nom.Enabled = false;
                    txt_Prenom.Enabled = false;
                    txt_Nationalite.Enabled = false;
                    btn_Valider.Visible = false;
                    btn_Annuler.Text = "Fermer";
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                monReader.Close();
                Connection.MaConnection.Close();
            }
        }

        private void btn_Annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Valider_Click(object sender, EventArgs e)
        {
            if(ControleSaisies() == true)
            {
                maRequete.CommandText = "update auteur set " +
                    "nom=@paramNom, prenom=@paramPrenom, nationalite=@paramNationalite where num=@paramNum";
                maRequete.Parameters.Clear();
                maRequete.Parameters.AddWithValue("@paramNom", txt_Nom.Text);
                maRequete.Parameters.AddWithValue("@paramPrenom", txt_Prenom.Text);
                maRequete.Parameters.AddWithValue("@paramNationalite", txt_Nationalite.Text);
                maRequete.Parameters.AddWithValue("@paramNum", numAuteur);

                try
                {
                    Connection.MaConnection.Open();
                    int resultat = maRequete.ExecuteNonQuery();

                    if (resultat > 0)
                    {
                        MessageBox.Show("L'auteur à bien été mis à jour.");
                    }
                    else
                    {
                        MessageBox.Show("Erreur : L'auteur n'a pas été mis à jour.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    Connection.MaConnection.Close();
                    this.Close();
                }
            }
        }

        private bool ControleSaisies()
        {
            bool controle = true;
            if(txt_Nom.Text == "")
            {
                MessageBox.Show("Vous devez saisir un nom");
                controle = false;
            }
            if(txt_Prenom.Text == "")
            {
                MessageBox.Show("Vous devez saisir un prénom");
                controle = false;
            }
            if(txt_Nationalite.Text == "")
            {
                MessageBox.Show("Vous devez saisir une nationalité");
                controle = false;
            }
            return controle;
        }
    }
}
