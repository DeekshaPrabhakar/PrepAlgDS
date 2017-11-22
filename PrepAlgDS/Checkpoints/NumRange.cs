using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrepAlgDS.Checkpoints
{
    class NumRange
    {
        public static void Run()
        {
            Console.WriteLine("Checkpoint 3: number of continuous subsequences in the array [10, 5, 1, 0, 2] which have sum S in the range [6, 8]");
            List<int> input = new List<int>(new int[] { 10, 5, 1, 0, 2 });            
            Console.WriteLine(numRange(input, 6, 8));
        }

        public static int numRange(List<int> A, int B, int C)
        {
            int sum = 0;
            int sequenceCount = 0;
            for (int i = 0; i < A.Count; i++)
            {
                sum = A[i];
                if (sum >= B && sum <= C)
                {
                    sequenceCount++;
                }

                for (int j = i + 1; j < A.Count; j++)
                {
                    sum += A[j];
                    if (sum >= B && sum <= C)
                    {
                        sequenceCount++;
                    }
                    if (sum > C)
                    {
                        break;
                    }
                }
            }
            return sequenceCount;
        }
    }
}
