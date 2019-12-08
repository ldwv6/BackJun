using System;

namespace _2884
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');

            int h = int.Parse(s[0]);

            int m = int.Parse(s[1]);

            if (h != 0)
            {

                if (m >= 45 && m <= 59)
                {
                    Console.WriteLine("{0} {1}", h, m - 45);
                }

                else if (m >= 0 && m <= 44)
                {
                    Console.WriteLine("{0} {1}", h - 1, 60 - (45 - m));
                }
            }

            else
            {
                if (m >= 45 && m <= 59)
                {
                    Console.WriteLine("{0} {1}",h, m - 45);
                }

                else if (m >= 0 && m <= 44)
                {
                    Console.WriteLine("{0} {1}", 24 - 1, 60 - (45 - m));
                }
            }
   
        }
    }
}
