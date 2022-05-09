using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace PPE4_ADO_Csharp
{
    class Connection
    {
        private static string connectionString = "server=serverbtssiojv.ddns.net;port=3306;Database=lepie_ado;Uid=lepie;password=lepie"; // Pour la bdd
        private static MySqlConnection maConnection = new MySqlConnection(connectionString);
        private static MySqlConnection maConnection2 = new MySqlConnection(connectionString);

        public static MySqlConnection MaConnection { get => maConnection; }
        public static MySqlConnection MaConnection2 { get => maConnection2; set => maConnection2 = value; }
    }
}
