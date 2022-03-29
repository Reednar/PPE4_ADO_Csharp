using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PPE4_ADO_Csharp
{
    public partial class Form_ListeAuteurs : Form
    {
        private string connectionString = "server=serverbtssiojv.ddns.net;port=3306;Database=lepie_ado;Uid=lepie;password=lepie"; // Pour la bdd
        private MySqlConnection maConnection;
        private MySqlCommand maRequete;
        private MySqlDataReader monReader;

        public Form_ListeAuteurs()
        {
            InitializeComponent();
            RemplirListe(); // Remplie la liste des auteurs
        }

        private void RemplirListe() // Permet de remplir la liste des auteurs
        {
            try
            {
                dgv_ListeAuteurs.Rows.Clear();
                Connection.MaConnection.Open(); // connexion a la bdd
                maRequete = maConnection.CreateCommand(); // Pour faire une requete
                maRequete.CommandText = "select * from auteur order by nom"; // Requete sql
                monReader = maRequete.ExecuteReader(); // Permet d'executer la requete
                while (monReader.Read()) // Tant qu'il lis quelque chose
                {
                    dgv_ListeAuteurs.Rows.Add( // Ajoute une ligne pour chaque auteur qu'il trouve
                        monReader["num"].ToString(),
                        monReader["nom"].ToString(),
                        monReader["prenom"].ToString(),
                        monReader["nationalite"].ToString()
                        );
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erreur : " + ex.Message);
            }
            finally
            {
                monReader.Close();
                maConnection.Close(); // Ferme la connexion
            }
        }

        private void btn_Afficher_Click(object sender, EventArgs e)
        {
            int element = Convert.ToInt16(dgv_ListeAuteurs.SelectedRows[0].Cells[0].Value.ToString()); // Recupère le num de la ligne qui a été cliquer
            FicheAuteur frm = new FicheAuteur(false, element);
            frm.Show();
        }

        private void btn_Modifier_Click(object sender, EventArgs e)
        {
            int element = Convert.ToInt16(dgv_ListeAuteurs.SelectedRows[0].Cells[0].Value.ToString()); // Recupère le num de la ligne qui a été cliquer
            FicheAuteur frm = new FicheAuteur(true, element);
            frm.Show();
        }
    }
}
