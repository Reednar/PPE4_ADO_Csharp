using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace PPE4_ADO_Csharp
{
    public class ManagerGenre
    {
        public static Genre DonneGenreDuReader(MySqlDataReader monReader)
        {
            Genre unGenre = new Genre();
            unGenre.Num = Convert.ToInt16(monReader["num"]);
            unGenre.Libelle = monReader["libelle"] == DBNull.Value ? "" : monReader["libelle"] as string; // If ternaire
            return unGenre;
        }

        public static List<Genre> DonneGenres()
        {
            List<Genre> lesGenres = new List<Genre>();
            MySqlCommand maRequete;
            MySqlDataReader monReader;
            Connection.MaConnection.Open(); // connexion g la bdd
            maRequete = Connection.MaConnection.CreateCommand(); // Pour faire une requete
            maRequete.CommandText = "select * from genre order by libelle"; // Requete sql
            monReader = maRequete.ExecuteReader(); // Permet d'executer la requete
            while (monReader.Read()) // Tant qu'il lis quelque chose
            {
                Genre unGenre = ManagerGenre.DonneGenreDuReader(monReader);
                lesGenres.Add(unGenre);
            }
            monReader.Close();
            Connection.MaConnection.Close(); // Ferme la connexion
            return lesGenres;
        }

        public static Genre DonneGenreParId(int id)
        {
            Genre unGenre = new Genre();
            MySqlCommand maRequete;
            MySqlDataReader monReader;
            Connection.MaConnection2.Open(); // connexion a la bdd
            maRequete = Connection.MaConnection2.CreateCommand(); // Pour faire une requete
            maRequete.CommandText = "select num, libelle from genre where num='" + id + "'"; // Requete sql
            monReader = maRequete.ExecuteReader(); // Permet d'executer la requete
            while (monReader.Read()) // Tant qu'il lis quelque chose
            {
                unGenre.Num = Convert.ToInt16(monReader["num"]);
                unGenre.Libelle = monReader["libelle"] == DBNull.Value ? "" : monReader["libelle"] as string; // If ternaire
            }
            monReader.Close();
            Connection.MaConnection2.Close(); // Ferme la connexion
            return unGenre;
        }

        public static bool ModifierGenre(Genre g)
        {
            MySqlCommand maRequete;
            bool result = false;
            maRequete = Connection.MaConnection.CreateCommand();
            maRequete.CommandText = "update genre set " +
                "libelle='"+g.Libelle+"' where num='" + g.Num + "'";
            maRequete.Parameters.Clear();
            maRequete.Parameters.AddWithValue("@paramNom", g.Libelle);
            maRequete.Parameters.AddWithValue("@paramNumGenre", g.Num);

            try
            {
                Connection.MaConnection.Open();
                int resultat = maRequete.ExecuteNonQuery();
                Connection.MaConnection.Close();
                if (resultat > 0)
                {
                    result = true;
                }
                else
                {
                    throw new Exception("Une erreur s'est produite !");
                }
                return result;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public static bool AjouterGenre(Genre g)
        {
            bool result = false;
            MySqlCommand maRequete;
            maRequete = Connection.MaConnection.CreateCommand();
            maRequete.CommandText = "insert into genre (libelle) values ('" + g.Libelle + "')";
            maRequete.Parameters.Clear();

            try
            {
                Connection.MaConnection.Open();
                int resultat = maRequete.ExecuteNonQuery();
                Connection.MaConnection.Close();
                if (resultat > 0)
                {
                    result = true;
                }
                else
                {
                    throw new Exception("Une erreur s'est produite !");
                }
                return result;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public static bool SupprimerGenre(Genre g)
        {
            bool result = false;
            MySqlCommand maRequete;
            maRequete = Connection.MaConnection.CreateCommand();
            maRequete.CommandText = "delete from genre where num='" + g.Num + "'";
            maRequete.Parameters.Clear();

            try
            {
                Connection.MaConnection.Open();
                int resultat = maRequete.ExecuteNonQuery();
                Connection.MaConnection.Close();
                if (resultat > 0)
                {
                    result = true;
                }
                else
                {
                    throw new Exception("Une erreur s'est produite !");
                }
                return result;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
