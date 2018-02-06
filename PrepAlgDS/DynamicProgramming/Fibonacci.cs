using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrepAlgDS.DynamicProgramming
{
    class Fibonacci
    {
        public static void Run()
        {
            Console.WriteLine(withoutCache(5));
        }

        public static Int64 withoutCache(int n)
        {
            if (n <= 1)
            {
                return n;
            }

            int fMinus2 = 0;
            int fMinus1 = 1;

            for (int i = 2; i <= n; i++)
            {
                int f = fMinus2 + fMinus1;
                fMinus2 = fMinus1;
                fMinus1 = f;
            }
            return fMinus1;
        }


        private static Dictionary<Int64, Int64> map = new Dictionary<long, long>();
        public static Int64 withCache(int n)
        {
            if(n <= 1)
            {
                return n;
            }
            else if (!map.ContainsKey(n))
            {
                map.Add(n, withCache(n - 2) + withCache(n - 1));
            }
            return map[n];
        }
    }
}
