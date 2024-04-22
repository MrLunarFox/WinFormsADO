using MySql.Data.MySqlClient;
using System.Data.Common;

namespace WinFormsADO
{
    public partial class Form_ListeAuteur : Form
    {
        private MySqlCommand maRequete;
        private MySqlDataReader monReader;

        public Form_ListeAuteur()
        {
            InitializeComponent();
            RemplirListe();
        }
        private void RemplirListe()
        {
            try
            {
                dgv_ListeAuteur.Rows.Clear();
                Connection.MaConnection.Open();

                maRequete = Connection.MaConnection.CreateCommand();
                maRequete.CommandText = "select * from auteur order by nom";

                monReader = maRequete.ExecuteReader();

                while (monReader.Read())
                {
                    dgv_ListeAuteur.Rows.Add(
                        monReader["num"].ToString(),
                        monReader["nom"].ToString(),
                        monReader["prenom"].ToString(),
                        monReader["nationalite"].ToString()
                        );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur :" + ex.Message);
            }
            finally
            {
                monReader.Close();
                Connection.MaConnection.Close();
            }
        }

        private void btn_afficher_Click(object sender, EventArgs e)
        {
            int element = Convert.ToInt16(dgv_ListeAuteur.SelectedRows[0].Cells[0].Value.ToString());
            FicheAuteur frm = new FicheAuteur(false, element);
            frm.Show();
        }

        private void btn_modifier_Click(object sender, EventArgs e)
        {
            int element = Convert.ToInt16(dgv_ListeAuteur.SelectedRows[0].Cells[0].Value.ToString());
            FicheAuteur frm = new FicheAuteur(true, element);
            frm.Show();
            RemplirListe();
            dgv_ListeAuteur.Refresh();
        }
    }
}