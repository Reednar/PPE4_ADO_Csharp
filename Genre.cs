using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE4_ADO_Csharp
{
    public class Genre
    {
        private int num;
        private string libelle;

        public string Libelle { get => libelle; set => libelle = value; }
        public int Num { get => num; set => num = value; }
    }
}
