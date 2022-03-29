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
        Auteur AuteurCourant = new Auteur();

        public FicheAuteur(bool modification, Auteur monAuteur=null)
        {
            InitializeComponent();
            RemplirComboNationalite();
            try
            {
                if (monAuteur != null)
                {
                    AuteurCourant = monAuteur;
                }
                bs.DataSource = AuteurCourant;
                
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
            Connection.MaConnection.Close();

        }

        private void btn_Annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Valider_Click(object sender, EventArgs e)
        {
            try
            {
                if (ControleSaisies() == true)
                {
                    if (AuteurCourant.Num == 0)
                    {
                        AuteurCourant = bs.Current as Auteur;
                        bool reponse = ManagerAuteur.AjouterAuteur(AuteurCourant);
                    }
                    else
                    {
                        AuteurCourant = bs.Current as Auteur;
                        bool reponse = ManagerAuteur.ModifierAuteur(AuteurCourant);
                    }
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
