using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Product
    {
        string productName;
        double price;
        int quantity;

        public string ProductName { get => productName; set => productName = value; }
        public double Price { get => price; set => price = value; }
        public int Quantity { get => quantity; set => quantity = value; }

        public Product(string productName, double price, int quantity)
        {
            this.ProductName = productName;
            this.Price = price;
            this.Quantity = quantity;
        }

        public void SetPrice(double newPrice) 
        { 
            Price=newPrice;
        }
        public double ProductValue()
        {
            return  Price*Quantity;
        }

        public void Display()
        {
            Console.WriteLine($"Product Name:" + ProductName);
            Console.WriteLine($"Price:" + Price);
            Console.WriteLine($"Quantity:" + Quantity);
        }
    }
}
