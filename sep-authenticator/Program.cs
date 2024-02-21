using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;

namespace sep_authenticator
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Create the database if it doesn't exist
            if(!File.Exists("tokens.db"))
            {
                SQLiteConnection.CreateFile("tokens.db");
                string connectionString = "Data Source=tokens.db;Version=3;";
                SQLiteConnection connection = new SQLiteConnection(connectionString);
                connection.Open();

                string sql = @"CREATE TABLE IF NOT EXISTS Tokens (
                    token_id INTEGER PRIMARY KEY,
                    name TEXT,
                    secret TEXT,
                    issuer TEXT,
                    created_on DATETIME,
                    updated_on DATETIME
                    )";

                SQLiteCommand command = new SQLiteCommand(sql, connection);
                command.ExecuteNonQuery();
                connection.Close();

            }
            
            Application.Run(new frmMain());
        }
    }
}
