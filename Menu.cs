using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPE4_ADO_Csharp
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void auteursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_ListeAuteurs frm = new Form_ListeAuteurs();
            frm.Show();
        }

        private void genresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_ListeGenres frm = new Form_ListeGenres();
            frm.Show();
        }

        private void adhérentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_ListeAdherents frm = new Form_ListeAdherents();
            frm.Show();
        }

        private void livresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_ListeLivres frm = new Form_ListeLivres();
            frm.Show();
        }
    }
}
