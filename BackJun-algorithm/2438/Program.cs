using System;

namespace _2438
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int numA = int.Parse(s);

            for (int i = 0; i < numA; i++)
            {
                for(int j=0;j<i+1;j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}
