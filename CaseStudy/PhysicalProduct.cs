using CaseStudy.CustomException;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy
{
    internal class PhysicalProduct:Product,IOrderable
    {
        public double Weight { get; set; }
        public double Dimensions {  get; set; }

        public void DeliveringProduct(Customers customers)
        {
            throw new NotImplementedException();
        }

        public void PlaceOrder(Customers customers, int quantity)
        {
            if(StockQuantity>=quantity)
            {
                StockQuantity-=quantity;
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
    }
}
