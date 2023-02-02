using System.Data;
using System.Data.SqlClient;

namespace Ado_hw1
{
    public class StoreOfSelectCommands
    {
        public static void GetAllInfo(string connectionString)
        {
            using var connection = new SqlConnection();
            connection.ConnectionString = connectionString;
            connection.Open();
            
            var insertCommandText = @"select [Id],[NameVF],[TypeVF],[ClolorVF],[Caloric_Content] from Vegetables_Fruits";
               
            var selectCommand = new SqlCommand(insertCommandText, connection);
            using var reader = selectCommand.ExecuteReader();
            var lineCounter = 0;
            while (reader.Read())
            {
                if (lineCounter == 0)
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        Console.Write(reader.GetName(i).ToString() + " ");
                    }
                }
                Console.WriteLine();
                lineCounter++;

                Console.WriteLine(reader[0] + "\t" + reader[1] + "\t" + reader[2] + "\t" + reader[3] + "\t" + reader[4]);
            };
        }

        public static void GetAllName(string connectionString)
        {
            using var connection = new SqlConnection();
            connection.ConnectionString = connectionString;
            connection.Open();

            var insertCommandText = @"select [Id],[NameVF] from Vegetables_Fruits";

            var selectCommand = new SqlCommand(insertCommandText, connection);
            using var reader = selectCommand.ExecuteReader();
            var lineCounter = 0;
            while (reader.Read())
            {
                if (lineCounter == 0)
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        Console.Write(reader.GetName(i).ToString() + " ");
                    }
                }
                Console.WriteLine();
                lineCounter++;

                Console.WriteLine(reader[0] + "\t" + reader[1]);
            };
        }

        public static void GetAllColor(string connectionString)
        {
            using var connection = new SqlConnection();
            connection.ConnectionString = connectionString;
            connection.Open();

            var insertCommandText = @"select DISTINCT [ClolorVF] from Vegetables_Fruits";

            var selectCommand = new SqlCommand(insertCommandText, connection);
            using var reader = selectCommand.ExecuteReader();
            var lineCounter = 0;
            while (reader.Read())
            {
                if (lineCounter == 0)
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        Console.Write(reader.GetName(i).ToString() + " ");
                    }
                }
                Console.WriteLine();
                lineCounter++;

                Console.WriteLine(reader[0]);
            };
        }

        public static void GetMaxCaloric(string connectionString)
        {
            using var connection = new SqlConnection();
            connection.ConnectionString = connectionString;
            connection.Open();

            var insertCommandText = @"select top 1 [id],[Caloric_Content],[NameVF] from Vegetables_Fruits
order by [Caloric_Content] desc";

            var selectCommand = new SqlCommand(insertCommandText, connection);
            using var reader = selectCommand.ExecuteReader();
            var lineCounter = 0;
            while (reader.Read())
            {
                if (lineCounter == 0)
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        Console.Write(reader.GetName(i).ToString() + " ");
                    }
                }
                Console.WriteLine();
                lineCounter++;

                Console.WriteLine(reader[0] + "\t" + reader[1] + "\t" + reader[2] );
            };
        }

        public static void GetMinCaloric(string connectionString)
        {
            using var connection = new SqlConnection();
            connection.ConnectionString = connectionString;
            connection.Open();

            var insertCommandText = @"select top 1 [id],[Caloric_Content],[NameVF] from Vegetables_Fruits
order by [Caloric_Content]";

            var selectCommand = new SqlCommand(insertCommandText, connection);
            using var reader = selectCommand.ExecuteReader();
            var lineCounter = 0;
            while (reader.Read())
            {
                if (lineCounter == 0)
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        Console.Write(reader.GetName(i).ToString() + " ");
                    }
                }
                Console.WriteLine();
                lineCounter++;

                Console.WriteLine(reader[0] + "\t" + reader[1] + "\t" + reader[2]);
            };
        }
    }
}