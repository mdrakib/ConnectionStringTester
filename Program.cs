using ConnectionStringTester;
using Microsoft.EntityFrameworkCore;

try
{
    var connectionString = args[0];
    var context = new AppDbContext(connectionString);
    var serverName = context.Database.SqlQuery<string>($"SELECT @@SERVERNAME ServerName").ToList().Single();
    Console.WriteLine($"Got response from sql server '{serverName}'");
}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}
