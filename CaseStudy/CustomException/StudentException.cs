using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy.CustomException
{
    internal class StudentException
    {
        public static Dictionary<string, string> ErrorMessages { get; set; } = new Dictionary<string, string>()
        {

            {"1","Product Id should be greater than zero"},
            {"2","Product name cannot be null or empty"}

        };
    }
}
    internal class EnrollmentException : Exception
    {
        public EnrollmentException(string message) : base(message) { }
    }
