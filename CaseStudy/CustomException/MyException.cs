using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy.CustomException
{
    internal class MyException
    {
        public static Dictionary<string, string> ErrorMessages { get; set; } = new Dictionary<string, string>()
        {
           
            {"Error1","Product Id should be greater than zero"},
            {"Error4","Product name not Null"}

        };
    }
    internal class OrderException : Exception
    {
        public OrderException(string message) : base(message) { }
    }
}

