﻿using System;

namespace _1330
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(new char[] {' '});
            int a = int.Parse(s[0]);
            int b = int.Parse(s[1]);

            if( a < b )
            {
                Console.WriteLine("<");          
            }

            else if(a > b)
            {
                Console.WriteLine(">");
            }

            else if(a == b)
            {
                Console.WriteLine("==");
            }
        }
    }
}
