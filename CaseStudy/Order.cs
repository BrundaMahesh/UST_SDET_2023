using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy
{
    internal class Order
    {
        public Order(int orderDate, double totalPrice)
        {
            //ListOfBooks = listOfBooks;
            OrderDate = orderDate;
            TotalPrice = totalPrice;
        }

       // public string[] ListOfBooks { get; set; }
        public int OrderDate {  get; set; }
        public double TotalPrice { get; set; }

        public void OrderPlaced()
        {
            Console.WriteLine("Order date:"+OrderDate +"\n" +"Total price:"+TotalPrice);
        }
        
    }
}
