using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class ExceptionHandling
    {
        public ExceptionHandling(int firstNumber, int secondNumber)
        {
            FirstNumber = firstNumber;
            SecondNumber = secondNumber;
        }

        public int FirstNumber {  get; set; }
        public int SecondNumber { get; set; }

        public void Divide()
        {
            try
            {
                int[] num={ 10,20,30};

                //int result = FirstNumber / SecondNumber;
                //Console.WriteLine("Result:"+result);

                foreach (var item in num)
                {
                    int result = item / SecondNumber;
                    Console.WriteLine(result);
                }
            }
            catch(ArithmeticException ex) 
            {
                //Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                //Console.WriteLine(ex.Source);
                Console.WriteLine("Denominator cannot be zero");
            }
            
        }
    }
}
