using System;

namespace _2739
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            int numfirst = int.Parse(s[0]);

            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine("{0} * {1} = {2}", numfirst, i, numfirst * i);
            }

        }
    }
}
