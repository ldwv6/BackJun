using System;

namespace _1110
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
       

            if (int.Parse(s) < 10)
            {
                s = s + 0;
            }

            int i = 0;

            int originNum = int.Parse(s);

            while (true)
            {
                char[] s1 = s.ToCharArray();

                int firstNum = int.Parse(s1[0].ToString());
                int secondNum = int.Parse(s1[1].ToString());
                int sum = firstNum + secondNum;

                string s3 = secondNum.ToString();

                string sumString = sum.ToString();
                string therLastNum = (sumString[sumString.Length - 1]).ToString();
                s = secondNum + therLastNum;
                int result2 = int.Parse(s);
                i++;

                if (result2 == originNum)
                {
                    Console.WriteLine(i);
                    break;
                }
      
            }

        }
    }
}
