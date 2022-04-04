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
    public partial class FicheAdherent : Form
    {
        private MySqlCommand maRequete;
        private MySqlDataReader monReader;
        Adherent AdherentCourant = new Adherent();

        public FicheAdherent(int modification, Adherent monAdherent = null)
        {
            InitializeComponent();
            try
            {
                if (monAdherent != null)
                {
                    AdherentCourant = monAdherent;
                }
                bs.DataSource = AdherentCourant;

                if (modification == 0)
                {
                    tb_Nom.Enabled = false;
                    tb_Prenom.Enabled = false;
                    tb_Rue.Enabled = false;
                    tb_CP.Enabled = false;
                    tb_Ville.Enabled = false;
                    tb_Tel.Enabled = false;
                    tb_Mel.Enabled = false;
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
            string retour = "";
            if (tb_Nom.Text == "")
            {
                retour += "Vous devez saisir un nom\n";
                controle = false;
            }
            if (tb_Prenom.Text == "")
            {
                retour +="Vous devez saisir un prenom\n";
                controle = false;
            }

            if (tb_Rue.Text == "")
            {
                retour +="Vous devez saisir une rue\n";
                controle = false;
            }
            if (tb_CP.Text == "")
            {
                retour += "Vous devez saisir un code postal\n";
                controle = false;
            }

            if (tb_Ville.Text == "")
            {
                retour +="Vous devez saisir une ville\n";
                controle = false;
            }
            if (tb_Tel.Text == "")
            {
                retour +="Vous devez saisir un numéro de telephone\n";
                controle = false;
            }
            if (controle == false)
            {
                MessageBox.Show(retour);
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
                    if (AdherentCourant.Num == 0)
                    {
                        AdherentCourant = bs.Current as Adherent;
                        bool reponse = ManagerAdherent.AjouterAdherent(AdherentCourant);
                        MessageBox.Show("L'adherent " + AdherentCourant.Prenom + " a bien été ajouter !");
                    }
                    else
                    {
                        AdherentCourant = bs.Current as Adherent;
                        bool reponse = ManagerAdherent.ModifierAdherent(AdherentCourant);
                        MessageBox.Show("L'adherent " + AdherentCourant.Prenom + " a bien été modifier !");

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
