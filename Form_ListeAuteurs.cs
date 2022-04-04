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
        List<Auteur> lesAuteurs = new List<Auteur>();

        public Form_ListeAuteurs()
        {
            InitializeComponent();
            RemplirListe(); // Remplie la liste des auteurs
        }

        private void RemplirListe() // Permet de remplir la liste des auteurs
        {
            try
            {
                lesAuteurs = ManagerAuteur.DonneAuteurs();
                bs.DataSource = lesAuteurs;
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
            Auteur AuteurSelectionne = new Auteur();
            DataGridViewRow ligne = dgv_ListeAuteurs.SelectedRows[0];
            AuteurSelectionne = ligne.DataBoundItem as Auteur;
            if(AuteurSelectionne != null)
            {
                FicheAuteur frm = new FicheAuteur(0, AuteurSelectionne); // 1 Affichage
                frm.Text = "Fiche auteur de " + AuteurSelectionne.Prenom;
                frm.ShowDialog();
            }
        }

        private void btn_Modifier_Click(object sender, EventArgs e)
        {
            Auteur AuteurSelectionne = new Auteur();
            DataGridViewRow ligne = dgv_ListeAuteurs.SelectedRows[0];
            AuteurSelectionne = ligne.DataBoundItem as Auteur;
            if (AuteurSelectionne != null)
            {
                FicheAuteur frm = new FicheAuteur(2, AuteurSelectionne); // 2 Modification
                frm.Text = "Modification de l'auteur " + AuteurSelectionne.Prenom;
                frm.ShowDialog();
            }
        }

        private void btn_Ajouter_Click(object sender, EventArgs e)
        {
            Auteur AuteurSelectionne = new Auteur();
            if (AuteurSelectionne != null)
            {
                FicheAuteur frm = new FicheAuteur(3, AuteurSelectionne); // 3 Ajout
                frm.ShowDialog();
            }
        }

        private void btn_Supprimer_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Voulez vous vraiment supprimer cet auteur ?", "Confirmation", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                Auteur AuteurSelectionne = new Auteur();
                DataGridViewRow ligne = dgv_ListeAuteurs.SelectedRows[0];
                AuteurSelectionne = ligne.DataBoundItem as Auteur;
                if (AuteurSelectionne != null)
                {
                    ManagerAuteur.SupprimerAuteur(AuteurSelectionne);
                    MessageBox.Show("L'auteur a bien été supprimer !");
                }
            }

        }

    }
}
