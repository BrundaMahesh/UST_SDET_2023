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

    }
}
