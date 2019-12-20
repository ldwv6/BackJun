using System;

namespace _1110
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int i = 1;

            int originNum = int.Parse(s);

            while (true)
            {
                if (int.Parse(s) < 10)
                {
                    s = s + 0;
                }

                char[] s1 = s.ToCharArray();

                int firstNum = int.Parse(s1[0].ToString());
                int secondNum = int.Parse(s1[1].ToString());
                int sum = firstNum + secondNum;
                string s3 = secondNum.ToString();

                string sumString = sum.ToString();
             
                string therLastNum = (sumString[sumString.Length - 1]).ToString();

                string result = secondNum + therLastNum;

                int result2 = int.Parse(result);

                if (result2 == originNum)
                {
                    Console.WriteLine(i);
                    break;
                }

                s = result2.ToString();

                i++;
            }

        }
    }
}
