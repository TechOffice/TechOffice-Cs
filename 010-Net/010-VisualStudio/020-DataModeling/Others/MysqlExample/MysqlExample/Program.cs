using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MysqlExample
{
    /// <summary>
    /// This Program is an example to use Mysql Connector to retrieve data directly
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Testing");
            MySql.Data.MySqlClient.MySqlConnection conn;
            string connectionStr;
            connectionStr = "server=localhost;uid=root;" +
                "pwd=password;database=world;";
            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection();
                conn.ConnectionString = connectionStr;
                conn.Open();
                string Query = "select * from city;";

                MySqlCommand command = new MySqlCommand(Query, conn);

                MySqlDataReader mysqlReader = command.ExecuteReader();
                while (mysqlReader.Read())
                {
                    Console.WriteLine(mysqlReader.GetString(1));
                }

                conn.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Testing");
                Console.WriteLine(ex.Message);
            }

        }
    }
}
