using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TestHub.Interfaces.Models;

namespace TestHub.Models.DB
{
    public class ProductType : IProductType
    {
        [Key]
        public int ProductTypeID { get; set; }

        public string Description { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}