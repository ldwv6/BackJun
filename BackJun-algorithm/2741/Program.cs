﻿using System;
using System.Text;

namespace _2741
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int numA = int.Parse(s);
            StringBuilder abNumbers = new StringBuilder();

            for (int i = 1; i <= numA; i++)
            {
                abNumbers.Append(i + "\n");
            }

            Console.WriteLine(abNumbers.ToString());

        }
    }
}
