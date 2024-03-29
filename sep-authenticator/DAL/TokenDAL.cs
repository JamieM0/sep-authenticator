﻿using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sep_authenticator.Models;

namespace sep_authenticator.DAL
{
    internal static class TokenDAL
    {
        public static void AddToken(Token token)
        {
            // Create a connection string to the database file
            string connectionString = "Data Source=tokens.db;Version=3;";

            // Create a connection object using the connection string
            SQLiteConnection connection = new SQLiteConnection(connectionString);

            // Open the connection to the database
            connection.Open();

            // Create a SQL command to insert a token into the table
            string sql = @"INSERT INTO Tokens (name, secret, issuer, created_on, updated_on)
               VALUES (@name, @secret, @issuer, @created_on, @updated_on)";

            // Create a command object using the SQL command and the connection
            SQLiteCommand command = new SQLiteCommand(sql, connection);

            // Create parameters for the command object
            command.Parameters.AddWithValue("@name", token.Name); // The name of the token
            command.Parameters.AddWithValue("@secret", token.Secret); // The secret key of the token
            command.Parameters.AddWithValue("@issuer", token.Issuer); // The issuer of the token
            command.Parameters.AddWithValue("@created_on", token.CreatedOn); // The date and time when the token was created
            command.Parameters.AddWithValue("@updated_on", token.UpdatedOn); // The date and time when the token was last updated

            // Execute the command to insert the token into the table
            command.ExecuteNonQuery();

            // Close the connection to the database
            connection.Close();
        }

        public static void DeleteToken(Token token)
        {
            // Create a connection string to the database file
            string connectionString = "Data Source=tokens.db;Version=3;";

            // Create a connection object using the connection string
            SQLiteConnection connection = new SQLiteConnection(connectionString);

            // Open the connection to the database
            connection.Open();

            // Create a SQL command to delete a token from the table
            string sql = @"DELETE FROM Tokens WHERE token_id = @id";

            // Create a command object using the SQL command and the connection
            SQLiteCommand command = new SQLiteCommand(sql, connection);

            // Create a parameter for the command object
            command.Parameters.AddWithValue("@id", token.Id); // The ID of the token to delete

            // Execute the command to delete the token from the table
            command.ExecuteNonQuery();

            // Close the connection to the database
            connection.Close();
        }

        public static void EditToken(Token token)
        {
            // Create a connection string to the database file
            string connectionString = "Data Source=tokens.db;Version=3;";

            // Create a connection object using the connection string
            SQLiteConnection connection = new SQLiteConnection(connectionString);

            // Open the connection to the database
            connection.Open();

            // Create a SQL command to update a token in the table
            string sql = $@"UPDATE Tokens SET name = '{token.Name}', secret = '{token.Secret}', issuer = '{token.Issuer}', created_on = '{token.CreatedOn.ToString("yyyy-MM-dd HH:mm:ss.fff")}', updated_on = '{token.UpdatedOn.ToString("yyyy-MM-dd HH:mm:ss.fff")}' WHERE token_id = '{token.Id}'";

            // Create a command object using the SQL command and the connection
            SQLiteCommand command = new SQLiteCommand(sql, connection);
            
            // Execute the command to update the token in the table
            command.ExecuteNonQuery();

            // Close the connection to the database
            connection.Close();
        }

        public static Token GetTokenFromID(int id)
        {
            // Create a connection string to the database file
            string connectionString = "Data Source=tokens.db;Version=3;";

            // Create a connection object using the connection string
            SQLiteConnection connection = new SQLiteConnection(connectionString);

            // Open the connection to the database
            connection.Open();

            // Create a SQL command to select a token from the table
            string sql = @"SELECT * FROM Tokens WHERE token_id = @id";

            // Create a command object using the SQL command and the connection
            SQLiteCommand command = new SQLiteCommand(sql, connection);

            // Create a parameter for the command object
            command.Parameters.AddWithValue("@id", id); // The ID of the token to select

            // Execute the command to select the token from the table
            SQLiteDataReader reader = command.ExecuteReader();

            // Create a token object to store the selected token
            Token token = new Token();

            // Read the data from the reader and store it in the token object
            while (reader.Read())
            {
                token.Id = reader.GetInt32(0); // The ID of the token
                token.Name = reader.GetString(1); // The name of the token
                token.Secret = reader.GetString(2); // The secret key of the token
                token.Issuer = reader.GetString(3); // The issuer of the token
                token.CreatedOn = reader.GetDateTime(4); // The date and time when the token was created
                token.UpdatedOn = reader.GetDateTime(5); // The date and time when the token was last updated
            }

            // Close the reader
            reader.Close();

            // Close the connection to the database
            connection.Close();

            // Return the selected token
            return token;
        }
        
        public static Token[] GetTokens()
        {
            // Create a connection string to the database file
            string connectionString = "Data Source=tokens.db;Version=3;";

            // Create a connection object using the connection string
            SQLiteConnection connection = new SQLiteConnection(connectionString);

            // Open the connection to the database
            connection.Open();

            // Create a SQL command to select all tokens from the table
            string sql = "SELECT * FROM Tokens";

            // Create a command object using the SQL command and the connection
            SQLiteCommand command = new SQLiteCommand(sql, connection);

            // Execute the command to select all tokens from the table
            SQLiteDataReader reader = command.ExecuteReader();

            // Create a list to store the tokens
            List<Token> tokens = new List<Token>();

            // Read the data from the reader and create token objects
            while (reader.Read())
            {
                Token token = new Token
                {
                    Id = int.Parse(reader["token_id"].ToString()), // The id of the token
                    Name = reader["name"].ToString(), // The name of the token
                    Secret = reader["secret"].ToString(), // The secret key of the token
                    Issuer = reader["issuer"].ToString(), // The issuer of the token
                    CreatedOn = DateTime.Parse(reader["created_on"].ToString()), // The date and time when the token was created
                    UpdatedOn = DateTime.Parse(reader["updated_on"].ToString()) // The date and time when the token was last updated
                };

                // Add the token to the list
                tokens.Add(token);
            }

            // Close the reader
            reader.Close();

            // Close the connection to the database
            connection.Close();

            // Return the list of tokens as an array
            return tokens.ToArray();
        }
    }
}
