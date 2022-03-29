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
