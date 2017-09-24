using System;
using System.Collections.Generic;
using System.Text;

namespace TestHub.Interfaces.Models
{
    public interface IProductType
    {
        int ProductTypeID { get; set; }

        string Description { get; set; }
    }
}
