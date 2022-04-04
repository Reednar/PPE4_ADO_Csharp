using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE4_ADO_Csharp
{
    public class Adherent
    {
        private int num;
        private string prenom;
        private string nom;
        private string adrRue;
        private int adrCP;
        private string adrVille;
        private string tel;
        private string mel;

        public int Num { get => num; set => num = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Nom { get => nom; set => nom = value; }
        public string AdrRue { get => adrRue; set => adrRue = value; }
        public int AdrCP { get => adrCP; set => adrCP = value; }
        public string AdrVille { get => adrVille; set => adrVille = value; }
        public string Tel { get => tel; set => tel = value; }
        public string Mel { get => mel; set => mel = value; }
    }
}
