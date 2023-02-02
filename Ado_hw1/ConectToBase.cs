using System.Data;
using System.Data.SqlClient;

namespace Ado_hw1
{
    public class ConectToBase
    {
        public static void ConnectToBD(string connectionString)
        {
            using var connection = new SqlConnection();
            connection.ConnectionString = connectionString;
            connection.Open();
            if (connection.State == ConnectionState.Open)
            {
                Console.WriteLine(@"Соединение с базой успешно");
            };


          
        }
    }
}

