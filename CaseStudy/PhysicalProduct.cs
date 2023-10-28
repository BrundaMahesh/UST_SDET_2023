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

        public void DeliveringProduct()
        {
            throw new NotImplementedException();
        }

        public void PlaceOrders()
        {
            throw new NotImplementedException();
        }

        public void Processing()
        {
            throw new NotImplementedException();
        }
    }
}
