﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy
{
    internal class Book
    {
        public string? Title {  get; set; }
        public string? Author { get; set; }
        public double? ISBN { get; set; }
        public double Price { get; set; }
        public string? Availability {  get; set; }

        public void Display()
        {
            Console.WriteLine($"Title:"+Title +"\n" +"Author:"+Author +"\n"+
                "ISBN:"+ISBN +"\n" +"Price:"+Price +"\n" +"Availability:"+Availability);
        }
    }
}
