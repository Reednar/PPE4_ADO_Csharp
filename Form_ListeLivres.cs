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
    public partial class Form_ListeLivres : Form
    {
        List<Livre> lesLivres = new List<Livre>();

        public Form_ListeLivres()
        {
            InitializeComponent();
            RemplirListe(); // Remplie la liste des livres
        }

        private void RemplirListe() // Permet de remplir la liste des livres
        {
            try
            {
                lesLivres = ManagerLivre.DonneLivres();
                bs.DataSource = lesLivres;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erreur : " + ex.Message);
            }
            finally
            {

            }
        }

        private void btn_Afficher_Click(object sender, EventArgs e)
        {
            Livre LivreSelectionne = new Livre();
            DataGridViewRow ligne = dgv_ListeLivres.SelectedRows[0];
            LivreSelectionne = ligne.DataBoundItem as Livre;
            if (LivreSelectionne != null)
            {
                FicheLivre frm = new FicheLivre(0, LivreSelectionne); // 1 Affichage
                frm.Text = "Fiche livre de " + LivreSelectionne.Titre;
                frm.ShowDialog();
            }
        }

        private void btn_Modifier_Click(object sender, EventArgs e)
        {
            Livre LivreSelectionne = new Livre();
            DataGridViewRow ligne = dgv_ListeLivres.SelectedRows[0];
            LivreSelectionne = ligne.DataBoundItem as Livre;
            if (LivreSelectionne != null)
            {
                FicheLivre frm = new FicheLivre(2, LivreSelectionne); // 2 Modification
                frm.Text = "Modification du livre " + LivreSelectionne.Titre;
                frm.ShowDialog();
            }
        }

        private void btn_Supprimer_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Voulez vous vraiment supprimer ce livre ?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Livre LivreSelectionne = new Livre();
                DataGridViewRow ligne = dgv_ListeLivres.SelectedRows[0];
                LivreSelectionne = ligne.DataBoundItem as Livre;
                if (LivreSelectionne != null)
                {
                    ManagerLivre.SupprimerLivre(LivreSelectionne);
                    MessageBox.Show("Le livre a bien été supprimer !");
                }
            }
        }

        private void btn_Ajouter_Click(object sender, EventArgs e)
        {
            Livre LivreSelectionne = new Livre();
            if (LivreSelectionne != null)
            {
                FicheLivre frm = new FicheLivre(3, LivreSelectionne); // 3 Ajout
                frm.Text = "Ajout d'un livre";
                frm.ShowDialog();
            }
        }
    }
}
