using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace PPE4_ADO_Csharp
{
    public class ManagerAuteur
    {
        public static Auteur DonneAuteurDuReader(MySqlDataReader monReader)
        {
            Auteur unAuteur = new Auteur();
            unAuteur.Num = Convert.ToInt16(monReader["num"]);
            unAuteur.Nom = monReader["nom"] == DBNull.Value ? "" : monReader["nom"] as string; // If ternaire
            unAuteur.Prenom = monReader["prenom"] == DBNull.Value ? "" : monReader["prenom"] as string; // If ternaire
            unAuteur.Nationalite = monReader["nationalite"] == DBNull.Value ? "" : monReader["nationalite"] as string; // If ternaire
            return unAuteur;
        }

        public static List<Auteur> DonneAuteurs()
        {
            List<Auteur> lesAuteurs = new List<Auteur>();
            MySqlCommand maRequete;
            MySqlDataReader monReader;
            maRequete = Connection.MaConnection.CreateCommand(); // Pour faire une requete
            maRequete.CommandText = "select * from auteur order by nom"; // Requete sql
            Connection.MaConnection.Open(); // connexion a la bdd
            monReader = maRequete.ExecuteReader(); // Permet d'executer la requete
            while (monReader.Read()) // Tant qu'il lis quelque chose
            {
                Auteur unAuteur = ManagerAuteur.DonneAuteurDuReader(monReader);
                lesAuteurs.Add(unAuteur);
            }
            monReader.Close();
            Connection.MaConnection.Close(); // Ferme la connexion
            return lesAuteurs;
        }

        public static Auteur DonneAuteurParId(int id)
        {
            Auteur unAuteur = new Auteur();
            MySqlCommand maRequete;
            MySqlDataReader monReader;
            Connection.MaConnection2.Open(); // connexion a la bdd
            maRequete = Connection.MaConnection2.CreateCommand(); // Pour faire une requete
            maRequete.CommandText = "select num, nom from auteur where num='"+id+"'"; // Requete sql
            monReader = maRequete.ExecuteReader(); // Permet d'executer la requete
            while (monReader.Read()) // Tant qu'il lis quelque chose
            {
                unAuteur.Num = Convert.ToInt16(monReader["num"]);
                unAuteur.Nom = monReader["nom"] == DBNull.Value ? "" : monReader["nom"] as string; // If ternaire
            }
            monReader.Close();
            Connection.MaConnection2.Close(); // Ferme la connexion

            return unAuteur;
        }



        public static bool ModifierAuteur(Auteur a)
        {
            MySqlCommand maRequete;
            bool result = false;
            maRequete = Connection.MaConnection.CreateCommand();
            maRequete.CommandText = "update auteur set " +
                "nom='"+a.Nom+"', prenom='"+a.Prenom+"', nationalite='"+a.Nationalite+"' where num='"+a.Num+"'";
            maRequete.Parameters.Clear();
            maRequete.Parameters.AddWithValue("@paramNom", a.Nom);
            maRequete.Parameters.AddWithValue("@paramPrenom", a.Prenom);
            maRequete.Parameters.AddWithValue("@paramNation", a.Nationalite);
            maRequete.Parameters.AddWithValue("@paramNumAuteur", a.Num);

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
            finally
            {

            }
        }

        public static bool AjouterAuteur(Auteur a)
        {
            bool result = false;
            MySqlCommand maRequete;
            maRequete = Connection.MaConnection.CreateCommand();
            maRequete.CommandText = "insert into auteur (nom, prenom, nationalite) values ('"+a.Nom+"', '"+a.Prenom+"', '"+a.Nationalite+"')";
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
            finally
            {

            }
        }

        public static bool SupprimerAuteur(Auteur a)
        {
            bool result = false;
            MySqlCommand maRequete;
            maRequete = Connection.MaConnection.CreateCommand();
            maRequete.CommandText = "delete from auteur where num='"+a.Num+"'";
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
            finally
            {

            }
        }
    }
}
