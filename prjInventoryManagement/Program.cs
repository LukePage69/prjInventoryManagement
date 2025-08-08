namespace prjInventoryManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Using the Product class
            Product apple = new Product("Apple", 10, 5);
            Product banana = new Product("Banana", 20, 6);

            apple.DisplayInfo();
            banana.DisplayInfo();

            // Using the extension method to calculate total value
            Console.WriteLine($"Total value of {apple.Name}: R{apple.TotalValue()}");
            Console.WriteLine($"Total value of {banana.Name}: R{banana.TotalValue()}");

            // Use anonymous types to display product information
            var summary = new
            {
                apple.Name,
                apple.Price,
                stockValue = apple.TotalValue()
            };
            Console.WriteLine($"Summary: {summary.Name} - Price: {summary.Price:C}, Stock Value: R{summary.stockValue}");

            unsafe
            {
                int quantity = banana.Quantity;
                int* quantityPtr = &quantity;

                Console.WriteLine($"Original Banana Quantity: {quantity}");
                *quantityPtr = 50; // Unsafe operation to change value
                banana.Quantity = *quantityPtr;

                Console.WriteLine($"Updated Banana Quantity: {banana.Quantity}");

            }
            // exit
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();

        }
    }
}
