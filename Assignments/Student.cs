using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Student
    {
        string fullName,grade;
        int mark1, mark2,mark3,total;
        double average;

        public Student(string fullName, int mark1, int mark2, int mark3)
        {
            this.fullName = fullName;
            this.mark1 = mark1;
            this.mark2 = mark2;
            this.mark3 = mark3;
        }

        public double CalculateAverage()
        {
            int total=mark1 + mark2 + mark3;
            double average = total / 3;
            return average;
        }
        public double Total()
        {
            int total = mark1 + mark2 + mark3;
            return total;
        }
    }
}
