using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using TestHub.Interfaces.Models;

namespace TestHub.Models.DB
{
    public class Product : IProduct
    {
        [Key]
        public int ProductID { get; set; }

        public string ProductName { get; set; }

        public string UPC { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        [ForeignKey("ProductType")]
        public int? ProductTypeID { get; set; }

        public ProductType ProductType { get; set; }
    }
}
