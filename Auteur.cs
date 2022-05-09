using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace PPE4_ADO_Csharp
{
    public class Auteur
    {
        private int num;
        private string nom="";
        private string prenom="";
        private string nationalite="";

        public int Num { get => num; set => num = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Nationalite { get => nationalite; set => nationalite = value; }

        public Auteur(string unNom)
        {
            this.Nom = unNom;
        }

        public Auteur()
        {

        }

        public override string ToString()
        {
            return this.Nom.ToString();
        }

    }
}
