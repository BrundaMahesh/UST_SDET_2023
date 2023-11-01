using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class LINQExample
    {
        public void Display() 
        {
            List<string> courses = new List<string>()
            {
                {"C Tutorial"},
                {"C++ Tutorial"},
                {"Java Tutorial"},
                {"DBMS"},
                {"Web Tech"},
            };

            //Query Syntax
            //var result= from item in courses
            //            where item.Equals("DBMS")
            //            select item;

            //Method Syntax
            //var result = courses.Where(c => c.Equals("DBMS"));
            //foreach (var r in result)
            //{
            //    Console.WriteLine(r);
            //}

            var result = courses.Where(c => c.Contains("Tutorial"));
            foreach (var r in result)
            {
                Console.WriteLine(r);
            }
        }

        public void StudentDisplay()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student(1, "Anu", "CS"));
            students.Add(new Student(2, "Sanju", "IT"));
            students.Add(new Student(3, "Lohith", "ISE"));
            students.Add(new Student(4, "Surya", "EC"));

            var student = students.Where(s => s.Id == 2);
            foreach (var item in student)
            {
                Console.WriteLine(item.Id +" " +item.Name +" "+item.Department);

            }

        }
    }
}
