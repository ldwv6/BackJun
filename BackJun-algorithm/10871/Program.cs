using System;

namespace _10871
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split();
            string[] s1 = Console.ReadLine().Split();
            int[] intArray = new int[10];

            int firstNum = int.Parse(s[0]);
            int secondNum = int.Parse(s[1]);
         
            for (int i = 0;i<firstNum ;i++)
            {
                intArray[i] = int.Parse(s1[i]);

                if(intArray[i] < secondNum)
                {
                    Console.Write(intArray[i] + " ");
                }
            }


        }
    }
}
