using System;
using System.Collections.Generic;
using System.Linq;
using AreaLibrary;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new[] { 1, 5, 2, 1, 4, 2147483647 ,1};
            Solution(arr);
        }

        public static int Solution(int[] A)
        {
            int answer = 0;

            for (int i = 0; i < A.Length; i++)
            {

                for (int j = i + 1; j < A.Length; j++)
                {

                    if ((long)(i + A[i]) >= (long)(j - A[j]))
                    {
                        if (answer < 10000000)
                        {
                            answer++;
                        }
                        else
                        {
                            return -1;
                        }
                    }
                }
            }
            return answer;
        }
    }
}
