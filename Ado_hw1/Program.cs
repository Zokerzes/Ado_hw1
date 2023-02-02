using Ado_hw1;
using System.Data.SqlClient;

var connectionString = @"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog = VegetablesAndFruits; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";

//ConectToBase.ConnectToBD(connectionString);
//StoreOfSelectCommands.GetAllInfo(connectionString);
//StoreOfSelectCommands.GetAllName(connectionString);
//StoreOfSelectCommands.GetAllColor(connectionString);
StoreOfSelectCommands.GetMaxCaloric(connectionString);
StoreOfSelectCommands.GetMinCaloric(connectionString);
