using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrepAlgDS.BinarySearch
{
    class RotatedArray
    {
        public static void Run()
        {
            Console.WriteLine(minimumElement());
        }

        public static int minimumElement()
        {
            List<int> A = new List<int>(new int[] { 4, 5, 6, 7, 1, 2, 3 });
            int minElement = -1;
            int lowIndex = 0;
            int highIndex = A.Count - 1;

            while (lowIndex <= highIndex)
            {
                if (A[lowIndex] <= A[highIndex])
                    return A[lowIndex];
                int mid = (lowIndex + highIndex) / 2; // 0 + 6/2 = 3
                int next = (mid + 1) % A.Count; //4
                int prev = (mid + A.Count - 1) % A.Count;//2
                if (A[mid] <= A[next] && A[mid] <= A[prev])//7 <= 1 && 7<= 6
                {
                    return A[mid];
                }
                else if (A[mid] <= A[highIndex])//7<=3
                {
                    highIndex = mid - 1;
                }
                else if (A[mid] >= A[lowIndex])// 7>= 4 lowindex = 4 highindex = 6
                {
                    lowIndex = mid + 1;
                }
            }
            return minElement;
        }
    }
}
