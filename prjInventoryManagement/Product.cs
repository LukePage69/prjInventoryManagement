﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjInventoryManagement
{
    // Custom type for Product
    public class Product
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }

        public Product(string name, int quantity, double price)
        {
            Name = name;
            Quantity = quantity;
            Price = price;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Product: {Name}, Quantity: {Quantity}, Price: {Price:C}");
        }
    }
}
