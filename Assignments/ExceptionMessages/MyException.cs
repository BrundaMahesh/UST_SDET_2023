using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.ExceptionMessages
{
    internal class MyException
    {
        public static Dictionary<string, string> ErrorMessages { get; set; } = new Dictionary<string, string>()
        {
            {"Error1","Age must be between 0 and 120" },
            {"Error2","Name should not be null or empty" },
            {"Error3","Diagnosis should not be null or empty" }
        };
        internal class CustomException:Exception
        {
            public CustomException(string message):base(message) { }
        }
    }
}
