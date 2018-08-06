using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learningArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            int sum;
            numbers = Init_Array(numbers);
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            sum = GetSum(numbers);
            Console.WriteLine(sum);
            Console.ReadLine();
        }

        public static int GetSum(int[] numbers)
        {
            int sum = numbers.Sum();
            return sum;
        }

        public static int[] Init_Array(int[] numbers)
        {
            numbers[0] = 2;
            int sum = 2;
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = sum;
                sum *= 2;
               
            }
            return numbers;
        }

    };
}
