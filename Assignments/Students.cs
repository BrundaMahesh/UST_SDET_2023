using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Students
    {
        string? name,grade;
        int[] marks;

        public Students(string? name, string? grade, int[] marks)
        {
            Name = name;
            Grade = grade;
            Marks = marks;
        }

        public string? Name { get => name; set => name = value; }
        public string? Grade { get => grade; set => grade = value; }
        public int[] Marks { get => marks; set => marks = value; }

        public double CalculateAverage()
        {
            return Marks.Average();
        }

        //public char CalculateGrade()
        //{
        //    double average = CalculateAverage();
        //    if (average >= 90)
        //        return 'A';
        //    else if (average >= 80)
        //        return 'B';
        //    else if (average >= 70)
        //        return 'C';
        //    else if (average >= 60)
        //        return 'D';
        //    else
        //        return 'F';
        //}

        public string GetMarksSummary()
        {
            int highestMarks = Marks.Max();
            int lowestMarks = Marks.Min();
            return $"Highest mark:{highestMarks} Lowest mark:{lowestMarks}\n";
        }
    }
}
