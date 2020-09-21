using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Apartament3
{
    static class Connection
    {
        static private MySqlConnection connection;
        static private string server;
        static private string database;
        static private string user;
        static private string password;
        static private string port;
        static private string connectionString;
        static private string sslM;
        static private bool connected = false;
        public static Form1  form;

        public static bool Connect()
        {
            server = "remotemysql.com";
            database = "xKCx80dUpa";
            user = "xKCx80dUpa";
            password = "pUoT5Vw3dE";
            port = "3306";
            sslM = "none";

            connectionString = String.Format("server={0};port={1};user id={2}; password={3}; database={4}; SslMode={5}",
                                                server, port, user, password, database, sslM);

            connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();
                connected = true;
                return true;
            }
            catch(MySqlException ex)
            {
                return false;
            }
        }
        public static void Disconnect()
        {
            connection.Close();
            connected = false;
        }
        public static bool Connected()
        {
            return connected;
        }
        public static List<List<string>> Query(string query)
        {
            if (!Connect())
            {
                form.ErrorMessage("Nie udało się połączyć z serwerem", "Błąd");
                return null;
            }
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader rdr = cmd.ExecuteReader();
            List<List<string>> list = new List<List<string>>();

            int l = 0;
            while (rdr.Read())
            {
                list.Add(new List<string>());
                for (int i = 0; i < rdr.FieldCount; i++)
                {
                    list[l].Add(Convert.ToString(rdr[i]));
                }
                l++;

            }
            rdr.Close();
            Disconnect();

            return list;
        }
        public static string SQLDate(DateTime date)
        {
            string s = date.ToShortDateString();
            string dates = s.Substring(6, 4) + "-" + s.Substring(3, 2) + "-" + s.Substring(0, 2);
            return dates;
        }
    }
}
