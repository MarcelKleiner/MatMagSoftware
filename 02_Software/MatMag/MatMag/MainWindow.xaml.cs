using MatMag.Klassen;
using System.Windows;
using System.Data;

using MySql.Data;
using MySql.Data.MySqlClient;
using System;
using MatMag.SQL;

namespace MatMag
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        const string connectionString = "server=localhost;user=root;database=matmagdb;port=3306;password=Marce_l-1991";
        MySqlConnection conn;

        public MainWindow()
        {
            InitializeComponent();
            new MainFrameControl(this);
            new CardControl(this);
            DBConnect(connectionString);
            Closing += MainWindow_Closing;
        }

        private void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
 
        }

        /// <summary>
        /// Try to connect to database
        /// </summary>
        /// <returns></returns>
        private bool DBConnect(string connStr)
        {

            try
            {
                MessageBox.Show( "Connecting to MySQL...");
                using(SQLConnection sql = SQLConnection.Connect())
                {







                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }



    }
}
