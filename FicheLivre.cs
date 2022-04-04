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
            try
            {
                if (monLivre != null)
                {
                    LivreCourant = monLivre;
                }
                bs.DataSource = LivreCourant;

                if (modification == 0)
                {

                }
                else if (modification == 3)
                {
    
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erreur : " + ex.Message);
            }

        }


        private void btn_Annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Valider_Click(object sender, EventArgs e)
        {

        }

        private bool ControleSaisies()
        {
            bool controle = true;

            return controle;
        }
    }
}
