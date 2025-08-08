using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjInventoryManagement
{
    // Custom type for Product
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }

        public Product(int Id, string name, int quantity, double price)
        {
            ID = Id;
            Name = name;
            Quantity = quantity;
            Price = price;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"ID: {ID}, Product: {Name}, Quantity: {Quantity}, Price: {Price:C}");
        }
    }
}
