using System;
using System.Collections.Generic;
using System.Text;

namespace TestHub.Interfaces.Models
{
    public interface IProduct
    {
        int ProductID { get; set; }

        string ProductName { get; set; }

        string UPC { get; set; }

        string Description { get; set; }

        decimal Price { get; set; }

        int? ProductTypeID { get; set; }
    }
}
