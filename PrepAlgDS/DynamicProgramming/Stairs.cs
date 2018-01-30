using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrepAlgDS.DynamicProgramming
{
    class Stairs
    {
        protected static int[] ar;
        public static void Run()
        {
           Console.WriteLine(climbStairs(3));
        }
        
        public static int climbStairs(int A)
        {
            ar = new int[A];
            return calculateWays(A);
        }
        static int calculateWays(int n)
        {
            if (ar[n - 1] != 0)
            {
                return ar[n - 1];
            }
            if (n == 1)
            {
                ar[n - 1] = 1;
            }
            else if (n == 2)
            {
                ar[n - 1] = 2;
            }
            else
            {
                ar[n - 1] = calculateWays(n - 1) + calculateWays(n - 2);
            }
            return ar[n - 1];
        }
    }
}
