using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConservatoireChatgpt.Modele;
using MySql.Data.MySqlClient;

namespace ConservatoireChatgpt.Controleur
{
    public class MainPageController
    {
        private Connexion connector;

        public MainPageController()
        {
            connector = Connexion.GetInstance();
        }

        public List<string> GetNomsProfesseurs()
        {
            List<string> nomsProfesseurs = new List<string>();

            try
            {
                string queryString = "SELECT Nom FROM personne WHERE ID < 900";

                MySqlCommand command = connector.CreateCommand(queryString);
                connector.OpenConnection();
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string nom = reader.GetString(0);
                    nomsProfesseurs.Add(nom);
                }

                reader.Close();
                connector.CloseConnection();

                return nomsProfesseurs;
            }
            catch (Exception emp)
            {
                throw (emp);
            }
        }

        public List<string> GetNomsEleves()
        {
            List<string> nomsEleves = new List<string>();

            try
            {
                string queryString = "SELECT Nom FROM personne WHERE ID > 900";

                MySqlCommand command = connector.CreateCommand(queryString);
                connector.OpenConnection();
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string nom = reader.GetString(0);
                    nomsEleves.Add(nom);
                }

                reader.Close();
                connector.CloseConnection();

                return nomsEleves;
            }
            catch (Exception emp)
            {
                throw (emp);
            }
        }

        public int ObtenirProfesseurID(string nomProfesseur)
        {
            try
            {
                string queryString = "SELECT ID FROM personne WHERE ID < 900";

                MySqlCommand command = connector.CreateCommand(queryString);
                command.Parameters.AddWithValue("@Nom", nomProfesseur);

                connector.OpenConnection();
                object result = command.ExecuteScalar();
                connector.CloseConnection();

                if (result != null)
                {
                    return Convert.ToInt32(result);
                }

                return -1; // Si aucun professeur correspondant n'est trouvé
            }
            catch (Exception emp)
            {
                throw (emp);
            }
        }

        public int ObtenirEleveID(string nomEleve)
        {
            try
            {
                string queryString = "SELECT ID FROM personne WHERE ID > 900";

                MySqlCommand command = connector.CreateCommand(queryString);
                command.Parameters.AddWithValue("@Nom", nomEleve);

                connector.OpenConnection();
                object result = command.ExecuteScalar();
                connector.CloseConnection();

                if (result != null)
                {
                    return Convert.ToInt32(result);
                }

                return -1; // Si aucun élève correspondant n'est trouvé
            }
            catch (Exception emp)
            {
                throw (emp);
            }
        }

        public void AjouterTransaction(int professeurID, int eleveID, decimal somme, string libelle)
        {
            try
            {
                string queryString = "INSERT INTO payer (IDPROF, IDELEVE, LIBELLE, PAYE, DATEPAIEMENT) VALUES (@IDPROF, @IDELEVE, @LIBELLE, @PAYE, @DATEPAIEMENT)";

                MySqlCommand command = connector.CreateCommand(queryString);
                command.Parameters.AddWithValue("@IDPROF", professeurID);
                command.Parameters.AddWithValue("@IDELEVE", eleveID);
                command.Parameters.AddWithValue("@LIBELLE", libelle);
                command.Parameters.AddWithValue("@PAYE", somme);
                command.Parameters.AddWithValue("@DATEPAIEMENT", DateTime.Now);

                connector.OpenConnection();
                command.ExecuteNonQuery();
                connector.CloseConnection();
            }
            catch (Exception emp)
            {
                throw (emp);
            }
        }
    }
}
