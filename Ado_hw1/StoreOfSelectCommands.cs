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

        public static void GetAVGCaloric(string connectionString)
        {
            using var connection = new SqlConnection();
            connection.ConnectionString = connectionString;
            connection.Open();

            var insertCommandText = @"select avg ([Caloric_Content]) as [Средняя калорийность] from Vegetables_Fruits";

            var selectCommand = new SqlCommand(insertCommandText, connection);
            using var reader = selectCommand.ExecuteReader();
            reader.Read();
            Console.WriteLine($"средняя калорийность  {reader[0]:#.###}");
        }
        public static void GetCountVegetables(string connectionString)
        {
            using var connection = new SqlConnection();
            connection.ConnectionString = connectionString;
            connection.Open();

            var insertCommandText = @"select count(id) as  [количество овощей]
from[dbo].[Vegetables_Fruits]
where [TypeVF]=N'Овощи'";

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
            }
        }

        public static void GetCountFruits(string connectionString)
        {
            using var connection = new SqlConnection();
            connection.ConnectionString = connectionString;
            connection.Open();

            var insertCommandText = @"select count(id) as  [количество фруктов]
from[dbo].[Vegetables_Fruits]
where [TypeVF]=N'Фрукты'";

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
            }
        }

        public static void GetCountByColor(string connectionString)
        {
            using var connection = new SqlConnection();
            connection.ConnectionString = connectionString;
            connection.Open();

            var insertCommandText = @"select count(id) as  [количество]
from [dbo].[Vegetables_Fruits]
where [ClolorVF]=N'Белый'";

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
            }
        }

        public static void GetCountByEveryColor(string connectionString)
        {
            using var connection = new SqlConnection();
            connection.ConnectionString = connectionString;
            connection.Open();

            var insertCommandText = @"select count(id) as  [количество овощей], ClolorVF
from[dbo].[Vegetables_Fruits]
group by [ClolorVF]";

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

                Console.WriteLine(reader[0] + " " + reader[1]);
            }
        }

        public static void GetAllWithCaloricMinX(string connectionString)
        {
            using var connection = new SqlConnection();
            connection.ConnectionString = connectionString;
            connection.Open();

            var insertCommandText = @"select NameVF,Caloric_Content as [калорийность ниже 200]
from Vegetables_Fruits
where Caloric_Content < 200";

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

                Console.WriteLine(reader[0] + " " + reader[1]);
            }
        }

        public static void GetAllWithCaloricMaxX(string connectionString)
        {
            using var connection = new SqlConnection();
            connection.ConnectionString = connectionString;
            connection.Open();

            var insertCommandText = @"select NameVF,Caloric_Content as [калорийность выже 199]
from Vegetables_Fruits
where Caloric_Content > 199";

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

                Console.WriteLine(reader[0] + " " + reader[1]);
            }
        }

        public static void GetAllWithCaloricBetweenXY(string connectionString)
        {
            using var connection = new SqlConnection();
            connection.ConnectionString = connectionString;
            connection.Open();

            var insertCommandText = @"select NameVF,Caloric_Content as [калорийность от 145 до 201]
from Vegetables_Fruits
where Caloric_Content BETWEEN 145 AND 201
order by Caloric_Content";

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

                Console.WriteLine(reader[0] + " " + reader[1]);
            }
        }

        public static void GetAllWithColorRoseAndYelow(string connectionString)
        {
            using var connection = new SqlConnection();
            connection.ConnectionString = connectionString;
            connection.Open();

            var insertCommandText = @"select NameVF, ClolorVF
from Vegetables_Fruits
where ClolorVF=N'Желтые' or [ClolorVF]=N'Розовый'";

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

                Console.WriteLine(reader[0] + " " + reader[1]);
            }
        }
    }
}