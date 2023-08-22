using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program7
{
    internal class Program
    {


        static int SearchValue(int[] array,int target)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == target)
                {
                    return i;
                }

                return -1;
            }
        }
        static void Main(string[] args)
        {
            int[] numbers = { 10, 20, 30, 40, 50 };
            int targetValue = 30;
            int index = SearchValue(numbers, targetValue);
            if (index != -1)
            {
                Console.WriteLine($"value{targetValue} found at index{index}");
            }
            else
            {
                Console.WriteLine($"value{targetValue} not found in the array");


            }
            Console.ReadLine();

        }
    }
}
