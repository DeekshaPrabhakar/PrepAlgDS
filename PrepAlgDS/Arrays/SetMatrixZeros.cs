using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrepAlgDS.Arrays
{
    class SetMatrixZeros
    {
        public static void Run()
        {
            List<List<int>> inputArray = new List<List<int>>();
            List<int> subArray = new List<int>(new int[] {1, 0, 1});
            inputArray.Add(subArray);
            subArray = new List<int>(new int[] { 1, 1, 1 });
            inputArray.Add(subArray);
            subArray = new List<int>(new int[] { 1, 1, 1 });
            inputArray.Add(subArray);
            Util.Display(SetAllRowsColumnsZero(ref inputArray, 3, 3));
        }

        private static List<List<int>> SetAllRowsColumnsZero(ref List<List<int>> inptArray, int m, int n)
        {
            int x = -1;
            int y = -1;

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (inptArray[i][j] == 0)
                    {
                        x = i;
                        y = j;
                        break;
                    }
                }
                if(x != -1 && y != -1)
                {
                    break;
                }
            }

            int k = 0;
            while (k < m)
            {
                inptArray[x][k] = 0;
                k = k + 1;
            }
            k = 0;
            while (k < n)
            {
                inptArray[k][y] = 0;
                k = k + 1;
            }

            return inptArray;
        }
    }
}
