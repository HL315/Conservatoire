using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.Cryptography;
using MySql.Data.MySqlClient;

namespace ConservatoireChatgpt.Modele
{
    public class Connexion
    {
        private static Connexion instance = null;
        private MySqlConnection mysqlCn;
        private static readonly object mylock = new object();
        private string connString;

        private Connexion()
        {
            // Construire la chaîne de connexion par défaut ici
            string provider = "localhost";
            string database = "conservatoire";
            string uid = "root";
            string password = "";

            connString = "SERVER=" + provider + ";" + "DATABASE=" +
                database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            mysqlCn = new MySqlConnection(connString);
        }

        private Connexion(string provider, string database, string uid, string password)
        {
            connString = "SERVER=" + provider + ";" + "DATABASE=" +
                database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            mysqlCn = new MySqlConnection(connString);
        }

        public static Connexion GetInstance()
        {
            if (instance == null)
            {
                lock (mylock)
                {
                    if (instance == null)
                    {
                        instance = new Connexion();
                    }
                }
            }

            return instance;
        }

        public static Connexion GetInstance(string provider, string database, string uid, string password)
        {
            if (instance == null)
            {
                lock (mylock)
                {
                    if (instance == null)
                    {
                        instance = new Connexion(provider, database, uid, password);
                    }
                }
            }

            return instance;
        }

        public void OpenConnection()
        {
            try
            {
                mysqlCn.Open();
            }
            catch (Exception emp)
            {
                throw (emp);
            }
        }

        public void CloseConnection()
        {
            if (mysqlCn.State == System.Data.ConnectionState.Open)
                mysqlCn.Close();
        }

        public MySqlCommand CreateCommand(string query)
        {
            return new MySqlCommand(query, mysqlCn);
        }
    }
}


