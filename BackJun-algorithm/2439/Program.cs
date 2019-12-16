using System;

namespace _2439
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int numA = int.Parse(s);


            for (int i = 0; i < numA; i++)
            {
                for (int j = numA-1; j > i; j--)
                {
                    Console.Write(" ");
                }

                for (int k = 0; k < i + 1; k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}
