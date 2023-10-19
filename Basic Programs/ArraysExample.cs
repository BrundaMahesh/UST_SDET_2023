using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class ArraysExample
    {
        //int[] numbers = {10, 20, 30};
        int[] numbers = new int[5];
        public void OneDimensional()
        {
            numbers[0] = 3;
            numbers[1] = 2;
            numbers[2] = 1;
            Array.Sort(numbers);
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            
            Console.WriteLine("2nd array:");
            numbers = new int[8];
            numbers[4] = 7;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
