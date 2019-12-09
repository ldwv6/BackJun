using System;

namespace _8393
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int numA = int.Parse(s);
            int sum = 0;
            for (int i = 1; i <= numA; i++)
            {
                sum += i;
            }

            Console.WriteLine(sum);
        }
    }
}
