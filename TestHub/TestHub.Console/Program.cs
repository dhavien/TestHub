using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestHub.Models.DB;

namespace TestHub.ConsoleTesting
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Initalizing DBContext...");
            var db = new TestHubContext();

            //Yeah we could just use using(...) 
            //but some how if the operation breaks or the user close the application need a guarantee that it's going to close the connection.
            try
            {
                var types = db.ProductTypes.ToListAsync().GetAwaiter().GetResult();

                foreach (var type in types)
                {
                    Console.WriteLine(type.Description);
                }
            }
            finally
            {
                db.Database.Connection.Close();
                db.Database.Connection.Dispose();
            }

            Console.ReadKey();
        }
    }
}
