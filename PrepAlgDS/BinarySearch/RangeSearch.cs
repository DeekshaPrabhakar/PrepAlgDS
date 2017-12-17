using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrepAlgDS.BinarySearch
{
    class RangeSearch
    {
        public static void Run()
        {
            Console.WriteLine("Binary Search: Search for a Range");
            List<int> listTwo = new List<int>(new int[] { 5, 7, 7, 8, 8, 10 });
            Util.DisplayList(searchRange(listTwo, 8));
            Console.WriteLine("");
            Console.WriteLine("");
        }
        private static List<int> searchRange(List<int> A, int B)
        {
            int indexStart = BinarySearch(A, A.Count, B, true, 0);
            if (indexStart == -1)
            {
                return new List<int>(new int[] { -1, -1 });
            }
            else
            {
                int indexEnd = BinarySearch(A, A.Count, B, false, indexStart);
                return new List<int>(new int[] { indexStart, indexEnd });
            }
        }
        private static int BinarySearch(List<int> A, int n, int x, bool searchFirst, int startIndex)
        {
            int start = startIndex, end = n - 1, result = -1;
            while (start <= end)
            {
                int mid = start + (end - start) / 2;
                if (A[mid] == x)
                {
                    result = mid;
                    if (searchFirst)
                    {
                        end = mid - 1;
                    }
                    else
                    {
                        start = mid + 1;
                    }
                }
                else if (x < A[mid])
                {
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }
            }

            return result;
        }
    }
}
