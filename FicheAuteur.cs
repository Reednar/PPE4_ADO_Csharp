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
    public partial class FicheAuteur : Form
    {
        private MySqlCommand maRequete;
        private MySqlDataReader monReader;
        private int numAuteur;

        public FicheAuteur(bool modification, int numero)
        {
            InitializeComponent();
            numAuteur = numero;
            RemplirComboNationalite();
            try
            {
                Connection.MaConnection.Open(); // Ouvre la connexion
                maRequete = Connection.MaConnection.CreateCommand(); // Pour faire une requete
                maRequete.CommandText = "select a.nom, a.prenom, a.num, a.nationalite from auteur a where a.num="+numero+""; // Requete sql
                maRequete.Prepare(); // Prepare la requete
                maRequete.Parameters.AddWithValue("@paramNum", numero); // Ajoute le parametre num
                monReader = maRequete.ExecuteReader();

                if (monReader.Read())
                {
                    tb_Num.Text = numero.ToString();
                    tb_Nom.Text = monReader["nom"].ToString();
                    tb_Prenom.Text = monReader["prenom"].ToString();
                    cb_Nation.Text = monReader["nationalite"].ToString();
                }
                else
                {
                    MessageBox.Show("Erreur : L'auteur n'a pas été trouvé");
                }

                if (modification == false)
                {
                    tb_Nom.Enabled = false;
                    tb_Prenom.Enabled = false;
                    cb_Nation.Enabled = false;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erreur : " + ex.Message);
            }
            finally
            {
                monReader.Close();
                Connection.MaConnection.Close(); // Ferme la connexion
                                      
            }
        }

        private void RemplirComboNationalite()
        {
            Connection.MaConnection.Open();
            maRequete = Connection.MaConnection.CreateCommand();
            maRequete.CommandText = "select nationalite from auteur group by nationalite"; // Requete sql
            maRequete.Prepare(); // Prepare la requete
            monReader = maRequete.ExecuteReader();

            DataTable dt = new DataTable(); // Creation variable datatable
            dt.Load(monReader); // On rempli la variable avec les données du reader

            cb_Nation.DataSource = dt; // Source de la combo = datatable
            cb_Nation.DisplayMember = "nationalite"; // Colonne qui sera affichée dans la combo
            cb_Nation.ValueMember = "nationalite"; // Colonne qui sera memorisée lorsque l'on selectionnera un élément de la liste

        }

        private void btn_Annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Valider_Click(object sender, EventArgs e)
        {
            if(ControleSaisies() == true)
            {
                maRequete = Connection.MaConnection.CreateCommand();
                maRequete.CommandText = "update auteur set " +
                    "nom='"+tb_Nom.Text+"', prenom='"+tb_Prenom.Text+"', nationalite='"+cb_Nation.Text+"' where num='"+numAuteur+"'";
                maRequete.Parameters.Clear();
                maRequete.Parameters.AddWithValue("@paramNom", tb_Nom.Text);
                maRequete.Parameters.AddWithValue("@paramPrenom", tb_Prenom.Text);
                maRequete.Parameters.AddWithValue("@paramNation", cb_Nation.Text);
                maRequete.Parameters.AddWithValue("@paramNumAuteur", numAuteur);

                try
                {
                    Connection.MaConnection.Open();
                    int resultat = maRequete.ExecuteNonQuery();
                    if (resultat > 0)
                    {
                        MessageBox.Show("L'auteur a bien été modifié !");
                    }
                    else
                    {
                        MessageBox.Show("Une erreur s'est produite !");
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    monReader.Close();
                    Connection.MaConnection.Close(); // Ferme la connexion
                }
            }
        }

        private bool ControleSaisies()
        {
            bool controle = true;
            if (tb_Nom.Text=="")
            {
                MessageBox.Show("Vous devez saisir un nom");
                controle = false;
            }
            if (tb_Prenom.Text == "")
            {
                MessageBox.Show("Vous devez saisir un prenom");
                controle = false;
            }

            return controle;
        }
    }
}
