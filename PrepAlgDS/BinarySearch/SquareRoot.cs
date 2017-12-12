using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrepAlgDS.BinarySearch
{
    class SquareRoot
    {
        public static void Run()
        {
            Console.WriteLine("Square Root of Integer");
            Console.WriteLine(IntergerSquareroot(11).ToString());
            Console.WriteLine("");
            Console.WriteLine("");
        }
        private static int IntergerSquareroot(int A)
        {
            long left = 0, right = A;//for 25
            //save interval for 25 in left and right initially 0 - 25; take mid 12 if 12*12 = 144
            while (left <= right)
            {
                long mid = left + ((right - left) / 2);
                long midSquared = mid * mid;
                if (midSquared <= A)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return (int)left - 1;
        }
    }
}
