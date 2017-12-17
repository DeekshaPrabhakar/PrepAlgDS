using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrepAlgDS.BinarySearch
{
    class RotatedSortedArraySearch
    {
        public static void Run()
        {
            List<int> A = new List<int>(new int[] { 4, 5, 6, 7, 0, 1, 2 });
            int target = 7;
            Console.WriteLine(sortedRotatedArraySearch(A, target));
        }

        public static int sortedRotatedArraySearch(List<int> a, int b)
        {
            int index = -1;
            int left = 0, right = a.Count - 1; //0 right 6

            while (left < right)
            {
                int mid = left + ((right - left) / 2); // 0 + 6/2 = 3; 5; 4 + 5-4/2 = 4
                if (a[mid] > a[right])//7 > 2; 1 > 2; 0 > 1
                {   
                    left = mid + 1; //left = 4
                }
                else
                {
                    right = mid; // 5 ; 4
                }
            }

            int smallestElementIndex = left;
            left = 0;
            right = a.Count - 1;

            if(b == a[smallestElementIndex])
            {
                return smallestElementIndex;
            }

            if(a[smallestElementIndex] < b && a[right] >= b)
            {
                left = smallestElementIndex;
            }
            else
            {
                right = smallestElementIndex;
            }

            while (left <= right)
            {
                int mid = left + ((right - left) / 2); // 0 + 3/2 = 1
                if (a[mid] == b)//3 == 5
                {
                    index = mid;
                    return index;
                }

                if (a[mid] < b)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }


            return index;
        }
    }
}
