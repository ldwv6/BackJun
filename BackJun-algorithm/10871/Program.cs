using System;
using System.Text;

namespace _10871
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split();
            int firstNum = int.Parse(s[0]);
            int secondNum = int.Parse(s[1]);

            StringBuilder NumberInput = new StringBuilder(Console.ReadLine());
            string[] s1 = NumberInput.ToString().Split();

            StringBuilder Output = new StringBuilder();
            int[] intArray = new int[firstNum];

            for (int i = 0; i < firstNum; i++)
            {
                intArray[i] = int.Parse(s1[i]);

                if (intArray[i] < secondNum)
                {
                    Output.Append(intArray[i]).Append(" ");
                }
            }


        }
    }
}
