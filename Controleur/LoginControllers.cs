using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections;
using Microsoft.Data.SqlClient;
using System.Security.Cryptography;
using MySql.Data.MySqlClient;
using ConservatoireChatgpt.Modele;

namespace ConservatoireChatgpt.Controleur
{
    public class LoginController
    {
        private Connexion connector;

        public LoginController()
        {
            connector = Connexion.GetInstance();
        }

        public bool VerifyLogin(string login, string mdp)
        {
            bool result = false;

            try
            {
                string queryString = "SELECT COUNT(*) FROM administrateur WHERE Login = @Login AND Mdp = @Mdp";

                MySqlCommand command = connector.CreateCommand(queryString);
                command.Parameters.AddWithValue("@Login", login);
                command.Parameters.AddWithValue("@Mdp", mdp);

                connector.OpenConnection();
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if ((Int64)reader.GetValue(0) == 0)
                    {
                        result = false;
                    }
                    else
                    {
                        result = true;
                    }
                }

                reader.Close();
                connector.CloseConnection();

                return result;
            }
            catch (Exception emp)
            {
                throw (emp);
            }
        }
    }

}
