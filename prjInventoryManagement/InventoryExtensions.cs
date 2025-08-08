using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjInventoryManagement
{
    // Extention methods for Inventory management
    public static class InventoryExtensions
    {
        public static double TotalValue(this Product product)
        {
            return product.Price * product.Quantity;
        }   
    }
}
