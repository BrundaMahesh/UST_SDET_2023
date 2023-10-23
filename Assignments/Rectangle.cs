using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Rectangle:Shape,IDrawable
    {
        public double Length {  get; set; }
        public double Width {  get; set; }

        public override void CalculateArea()
        {
            throw new NotImplementedException();
        }

        public override void CalculatePerimeter()
        {
            throw new NotImplementedException();
        }

        public void Draw()
        {
            Console.WriteLine("Rectangle");
        }
    }
}
