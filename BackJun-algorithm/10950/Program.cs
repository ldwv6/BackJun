using System;

namespace _10950
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split();;   
            int numLine = int.Parse(s[0]);

            string[] s1 = new string[numLine];
            string[] s2 = new string[2];

            for (int i=0;i< numLine ; i++)
            {
                s1[i] = Console.ReadLine();
            }

            for (int j=0;j< numLine; j++)
            {
                s2 = s1[j].Split(' ');

                int a = int.Parse(s2[0]);
                int b = int.Parse(s2[1]);

                Console.WriteLine(a + b);
            }
        }
    }
}
