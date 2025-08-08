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
        // calculate value
        public static double CalculateTotalValue(this List<Product> products)
        {
            return products.Sum(p => p.Quantity * p.Price);
        }

        // filter the low stock products
        public static List<Product> GetLowStock(this List<Product> products, int threshold)
        {
            return products.Where(p => p.Quantity < threshold).ToList();
        }
    }
}
