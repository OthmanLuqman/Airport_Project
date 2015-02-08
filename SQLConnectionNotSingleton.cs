using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Airline_Semester_Project_attempt4
{
    class SQLConnection
    {

        private const string myConnectionString = "server=192.185.195.166;uid=comic_francisco2;" +
            "pwd=51501fr7;database=comic_kanye2;";

        private MySqlConnection connection;

        // constructor
        public SQLConnection()
        {
            connection = new MySqlConnection();
            connection.ConnectionString = myConnectionString;
        }

        //public MySqlConnection GetConnection()
        //{
        //    connection = new MySqlConnection();
        //    connection.ConnectionString = myConnectionString;
        //    return connection;
        //}
        
        // Open connection
        public void OpenConnection()
        {
            connection.Open();
        }

        // Close connection
        public void CloseConnection()
        {
            connection.Close();
        }
            
        public MySqlConnection Connection { get; set; }

    }
}
