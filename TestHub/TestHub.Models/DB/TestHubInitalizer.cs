using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;
using TestHub.Interfaces.Models;
using TestHub.Models.SeedData;

namespace TestHub.Models.DB
{
    public class TestHubInitalizer : DropCreateDatabaseIfModelChanges<TestHubContext>
    {
        public override void InitializeDatabase(TestHubContext context)
        {
            //Need this to kick out all of the other connections so we can actually use it
            context.Database.ExecuteSqlCommand(
                TransactionalBehavior.DoNotEnsureTransaction, string.Format("ALTER DATABASE [{0}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE", context.Database.Connection.Database));

            base.InitializeDatabase(context);
        }

        protected override void Seed(TestHubContext context)
        {
            var productTypes = ProductTypeSeedHelper.GetProductTypeSeedData();

            context.ProductTypes.AddRange(productTypes);

            context.SaveChangesAsync().GetAwaiter().GetResult();
        }
    }
}
