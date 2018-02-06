using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrepAlgDS.DynamicProgramming
{
    class RepeatingSubSequence
    {
        public static void Run()
        {
            Console.WriteLine(anytwo("abab"));
            Console.WriteLine(anytwo("abba"));
        }

        public static int anytwo(string A)
        {
            int[,] lcs = new int[A.Length + 1, A.Length + 1];

            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < A.Length; j++)
                {
                    if (A[i] == A[j] && i != j)
                    {
                        lcs[i + 1, j + 1] = Math.Max(lcs[i + 1, j], lcs[i, j] + 1);
                    }
                    else
                    {
                        lcs[i + 1, j + 1] = lcs[i + 1, j];
                    }

                    if (lcs[i + 1, j + 1] > 1)
                    {
                        return 1;
                    }
                }
            }

            return 0;
        }
    }
}
