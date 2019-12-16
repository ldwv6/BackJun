using System;
using System.Text;

namespace _10952
{
    class Program
    {
        static void Main(string[] args)
        {

            StringBuilder stringArray = new StringBuilder();
 
            while (true)
            {
                string[] s = Console.ReadLine().Split();
                int firstNum = int.Parse(s[0]);
                int secondNum = int.Parse(s[1]);

                if(firstNum == 0 && secondNum == 0)
                {
                    break;
                }

                stringArray.Append(firstNum + secondNum + "\n");
            }
            Console.Write(stringArray.ToString());
        }
    }
}
