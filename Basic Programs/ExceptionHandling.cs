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
            
                int[] num={ 10,20,30};

                //int result = FirstNumber / SecondNumber;
                //Console.WriteLine("Result:"+result);

                //foreach (var item in num)
                //{
                //    int result = item / SecondNumber;
                //    Console.WriteLine(result);
                //}
                for(int i = 0;i<=3;i++)
                {
                    int result = num[i] / SecondNumber;
                    Console.WriteLine(result);
                }
        }
        public void NumberCheck()
        {
            if(FirstNumber>=100)
            {
                Console.WriteLine("Congratzz!!");
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }
}
