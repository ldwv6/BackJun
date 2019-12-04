using System;

namespace _10430
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(new char[] { ' ' });

            int A = int.Parse(s[0]);
            int B = int.Parse(s[1]);
            int C = int.Parse(s[2]);

            Console.WriteLine((A + B) % C);
            Console.WriteLine((A % C + B % C) % C);
            Console.WriteLine((A*B) % C);
            Console.WriteLine((A % C * B % C) % C);

        }

    }
}
