using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrepAlgDS.Recursion
{
    class RecursiveStaircase
    {
        public static void Run()
        {
            Console.WriteLine(countPathsMemo(3));
        }

        public static int countPathsRecursive(int steps)
        {
            if (steps < 0)
            {
                return 0;
            }
            else if(steps == 0)
            {
                return 1;
            }
            return countPathsRecursive(steps - 1) + countPathsRecursive(steps - 2) + countPathsRecursive(steps - 3);
        }

        public static int countPathsMemo(int n)
        {
            return countPathsMemo(n, new int[n + 1]);
        }

        public static int countPathsMemo(int n, int[] memo)
        {
            if (n < 0)
            {
                return 0;
            }
            else if (n == 0)
            {
                return 1;
            }
            if (memo[n] == 0)
            {
                memo[n] = countPathsMemo(n - 1, memo) + countPathsMemo(n - 2, memo) + countPathsMemo(n - 3, memo);
            }
            return memo[n];
        }
    }
}
