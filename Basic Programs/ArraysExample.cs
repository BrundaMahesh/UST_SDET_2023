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
        int[] numbers = new int[5]; //1D
        int[,] nums = new int[2,2];
        public void OneDimensional()
        {
            numbers[0] = 3;
            numbers[1] = 2;
            numbers[2] = 1;
            Console.WriteLine("One Dimensional Array:");
            Array.Sort(numbers);
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            
            Console.WriteLine("new array:");
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


        public void TwoDimensional()
        {
            //nums[0, 0] = 100;
            //nums[0, 1] = 200;
            //nums[1, 0] = 300;
            //nums[1, 1] = 400;
            int[,] nums = { { 100, 200 }, { 300, 400 } };
            Console.WriteLine("Two Dimensional Array:");
            foreach (var item in nums)
            {
                Console.WriteLine(item);
            }
        }
    }
}
