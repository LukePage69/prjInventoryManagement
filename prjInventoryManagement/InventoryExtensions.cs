using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjInventoryManagement
{
    // Extention methods for Inventory management
    public static class InventoryExtensions //(BillWagner, 2025)
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
/*
 References:
BillWagner (2025). Extension Methods - C# Programming Guide. [online] learn.microsoft.com. Available at: <https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/extension-methods>. Last Accessed 08 August 2025.
*/