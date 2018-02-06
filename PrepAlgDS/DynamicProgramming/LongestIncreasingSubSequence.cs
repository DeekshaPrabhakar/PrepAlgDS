using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrepAlgDS.DynamicProgramming
{
    class LongestIncreasingSubSequence
    {
        public static void Run()
        {
            Console.WriteLine(lis(new List<int>(new int[] { 0, 8, 4, 12, 2, 10, 6, 14, 1, 9, 5, 13, 3, 11, 7, 15 })));
        }

        public static int lis(List<int> A)
        {
            if (A.Count == 0)
            {
                return 0;
            }
            int[] input = A.ToArray();
            int[] result = new int[input.Length];
            result[0] = 1;
            int max = 1;
            for (int i = 1; i < input.Length; i++)
            {
                result[i] = 1;
                for (int k = 0; k < i; k++)
                {
                    if (input[k] < input[i] && (result[k] + 1) > result[i])
                    {
                        result[i] = result[k] + 1;
                    }
                }
                max = result[i] > max ? result[i] : max;
            }
            return max;
        }
    }
}
