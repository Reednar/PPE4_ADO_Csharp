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
    public partial class Form_ListeAdherents : Form
    {
        List<Adherent> lesAdherents = new List<Adherent>();

        public Form_ListeAdherents()
        {
            InitializeComponent();
            RemplirListe(); // Remplie la liste des adherents
        }

        private void RemplirListe() // Permet de remplir la liste des adherents
        {
            try
            {
                lesAdherents = ManagerAdherent.DonneAdherents();
                bs.DataSource = lesAdherents;
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
            Adherent AdherentSelectionne = new Adherent();
            DataGridViewRow ligne = dgv_ListeAdherents.SelectedRows[0];
            AdherentSelectionne = ligne.DataBoundItem as Adherent;
            if (AdherentSelectionne != null)
            {
                FicheAdherent frm = new FicheAdherent(0, AdherentSelectionne); // 1 Affichage
                frm.Text = "Fiche adherent de " + AdherentSelectionne.Prenom;
                frm.ShowDialog();
            }
        }

        private void btn_Modifier_Click(object sender, EventArgs e)
        {
            Adherent AdherentSelectionne = new Adherent();
            DataGridViewRow ligne = dgv_ListeAdherents.SelectedRows[0];
            AdherentSelectionne = ligne.DataBoundItem as Adherent;
            if (AdherentSelectionne != null)
            {
                FicheAdherent frm = new FicheAdherent(2, AdherentSelectionne); // 2 Modification
                frm.Text = "Modification de l'adherent " + AdherentSelectionne.Prenom;
                frm.ShowDialog();
            }
        }

        private void btn_Supprimer_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Voulez vous vraiment supprimer cet adherent ?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Adherent AdherentSelectionne = new Adherent();
                DataGridViewRow ligne = dgv_ListeAdherents.SelectedRows[0];
                AdherentSelectionne = ligne.DataBoundItem as Adherent;
                if (AdherentSelectionne != null)
                {
                    ManagerAdherent.SupprimerAdherent(AdherentSelectionne);
                    MessageBox.Show("L'adherent a bien été supprimer !");
                }
            }
        }

        private void btn_Ajouter_Click(object sender, EventArgs e)
        {
            Adherent AdherentSelectionne = new Adherent();
            if (AdherentSelectionne != null)
            {
                FicheAdherent frm = new FicheAdherent(3, AdherentSelectionne); // 3 Ajout
                frm.Text = "Ajout d'un adherent";
                frm.ShowDialog();
            }
        }
    }
}
