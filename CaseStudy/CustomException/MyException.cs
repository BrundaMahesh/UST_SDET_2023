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
            {"Error1","Insufficient stock" },
            {"Error2","Order failed" },
            
        };
    }
    internal class OrderException : Exception
    {
        public OrderException(string message) : base(message) { }
    }
}

