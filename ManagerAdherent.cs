using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace PPE4_ADO_Csharp
{
    public class ManagerAdherent
    {
        public static Adherent DonneAdherentDuReader(MySqlDataReader monReader)
        {
            Adherent unAdherent = new Adherent();
            unAdherent.Num = Convert.ToInt16(monReader["num"]);
            unAdherent.Nom = monReader["nom"] == DBNull.Value ? "" : monReader["nom"] as string; // If ternaire
            unAdherent.Prenom = monReader["prenom"] == DBNull.Value ? "" : monReader["prenom"] as string; // If ternaire
            unAdherent.AdrRue = monReader["adrRue"] == DBNull.Value ? "" : monReader["adrRue"] as string; // If ternaire
            unAdherent.AdrCP = Convert.ToInt32(monReader["num"]); // If ternaire
            unAdherent.AdrVille = monReader["adrVille"] == DBNull.Value ? "" : monReader["adrVille"] as string; // If ternaire
            unAdherent.Tel = monReader["tel"] == DBNull.Value ? "" : monReader["tel"] as string; // If ternaire
            unAdherent.Mel = monReader["mel"] == DBNull.Value ? "" : monReader["mel"] as string; // If ternaire
            return unAdherent;
        }

        public static List<Adherent> DonneAdherents()
        {
            List<Adherent> lesAdherents = new List<Adherent>();
            MySqlCommand maRequete;
            MySqlDataReader monReader;
            Connection.MaConnection.Open(); // connexion a la bdd
            maRequete = Connection.MaConnection.CreateCommand(); // Pour faire une requete
            maRequete.CommandText = "select * from adherent order by nom"; // Requete sql
            monReader = maRequete.ExecuteReader(); // Permet d'executer la requete
            while (monReader.Read()) // Tant qu'il lis quelque chose
            {
                Adherent unAdherent = ManagerAdherent.DonneAdherentDuReader(monReader);
                lesAdherents.Add(unAdherent);
            }
            monReader.Close();
            Connection.MaConnection.Close(); // Ferme la connexion
            return lesAdherents;
        }

        public static Adherent DonneAdherentParId(int id)
        {
            Adherent unAdherent = new Adherent();

            return unAdherent;
        }

        public static bool ModifierAdherent(Adherent a)
        {
            MySqlCommand maRequete;
            bool result = false;
            maRequete = Connection.MaConnection.CreateCommand();
            maRequete.CommandText = "update adherent set " +
                "nom='" + a.Nom + "', prenom='" + a.Prenom + "', adrRue='" + a.AdrRue + "', adrCP='" + a.AdrCP + "', adrVille='" + a.AdrVille + "', tel='" + a.Tel + "', mel='" + a.Mel + "' where num='" + a.Num + "'";
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

        public static bool AjouterAdherent(Adherent a)
        {
            bool result = false;
            MySqlCommand maRequete;
            maRequete = Connection.MaConnection.CreateCommand();
            maRequete.CommandText = "insert into adherent (nom, prenom, adrRue, adrCP, adrVille, tel, mel) values ('" + a.Nom + "', '" + a.Prenom + "', '" + a.AdrRue + "', '" + a.AdrCP + "', '" + a.AdrVille + "', '" + a.Tel + "', '" + a.Mel + "')";
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

        public static bool SupprimerAdherent(Adherent a)
        {
            bool result = false;
            MySqlCommand maRequete;
            maRequete = Connection.MaConnection.CreateCommand();
            maRequete.CommandText = "delete from adherent where num='" + a.Num + "'";
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
