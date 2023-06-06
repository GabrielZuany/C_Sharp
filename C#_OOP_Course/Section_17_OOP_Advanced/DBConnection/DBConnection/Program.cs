using System;
using MySqlConnector;
using Microsoft.Extensions.Configuration;

namespace DBConnection
{
    class Program
    {
        static void Main(string[] args)
        {
            IConfiguration config = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json")
            .AddEnvironmentVariables()
            .Build();
            string connectionString = config["ConnectionStrings:DefaultConnection"];

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            Console.WriteLine("Connection Opened");
            connection.Close();
            Console.WriteLine("Connection Closed");

   
        }
    }
}