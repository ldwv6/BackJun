using System;
using System.Collections.Generic;
using System.Linq;

namespace _1065
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNum = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = 1; i <= inputNum; i++)
            {

                if (IsHanSu(i))
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
        public static bool IsHanSu(int input)
        {
            var temp = input.ToString().ToCharArray();
            List<int> intList = new List<int> { };



            for (int i = 0; (i + 1) < temp.Length; i++)
            {
                int diff = int.Parse(temp[i].ToString()) - int.Parse(temp[i + 1].ToString());
                intList.Add(diff);

            }

            var dis = intList.Distinct();


            if (dis.Count() <= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}



    //    문제
    //어떤 양의 정수 X의 자리수가 등차수열을 이룬다면, 그 수를 한수라고 한다.등차수열은 연속된 두 개의 수의 차이가 일정한 수열을 말한다.
    //N이 주어졌을 때, 1보다 크거나 같고, 
    //N보다 작거나 같은 한수의 개수를 출력하는 프로그램을 작성하시오.
    
    //입력
    //첫째 줄에 1,000보다 작거나 같은 자연수 N이 주어진다.
    
    
    //출력
    //첫째 줄에 1보다 크거나 같고, N보다 작거나 같은 한수의 개수를 출력한다.
}
