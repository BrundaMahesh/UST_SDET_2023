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
            throw new NotImplementedException();
        }

        public void DeliveringProduct(Customers customers)
        {
            throw new NotImplementedException();
        }
    }
}
