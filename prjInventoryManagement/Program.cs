namespace prjInventoryManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Using the Product class
            Product apple = new Product(1, "Apple", 10, 5);
            Product banana = new Product(2, "Banana", 20, 6);
            Product orange = new Product(3, "Orange", 7, 7);
            Product mango = new Product(4, "Mango", 2, 8);

            // creating a list of products
            List<Product> products = new List<Product> { 
                new Product(1, "Apple", 10, 5),
                new Product(2, "Banana", 20, 6),
                new Product(3, "Orange", 7, 7), 
                new Product(4, "Mango", 2, 8)
            };

            // calculate total value of inventory
            Console.WriteLine($"Total Inventory Value: R{products.CalculateTotalValue()}");
            // Low stock products
            var lowStock = products.GetLowStock(10);
            Console.WriteLine("Low Stock Products:");
            foreach (var product in lowStock)
            {
                Console.WriteLine($"{product.Name} - Quantity: {product.Quantity}");
            }

            // Anonymous type with LINQ
            var namePriceList = products.Select(p => new { p.Name, p.Price });
            Console.WriteLine("\nProduct Name & Price:");
            foreach (var item in namePriceList)
                Console.WriteLine($"{item.Name} - {item.Price:C}");

            // Use anonymous types to display product information
            var summary = new
            {
                products[0].Name,
                products[0].Price,
                stockValue = products[0].Quantity * products[0].Price
            };
            Console.WriteLine($"Summary: {summary.Name} - Price: {summary.Price:C}, Stock Value: {summary.stockValue:C}");

            // pointer type
            unsafe
            {
                int quantity = banana.Quantity;
                int* quantityPtr = &quantity;

                Console.WriteLine($"Original Banana Quantity: {quantity}");
                *quantityPtr = 50; // Unsafe operation to change value of quantity using pointer
                banana.Quantity = *quantityPtr;

                Console.WriteLine($"Updated Banana Quantity: {banana.Quantity}");

            }
            // exit
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();

        }
    }
}
