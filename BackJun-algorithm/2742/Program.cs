using System;
using System.Text;

namespace _2742
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            int numA = int.Parse(s);
            StringBuilder abNumbers = new StringBuilder();

            for (int i = 0; i < numA; i++)
            {
                abNumbers.Append(numA - i + "\n");
            }

            Console.WriteLine(abNumbers.ToString());
        }
    }
}
