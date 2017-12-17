using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrepAlgDS.BinarySearch
{
    class SortedInsetPosition
    {
        public static void Run()
        {
            List<int> A = new List<int>(new int[] { 1, 3, 5, 6 });
            int target = 0;
            Console.WriteLine(findPosition(A, target));
        }

        public static int findPosition(List<int> A, int target)
        {
            int index = -1;
            int left = 0, right = A.Count -1; //0 right 3

            while (left <= right)
            {
                int mid = left + ((right - left) / 2); // 0 + 3/2 = 1
                if (A[mid] == target)//3 == 5
                {
                    index = mid;
                    return index;
                }

                if(A[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return left;
        }
    }
}
