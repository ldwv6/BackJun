using System;
using System.Linq;

namespace _3052
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[10];

            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = (int.Parse(Console.ReadLine())) % 42;
            }

            Console.WriteLine(intArray.Distinct().Count());
        }
    }
}
