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
    public partial class FicheLivre : Form
    {
        private MySqlCommand maRequete;
        private MySqlDataReader monReader;
        Livre LivreCourant = new Livre();

        public FicheLivre(int modification, Livre monLivre = null)
        {
            InitializeComponent();
            RemplirComboAuteur();
            RemplirComboGenre();
 
            try
            {
                if (monLivre != null)
                {
                    LivreCourant = monLivre;
                }
                bs.DataSource = LivreCourant;

                if (modification == 0) // Affichage
                {
                    tb_Isbn.Enabled = false;
                    tb_Titre.Enabled = false;
                    tb_Prix.Enabled = false;
                    tb_Editeur.Enabled = false;
                    tb_Annee.Enabled = false;
                    tb_Langue.Enabled = false;
                    cb_Auteur.Enabled = false;
                    cb_Genre.Enabled = false;
                }
                else if (modification == 3) // Ajout
                {
                    tb_Num.Visible = false;
                    label_Num.Visible = false;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erreur : " + ex.Message);
            }

        }

        private void RemplirComboAuteur()
        {
            Connection.MaConnection.Open();
            maRequete = Connection.MaConnection.CreateCommand();
            maRequete.CommandText = "SELECT a.nom, l.numAuteur from auteur a inner join livre l on l.numAuteur = a.num group by l.numAuteur;"; // Requete sql
            maRequete.Prepare(); // Prepare la requete
            monReader = maRequete.ExecuteReader();

            DataTable dt = new DataTable(); // Creation variable datatable
            dt.Load(monReader); // On rempli la variable avec les données du reader
            
            cb_Auteur.DataSource = dt; // Source de la combo = datatable
            cb_Auteur.DisplayMember = "nom"; // Colonne qui sera affichée dans la combo
            cb_Auteur.ValueMember = "nom"; // Colonne qui sera memorisée lorsque l'on selectionnera un élément de la liste
            Connection.MaConnection.Close();

        }

        private void RemplirComboGenre()
        {
            Connection.MaConnection2.Open();
            maRequete = Connection.MaConnection2.CreateCommand();
            maRequete.CommandText = "select g.libelle, g.num from genre g;"; // Requete sql
            maRequete.Prepare(); // Prepare la requete
            monReader = maRequete.ExecuteReader();

            DataTable dt = new DataTable(); // Creation variable datatable
            dt.Load(monReader); // On rempli la variable avec les données du reader

            cb_Genre.DataSource = dt; // Source de la combo = datatable
            cb_Genre.DisplayMember = "libelle"; // Colonne qui sera affichée dans la combo
            cb_Genre.ValueMember = "libelle"; // Colonne qui sera memorisée lorsque l'on selectionnera un élément de la liste
            Connection.MaConnection2.Close();

        }



        private void btn_Annuler_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Valider_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (ControleSaisies() == true)
                {
                    if (LivreCourant.Num == 0)
                    {
                        LivreCourant = bs.Current as Livre;
                        bool reponse = ManagerLivre.AjouterLivre(LivreCourant);
                        MessageBox.Show("Le livre " + LivreCourant.Titre + " a bien été ajouter !");
                    }
                    else
                    {
                        LivreCourant = bs.Current as Livre;
                        bool reponse = ManagerLivre.ModifierLivre(LivreCourant);
                        MessageBox.Show("Le livre " + LivreCourant.Titre + " a bien été modifier !");

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
            if (tb_Isbn.Text == "")
            {
                MessageBox.Show("Vous devez saisir un isbn");
                controle = false;
            }
            if (tb_Titre.Text == "")
            {
                MessageBox.Show("Vous devez saisir un titre");
                controle = false;
            }
            if (tb_Prix.Text == "")
            {
                MessageBox.Show("Vous devez saisir un prix");
                controle = false;
            }
            if (tb_Editeur.Text == "")
            {
                MessageBox.Show("Vous devez saisir un editeur");
                controle = false;
            }
            if (tb_Langue.Text == "")
            {
                MessageBox.Show("Vous devez saisir une langue");
                controle = false;
            }
            if (tb_Annee.Text == "")
            {
                MessageBox.Show("Vous devez saisir une année");
                controle = false;
            }

            return controle;
        }

    }
}
