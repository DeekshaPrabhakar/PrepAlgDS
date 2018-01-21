                                                                                                                                      using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrepAlgDS.BinarySearch
{
    class MatrixSearch
    {
        public static void Run()
        {
            List<List<int>> inputArray = new List<List<int>>();
            List<int> subArray = new List<int>(new int[] { 1,3,5,7 });
            inputArray.Add(subArray);
            subArray = new List<int>(new int[] { 10, 11, 16, 20 });
            inputArray.Add(subArray);
            subArray = new List<int>(new int[] { 23, 30, 34, 50 });
            inputArray.Add(subArray);
            Console.WriteLine(searchMatrix(inputArray,8));
        }
        public static int searchMatrix(List<List<int>> a, int b)
        {

            int row = 0, col = a[0].Count - 1;

            while (row < a.Count && col >= 0)
            {
                if (a[row][col] == b)
                {
                    return 1;
                }
                else if (a[row][col] < b)
                {
                    ++row;
                }
                else
                {
                    --col;
                }
            }
            return 0;
        }
    }
}
