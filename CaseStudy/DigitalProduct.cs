using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy
{
    internal class DigitalProduct:Product,IOrderable
    {
        public string DownloadLink {  get; set; }
        public string FileFormat { get; set; }

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
