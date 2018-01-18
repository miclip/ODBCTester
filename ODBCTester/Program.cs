using System;
using System.Configuration;
using System.Data.Odbc;
using System.Threading;
using System.Linq;

namespace ODBCTester
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                try
                {
                    Console.WriteLine("Attemping to connect to data source...");
                    var connectionString = ConfigurationManager.ConnectionStrings["shadowDirect"].ConnectionString;

                    if (!string.IsNullOrEmpty(Environment.GetEnvironmentVariable("SHADOWDIRECT")))
                    {
                        connectionString = Environment.GetEnvironmentVariable("SHADOWDIRECT");
                    }

                    var connection = new OdbcConnection(connectionString);
                    connection.Open();

                }
                catch(Exception ex)
                {
                    Console.Error.WriteLine("Error occured, {0}", ex);
                }
                finally
                {
                    Thread.Sleep(5000);
                }
            }

        }
    }
}
