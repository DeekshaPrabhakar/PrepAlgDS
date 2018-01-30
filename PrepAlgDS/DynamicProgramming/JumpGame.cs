using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrepAlgDS.DynamicProgramming
{
    class JumpGame
    {
        public static void Run()
        {
            Console.WriteLine(canJump(new List<int>(new int[] { 2, 3, 1, 1, 4 })));
            Console.WriteLine(canJump(new List<int>(new int[] { 3, 2, 1, 0, 4 })));
        }
        public static int canJump(List<int> A)
        {
            if (A == null)
            {
                return 0;
            }

            int n = A.Count;
            if (n == 1)
            {
                return 1;
            }

            int[] res = new int[n];

            res[0] = A[0];
            for (int i = 1; i < n; i++)
            {
                if (res[i - 1] >= i)
                {
                    res[i] = Math.Max(res[i - 1], A[i] + i);
                }
            }

            for (int i = 0; i < n; i++)
            {
                if (res[i] >= n - 1)
                {
                    return 1;
                }
            }

            return 0;
        }
    }
}
