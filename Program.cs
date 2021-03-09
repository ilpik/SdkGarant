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
            //var arr = new[] { 1, 5, 2, 1, 4, 0};
            var arr = new[] { 1, 2147483647, 0 };

            Solution(arr);
        }

        public static int Solution(int[] A)
        {
            int answer = 0;

            long[] startPoints = new long[A.Length];
            long[] endPoints = new long[A.Length];

            for (int i = 0; i < A.Length; i++)
            {
                startPoints[i] =(long)i - (long)A[i];
                endPoints[i] = (long)i + (long)A[i];
            }
            long[] start = startPoints.OrderBy(i => i).ToArray();
            long[] end = endPoints.OrderBy(i => i).ToArray();
            int opendisks = 1;
            int j = 1;

            foreach (var endVal in end)
            {
                for (; j < start.Length;)
                {
                    if (endVal >= start[j])
                    {
                        j++;
                        answer += opendisks;
                        opendisks++;
                        if (answer > 10000000)
                        {
                            return -1;
                        }
                    }
                    else
                    {
                        opendisks--;
                        break;
                    }
                }
            }
            return answer;
        }

        //public static int Solution(int[] A)
        //{
        //    int answer = 0;

        //    for (int i = 0; i < A.Length; i++)
        //    {

        //        for (int j = i + 1; j < A.Length; j++)
        //        {

        //            if ((long)(i + A[i]) >= (long)(j - A[j]))
        //            {
        //                if (answer < 10000000)
        //                {
        //                    answer++;
        //                }
        //                else
        //                {
        //                    return -1;
        //                }
        //            }
        //        }
        //    }
        //    return answer;
        //}
    }
}
