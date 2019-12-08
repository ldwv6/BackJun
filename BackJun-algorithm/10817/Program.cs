using System;

namespace _10817
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            int[] intarray = new int[s.Length];

            intarray[0] = int.Parse(s[0]);
            intarray[1] = int.Parse(s[1]);
            intarray[2] = int.Parse(s[2]);

            int temp = 0;

            if(intarray[0] > intarray[1])
            {
                temp = intarray[0];
                intarray[0] = intarray[1];
                intarray[1] = temp;
            }


            if (intarray[1] > intarray[2])
            {
                temp = intarray[1];
                intarray[1] = intarray[2];
                intarray[2] = temp;
            }

            if (intarray[0] > intarray[1])
            {
                temp = intarray[0];
                intarray[0] = intarray[1];
                intarray[1] = temp;
            }


            if (intarray[1] > intarray[2])
            {
                temp = intarray[1];
                intarray[1] = intarray[2];
                intarray[2] = temp;
            }

            Console.WriteLine(intarray[1]);

        }
    }
}
