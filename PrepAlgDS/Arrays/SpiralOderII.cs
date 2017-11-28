using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrepAlgDS.Arrays
{
    class SpiralOderII
    {
        public static void Run()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Util.Display(SpiralOrder(n));
        }

        private static List<List<int>> SpiralOrder(int n)
        {
            List<List<int>> outputArray = new List<List<int>>(n);

            int fillNumber = 1;
            int nSquare = n * n;

            int top = 0, left = 0;
            int bottom = n - 1, right = n - 1;

            //fill matrix with initial value 0
            for (int i = 0; i < n; i++)
            {
                List<int> sublist = new List<int>(n);
                for (int j = 0; j < n; j++)
                {
                    sublist.Add(0);
                }

                outputArray.Add(sublist);
            }

            //spiral order filling
            while (fillNumber <= nSquare)
            {
                //top: left to right
                for (int j = left; j <= right; j++)
                {
                    outputArray[top][j] = fillNumber;
                    fillNumber = fillNumber + 1;
                }
                top = top + 1;

                //right: top to bottom
                for (int i = top; i <= bottom; i++)
                {
                    outputArray[i][right] = fillNumber;
                    fillNumber = fillNumber + 1;
                }
                right = right - 1;

                //bottom: right to left
                for (int j = right; j >= left; j--)
                {
                    outputArray[bottom][j] = fillNumber;
                    fillNumber = fillNumber + 1;
                }
                bottom = bottom - 1;

                //left: bottom to top
                for (int i = bottom; i >= top; i--)
                {
                    outputArray[i][left] = fillNumber;
                    fillNumber = fillNumber + 1;
                }
                left = left + 1;
            }

            return outputArray;
        }
    }
}
