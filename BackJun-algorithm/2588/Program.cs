using System;

namespace _2588
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            int result=0;
            int var1 = 1;

            char[] c1 = s2.ToCharArray();
            int[] num1 = new int[c1.Length];
            char[] c2 = new char[c1.Length];
            Array.Reverse(c1);
         
            for(int i=0;i<c1.Length;i++)
            {
                num1[i] = int.Parse(c1[i].ToString());
            }

            for (int i = 0; i < c1.Length; i++)
            {
                int a = int.Parse(s1);

                Console.WriteLine(num1[i] * a);

                result = result + ((num1[i] * var1) * a);

                var1 = var1 * 10;
            }
            Console.WriteLine(result);
        }
    }
}
