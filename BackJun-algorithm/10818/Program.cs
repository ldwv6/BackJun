using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10818
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[int.Parse(Console.ReadLine())];

            var stringArray = Console.ReadLine().Split();

            for(int i=0;i<array.Length;i++)
            {
                array[i] = int.Parse(stringArray[i]);
            }

            Console.Write(array.Min() + " " + array.Max());
            Console.WriteLine();
    
        }
    }
}
