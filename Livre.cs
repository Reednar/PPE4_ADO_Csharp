using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE4_ADO_Csharp
{
    public class Livre
    {
        private int num;
        private string isbn;
        private string titre;
        private int prix;
        private string editeur;
        private int annee;
        private string langue;
        private Auteur unAuteur;
        private Genre unGenre;

        public int Num { get => num; set => num = value; }
        public string Isbn { get => isbn; set => isbn = value; }
        public string Titre { get => titre; set => titre = value; }
        public int Prix { get => prix; set => prix = value; }
        public string Editeur { get => editeur; set => editeur = value; }
        public int Annee { get => annee; set => annee = value; }
        public string Langue { get => langue; set => langue = value; }
        public Auteur UnAuteur { get => unAuteur; set => unAuteur = value; }
        public Genre UnGenre { get => unGenre; set => unGenre = value; }
    }
}
