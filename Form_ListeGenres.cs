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
    public partial class Form_ListeGenres : Form
    {
        List<Genre> lesGenres = new List<Genre>();

        public Form_ListeGenres()
        {
            InitializeComponent();
            RemplirListe(); // Remplie la liste des genres
        }

        private void RemplirListe() // Permet de remplir la liste des genres
        {
            try
            {
                lesGenres = ManagerGenre.DonneGenres();
                bs.DataSource = lesGenres;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erreur : " + ex.Message);
            }
            finally
            {

            }
        }

        private void btn_AfficherGenre_Click_1(object sender, EventArgs e)
        {
            Genre GenreSelectionne = new Genre();
            DataGridViewRow ligne = dgv_ListeGenres.SelectedRows[0];
            GenreSelectionne = ligne.DataBoundItem as Genre;
            if (GenreSelectionne != null)
            {
                FicheGenre frm = new FicheGenre(0, GenreSelectionne); // 0 Affichage
                frm.Text = "Fiche genre de " + GenreSelectionne.Libelle;
                frm.ShowDialog();
            }
        }

        private void btn_ModifierGenre_Click_1(object sender, EventArgs e)
        {
            Genre GenreSelectionne = new Genre();
            DataGridViewRow ligne = dgv_ListeGenres.SelectedRows[0];
            GenreSelectionne = ligne.DataBoundItem as Genre;
            if (GenreSelectionne != null)
            {
                FicheGenre frm = new FicheGenre(2, GenreSelectionne); // 2 Modification
                frm.Text = "Modification de l'genre " + GenreSelectionne.Libelle;
                frm.ShowDialog();
            }
        }

        private void btn_SupprimerGenre_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Voulez vous vraiment supprimer ce genre ?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Genre GenreSelectionne = new Genre();
                DataGridViewRow ligne = dgv_ListeGenres.SelectedRows[0];
                GenreSelectionne = ligne.DataBoundItem as Genre;
                if (GenreSelectionne != null)
                {
                    ManagerGenre.SupprimerGenre(GenreSelectionne);
                    MessageBox.Show("Le genre a bien été supprimer !");
                }
            }
        }

        private void btn_AjouterGenre_Click_1(object sender, EventArgs e)
        {
            Genre GenreSelectionne = new Genre();
            if (GenreSelectionne != null)
            {
                FicheGenre frm = new FicheGenre(3, GenreSelectionne); // 3 Ajout
                frm.ShowDialog();
            }
        }
    }
}
