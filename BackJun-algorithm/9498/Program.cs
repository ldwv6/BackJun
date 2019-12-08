using System;

namespace _9498
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            int score = int.Parse(s[0]);

            if (score <= 100 && score >= 90)
                Console.WriteLine("A");
            else if (score < 89 && score >= 80)
                Console.WriteLine("B");
            else if (score < 79 && score >= 70)
                Console.WriteLine("C");
            else if (score < 69 && score >= 60)
                Console.WriteLine("D");
            else if (score < 59)
                Console.WriteLine("F");

        }
    }
}
