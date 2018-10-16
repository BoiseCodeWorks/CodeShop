using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace CodeShop.Data
{
    public static class DbConnectionOptions
    {

        //what types of databases can I work with????
        public static IDbConnection ConnectToMySQL(string connectionstring)
        {
            var connection = new MySqlConnection(connectionstring);
            connection.Open();
            return connection;
        }
    }
}
