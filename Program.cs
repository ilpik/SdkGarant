
        public static int Solution(int[] arr)
        {
            int answer = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                int[] rangeI = Enumerable.Range(i - arr[i], arr[i]*2+1).ToArray();
                
                for (int j = i + 1; j < arr.Length; j++)
                {
                    int[] rangeJ = Enumerable.Range(j - arr[j], arr[j]*2+1).ToArray();

                    if (rangeJ.Any(valJ => rangeI.Contains(valJ)))
                    {
                        answer++;
                    }
                }
            }
            Console.WriteLine(answer);

            return answer;
        }
