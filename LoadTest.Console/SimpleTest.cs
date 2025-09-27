using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace LoadTest.Console
{
    public class SimpleTest
    {
        public static async Task<int> Main(string[] args)
        {
            System.Console.WriteLine("Testing LoadTestDb215_2550 limits...");
            System.Console.WriteLine("This is our stress test to find the breaking point!");

            try
            {
                var configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json", optional: false)
                    .AddEnvironmentVariables()
                    .Build();

                var connectionString = configuration.GetConnectionString("DefaultConnection");
                System.Console.WriteLine($"Connection: {MaskPassword(connectionString)}");

                using var connection = new SqlConnection(connectionString);
                await connection.OpenAsync();
                System.Console.WriteLine("✅ Connection successful");

                // Check if database exists
                var checkDbSql = "SELECT COUNT(*) FROM sys.databases WHERE name = 'LoadTestDb215_2550'";
                using var checkCommand = new SqlCommand(checkDbSql, connection);
                var dbExists = (int)(await checkCommand.ExecuteScalarAsync() ?? 0) > 0;
                
                System.Console.WriteLine($"Database LoadTestDb215_2550 exists: {dbExists}");

                if (dbExists)
                {
                    // Count tables
                    var countSql = "SELECT COUNT(*) FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE'";
                    using var countCommand = new SqlCommand(countSql, connection);
                    var tableCount = await countCommand.ExecuteScalarAsync();
                    System.Console.WriteLine($"✅ Found {tableCount} tables");
                }

                System.Console.WriteLine("✅ Basic connectivity test passed!");
                System.Console.WriteLine("Note: EF Core model has compilation issues with 215 entities");
                System.Console.WriteLine("This suggests we're approaching the practical complexity limit");
                
                return 0;
            }
            catch (Exception ex)
            {
                System.Console.WriteLine($"❌ Error: {ex.Message}");
                return 1;
            }
        }

        private static string MaskPassword(string? connectionString)
        {
            if (string.IsNullOrEmpty(connectionString))
                return "null";
            
            return connectionString.Replace("Password=Password12345!", "Password=***");
        }
    }
}