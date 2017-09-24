using System;
using System.Collections.Generic;
using System.Text;
using TestHub.Models.DB;

namespace TestHub.Models.SeedData
{
    public static class ProductTypeSeedHelper
    {
        public static IList<ProductType> GetProductTypeSeedData()
        {
            var data = new List<ProductType>();

            data.Add(new ProductType()
            {
                Description = "Electronics"
            });

            data.Add(new ProductType()
            {
                Description = "Books"
            });

            data.Add(new ProductType()
            {
                Description = "Tools"
            });

            data.Add(new ProductType()
            {
                Description = "Toys"
            });

            return data;
        }
    }
}
