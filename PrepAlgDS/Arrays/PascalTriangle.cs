using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrepAlgDS.Arrays
{
    class PascalTriangle
    {
        public static void Run()
        {
            int n = int.Parse(Console.ReadLine());
            Util.Display(generatePascalTriangle(n));
        }

        private static List<List<int>> generatePascalTriangle(int A)
        {
            List<List<int>> outputArray = new List<List<int>>();
            List<int> subArray = new List<int>();
            int i = 1;
            int x = 0;

            while(i <= A)
            {
                subArray = new List<int>();
                for(int j=0; j<i; j++)
                {
                    if (j == 0 || j == i - 1)
                    {
                        subArray.Add(1);
                    }
                    else
                    {
                        x = outputArray[i - 2][j] + outputArray[i - 2][j - 1];
                        subArray.Add(x);
                    }
                }
                outputArray.Add(subArray);
                i = i + 1;
            }
            return outputArray;
        }
    }
}
