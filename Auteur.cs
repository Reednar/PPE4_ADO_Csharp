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

        public Auteur(int unNum, string unNom, string unPrenom, string uneNationalite)
        {
            this.Num = unNum;
            this.Nom = unNom;
            this.Prenom = unPrenom;
            this.Nationalite = uneNationalite;
        }

        public Auteur()
        {

        }

        public override string ToString()
        {
            return this.Prenom.ToString() + this.Nom.ToString();
        }

    }
}
