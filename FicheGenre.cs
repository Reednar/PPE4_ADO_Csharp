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
    public partial class FicheGenre : Form
    {
        private MySqlCommand maRequete;
        private MySqlDataReader monReader;
        Genre GenreCourant = new Genre();

        public FicheGenre(int modification, Genre monGenre = null)
        {
            InitializeComponent();
            try
            {
                if (monGenre != null)
                {
                    GenreCourant = monGenre;
                }
                bs.DataSource = GenreCourant;

                if (modification == 0)
                {
                    tb_Libelle.Enabled = false;

                }
                else if (modification == 3)
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

        private bool ControleSaisies()
        {
            bool controle = true;
            if (tb_Libelle.Text == "")
            {
                MessageBox.Show("Vous devez saisir un prenom");
                controle = false;
            }

            return controle;
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
                    if (GenreCourant.Num == 0)
                    {
                        GenreCourant = bs.Current as Genre;
                        bool reponse = ManagerGenre.AjouterGenre(GenreCourant);
                        MessageBox.Show("Le genre " + GenreCourant.Libelle + " a bien été ajouter !");
                    }
                    else
                    {
                        GenreCourant = bs.Current as Genre;
                        bool reponse = ManagerGenre.ModifierGenre(GenreCourant);
                        MessageBox.Show("Le genre " + GenreCourant.Libelle + " a bien été modifier !");

                    }
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
