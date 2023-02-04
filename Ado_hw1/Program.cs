using Ado_hw1;
using System.Data.SqlClient;

var connectionString = @"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog = VegetablesAndFruits; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = true";

//ConectToBase.ConnectToBD(connectionString);
//StoreOfSelectCommands.GetAllInfo(connectionString);
//StoreOfSelectCommands.GetAllName(connectionString);
//StoreOfSelectCommands.GetAllColor(connectionString);
//StoreOfSelectCommands.GetMaxCaloric(connectionString);
//StoreOfSelectCommands.GetMinCaloric(connectionString);
//StoreOfSelectCommands.GetAVGCaloric(connectionString);
//StoreOfSelectCommands.GetCountVegetables(connectionString);
//StoreOfSelectCommands.GetCountFruits(connectionString);
//StoreOfSelectCommands.GetCountByEveryColor(connectionString);
StoreOfSelectCommands.GetAllWithCaloricMinX (connectionString);
StoreOfSelectCommands.GetAllWithCaloricMaxX(connectionString);
StoreOfSelectCommands.GetAllWithCaloricBetweenXY(connectionString);

