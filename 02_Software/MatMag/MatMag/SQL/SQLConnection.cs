using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows;

namespace MatMag.SQL
{
    class SQLConnection : IDisposable
    {
        //SQL Connection default settings
        private static readonly string server = "localhost";
        private static readonly string user = "root";
        private static readonly string database = "matmagdb";
        private static readonly string port = "3306";
        private static readonly string password = "Marce_l-1991";  //change to passwordstring

        private MySqlConnection sqlConnection = null;

        public SQLConnection()
        {

        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="server"></param>
        /// <param name="port"></param>
        /// <param name="database"></param>
        /// <param name="password"></param>
        /// <returns>@true if connection established @false othervise</returns>
        public static SQLConnection Connect(string server, string user, string port, string database, string password)
        {
            SQLConnection sql = new SQLConnection();
            try
            {
                //create connection string
                string connectionString = "server=" + server + ";"
                    + "user=" + user + ";"
                    + "database=" + database + ";"
                    + "port=" + port + ";"
                    + "password=" + password;
                //create new instance of MySqlConneciton with the given connectionstring
                sql.sqlConnection = new MySqlConnection(connectionString);
                //open sql connection
                sql.sqlConnection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection failed\n" + ex.Message);
            }
            return sql;
        }


        /// <summary>
        /// Default Connection to MySQL server
        /// </summary>
        /// <returns></returns>
        public static SQLConnection Connect()
        {
            return Connect(server, user, port, database, password);
        }


        /// <summary>
        /// Get server version of the connected sql database
        /// </summary>
        /// <returns></returns>
        public string GetServerVersion()
        {
            return sqlConnection.ServerVersion;
        }


        public void Write2DB(object data)
        {
            try
            {
                if(sqlConnection != null)
                {
                    MySqlCommand command = new MySqlCommand();
                    command.Connection = sqlConnection;
                }
                else
                {
                    MessageBox.Show("No database connected");
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }













        /// <summary>
        /// try to disconnect the existing database
        /// </summary>
        /// <returns></returns>
        public void Dispose()
        {
            try
            {
                sqlConnection.Close();
                MessageBox.Show("DB Disconnected");
            }
            catch (Exception ex)
            {
                MessageBox.Show("disconnection failed\n", ex.Message);
            }
        }






    }
}
