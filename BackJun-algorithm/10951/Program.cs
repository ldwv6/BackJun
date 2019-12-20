using System;
using System.Text;

namespace _10951
{
    class Program
    {
        static void Main(string[] args)
        {

            StringBuilder stringArray = new StringBuilder();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == null)
                {
                    break;
                }


                string[] s = input.Split();
                int firstNum = int.Parse(s[0]);
                int secondNum = int.Parse(s[1]);

                Console.WriteLine(firstNum + secondNum);
                //Console.Write(stringArray.ToString());
                //stringArray.Append(firstNum + secondNum + "\n");
            }
      
        }
    }
}
