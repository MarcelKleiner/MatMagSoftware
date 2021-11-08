using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows;
using System.Data;

namespace MatMag.SQL
{
    class SQLConnection
    {

        public enum COMMAND
        {
            ID,
            Grad,
            Name,
            Vorname,
            PicturePath,
            IsChecked,
            CardID,
            CheckInTime,
            CheckOutTime
        }

        private const string sqlDateTimeFormat = "yyyy-MM-dd HH:mm:ss";
        public bool IsSQLConnected = true;


        /// <summary>
        /// 
        /// </summary>
        /// <param name="server"></param>
        /// <param name="port"></param>
        /// <param name="database"></param>
        /// <param name="password"></param>
        /// <returns>@true if connection established @false othervise</returns>
        private MySqlConnection Connect(string server, string user, string port, string database, string password)
        {

            MySqlConnection sql = null;
            try
            {
                //create connection string
                string connectionString = "server=" + server + ";"
                    + "user=" + user + ";"
                    + "database=" + database + ";"
                    + "port=" + port + ";"
                    + "password=" + password;
                //create new instance of MySqlConneciton with the given connectionstring
                sql = new MySqlConnection(connectionString);
                //open sql connection
                sql.Open();
                IsSQLConnected = true;
            }
            catch
            {
                IsSQLConnected = false;
            }

            return sql;

        }

        private MySqlConnection Connect(SQLConnectionSettings sqlComSettings)
        {
            SQLConnectionSettings s = sqlComSettings;
            return Connect(s.Server, s.User, s.Port, s.Database, s.Password);
        }

        public bool TestConnection(SQLConnectionSettings s)
        {

            string QuerySelect = "select * from " + s.Database + "." + s.TableName;
            MySqlConnection con = Connect(s);
            MySqlCommand sqlCommand = new MySqlCommand(QuerySelect, con);
            return IsSQLConnected;

        }

        public void ClearDB(SQLConnectionSettings s)
        {
            try
            {
                string Query = "DELETE FROM " + s.Database + "." + s.TableName;
                MySqlConnection con = Connect(s);
                ExecuteSQLCommand(Query, con);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Write2DB(PersonObject person, SQLConnectionSettings s)
        {
            try
            {
                string Query = "insert into " + s.Database + "." + s.TableName + "(Grad,Name,Vorname,PicturePath,IsChecked,CardID) values('" +
                    person.Grad + "','" +
                    person.Name + "','" +
                    person.Vorname + "','" +
                    person.PhotoPath + "','" +
                    Convert.ToByte(person.IsCheckedIn) + "','" +
                    person.CardID + "');";

                MySqlConnection con = Connect(s);
                ExecuteSQLCommand(Query, con);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void DeleteRow(COMMAND command, object value, SQLConnectionSettings s)
        {
            try
            {
                string Query = "delete * from " + s.Database + "." + s.TableName + " where " + command.ToString() + "=" + value + ";";
                MySqlConnection con = Connect(s);
                ExecuteSQLCommand(Query, con);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Delete(COMMAND command, object value, SQLConnectionSettings s)
        {
            try
            {
                string Query = "delete from " + s.Database + "." + s.TableName + " where " + command.ToString() + "='" + value + "';";
                MySqlConnection con = Connect(s);
                ExecuteSQLCommand(Query, con);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void UpdateDB(PersonObject person, COMMAND command, object value, SQLConnectionSettings s)
        {
            try
            {
                MySqlConnection con = Connect(s);

                string QuerySelect = "select * from " + s.Database + "." + s.TableName + " where " + command.ToString() + "=" + value + ";";
                ExecuteSQLCommand(QuerySelect, con);

                con = Connect(s);
                string QueryUpdate = "update " + s.Database + "." + s.TableName + " SET " +
                    "Grad='" + person.Grad + "'," +
                    "Name='" + person.Name + "'," +
                    "Vorname='" + person.Vorname + "'," +
                    "PicturePath='" + person.PhotoPath + "'," +
                    "IsChecked='" + Convert.ToInt32(person.IsCheckedIn) + "'," +
                    "CardID='" + person.CardID + "'," +
                    "CheckInTime='" + person.CheckInTime.ToString() + "'," +
                    "CheckOutTime='" + person.CheckOutTime.ToString() + "'" +
                    "where " + command.ToString() + " = " + value + ";";
                ExecuteSQLCommand(QueryUpdate, con);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public PersonObject ReadFromDB(COMMAND command, object value, SQLConnectionSettings s)
        {
            PersonObject person = new PersonObject();
            try
            {
                string QuerySelect = "select * from " + s.Database + "." + s.TableName + " where " + command.ToString() + "='" + value + "';";
                MySqlConnection con = Connect(s);
                MySqlCommand sqlCommand = new MySqlCommand(QuerySelect, con);
                //For offline connection we weill use  MySqlDataAdapter class.  
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = sqlCommand;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                DataRow row = dTable.Rows[0];

                person.ID = (int)row[0];
                person.Grad = (string)row[1];
                person.Name = (string)row[2];
                person.Vorname = (string)row[3];
                person.PhotoPath = (string)row[4];
                person.IsCheckedIn = Convert.ToBoolean(row[5]);
                person.CardID = (string)row[6];

                person.CheckInTime = (string)row[7];
                person.CheckOutTime = (string)row[8];


                sqlCommand.Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            return person;
        }

        public List<PersonObject> ReadFromDB(SQLConnectionSettings s)
        {
            List<PersonObject> persons = new List<PersonObject>();
            try
            {
                string Query = "select * from " + s.Database + "." + s.TableName + ";";
                MySqlConnection con = Connect(s);
                MySqlCommand command = new MySqlCommand(Query, con);
                //For offline connection we weill use  MySqlDataAdapter class.  
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = command;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                foreach (DataRow row in dTable.Rows)
                {
                    PersonObject person = new PersonObject();
                    person.ID = (int)row[0];
                    person.Grad = (string)row[1];
                    person.Name = (string)row[2];
                    person.Vorname = (string)row[3];
                    person.PhotoPath = (string)row[4];
                    person.IsCheckedIn = Convert.ToBoolean(row[5]);
                    person.CardID = (string)row[6];
                    person.CheckInTime = (string)row[7];
                    person.CheckOutTime = (string)row[8];
                    persons.Add(person);
                }
                command.Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "DB Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return null;
            }
            return persons;
        }


        private bool ExecuteSQLCommand(string query, MySqlConnection connection)
        {
            try
            {
                if (connection == null)
                {
                    return false;
                }
                MySqlCommand sqlCommand = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read()) { };
                sqlCommand.Connection.Close();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
    }


    public class SQLConnectionSettings
    {
        public string Server { get; set; }
        public string User { get; set; }
        public string Database { get; set; }
        public string Port { get; set; }
        public string Password { get; set; }
        public string TableName { get; set; }
    }
}
