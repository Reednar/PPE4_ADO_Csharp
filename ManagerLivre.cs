using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace PPE4_ADO_Csharp
{
    public class ManagerLivre
    {
        public static Livre DonneLivreDuReader(MySqlDataReader monReader)
        {
            Livre unLivre = new Livre();
            unLivre.Num = Convert.ToInt16(monReader["num"]);
            unLivre.Isbn = monReader["isbn"] == DBNull.Value ? "" : monReader["isbn"] as string; // If ternaire
            unLivre.Titre = monReader["titre"] == DBNull.Value ? "" : monReader["titre"] as string; // If ternaire
            unLivre.Prix = Convert.ToInt16(monReader["prix"]);
            unLivre.Editeur = monReader["editeur"] == DBNull.Value ? "" : monReader["editeur"] as string; // If ternaire
            unLivre.Annee = Convert.ToInt16(monReader["annee"]);
            unLivre.Langue = monReader["langue"] == DBNull.Value ? "" : monReader["langue"] as string; // If ternaire
            unLivre.UnAuteur = ManagerAuteur.DonneAuteurParId(Convert.ToInt16(monReader["numAuteur"]));
            unLivre.UnGenre = ManagerGenre.DonneGenreParId(Convert.ToInt16(monReader["numGenre"]));
            return unLivre;
        }

        public static List<Livre> DonneLivres()
        {
            List<Livre> lesLivres = new List<Livre>();
            MySqlCommand maRequete;
            MySqlDataReader monReader;
            Connection.MaConnection.Open(); // connexion a la bdd
            maRequete = Connection.MaConnection.CreateCommand(); // Pour faire une requete
            maRequete.CommandText = "select * from livre order by titre"; // Requete sql
            monReader = maRequete.ExecuteReader(); // Permet d'executer la requete
            while (monReader.Read()) // Tant qu'il lis quelque chose
            {
                Livre unLivre = ManagerLivre.DonneLivreDuReader(monReader);
                lesLivres.Add(unLivre);
            }
            monReader.Close();
            Connection.MaConnection.Close(); // Ferme la connexion
            return lesLivres;
        }

        public static Livre DonneLivreParId(int id)
        {
            Livre unLivre = new Livre();

            return unLivre;
        }

        public static bool ModifierLivre(Livre l)
        {
            MySqlCommand maRequete;
            bool result = false;
            maRequete = Connection.MaConnection.CreateCommand();
            maRequete.CommandText = "update livre set " +
                "isbn='"+l.Isbn+"', titre='"+l.Titre+"', prix='"+l.Prix+"', editeur='"+l.Editeur+"', annee='"+l.Annee+"', langue='"+l.Langue+"', numAuteur='"+l.UnAuteur.Num +"', numGenre='"+l.UnGenre.Num +"' where num='" + l.Num + "'";
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

        public static bool AjouterLivre(Livre l)
        {
            bool result = false;
            MySqlCommand maRequete;
            maRequete = Connection.MaConnection.CreateCommand();
            maRequete.CommandText = "insert into livre (isbn, titre, prix, editeur, annee, langue, numAuteur, numGenre) values ('" + l.Isbn + "', '" + l.Titre + "', '" + l.Prix + "', '" + l.Editeur + "', '" + l.Annee + "', '" + l.Langue + "', '" + l.UnAuteur.Num + "', '"+l.UnGenre.Num+ "')";
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

        public static bool SupprimerLivre(Livre l)
        {
            bool result = false;
            MySqlCommand maRequete;
            maRequete = Connection.MaConnection.CreateCommand();
            maRequete.CommandText = "delete from livre where num='" + l.Num + "'";
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
