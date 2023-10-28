using CaseStudy.CustomException;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy
{
    internal class DigitalProduct:Product,IOrderable
    {
        public string? DownloadLink {  get; set; }
        public string? FileFormat { get; set; }

       

        public void PlaceOrder(Customers customers, int quantity)
        {
            if (StockQuantity >= quantity)
            {
                StockQuantity -= quantity;
            }
            else
            {
                throw new OrderException(MyException.ErrorMessages["Error1"]);
            }
        }

        public void Processing()
        {
            Console.WriteLine("Payment processed for this digital product:"+Name);
        }

        public void DeliveringProduct(Customers customers)
        {
            Console.WriteLine($"Sending download link for {Name} to {customers.Name}");
            Console.WriteLine($"DownloadLink:{DownloadLink}");
        }
    }
}
