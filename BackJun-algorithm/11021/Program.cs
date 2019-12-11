using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11021
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int numA = int.Parse(s);
            StringBuilder addNum = new StringBuilder();

            for(int i = 0;i<numA;i++)
            {
                string[] s1 = Console.ReadLine().Split();

                int a = int.Parse(s1[0]); 
                int b = int.Parse(s1[1]);

                int result = a + b ;
                addNum.Append("Case #" + (i+1) + ": " + result + "\n");
            }

            Console.WriteLine(addNum.ToString());
        }
    }
}
