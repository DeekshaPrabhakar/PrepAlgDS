using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrepAlgDS.Recursion
{
    class nQueens
    {
        public static void Run()
        {
            int n = 4;
            Util.DisplayListOfListOfStrings(printOutput(solveNQueens(n),n));
        }

        public static List<List<string>> printOutput(List<List<int>> result, int n)
        {
            List<List<string>> output = new List<List<string>>();

            foreach (var sublist in result)
            {
                List<string> list = new List<string>();
                foreach (var a in sublist)
                {
                    list.Add(getNotationForRow(n, a));
                }
                output.Add(list);
            }

            return output;
        }

        private static string getNotationForRow(int n, int queenPlacementIndex)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                if (i == queenPlacementIndex)
                {
                    sb.Append("Q");
                }
                else
                {
                    sb.Append(".");
                }
            }
            return sb.ToString();
        }

        public static List<List<int>> solveNQueens(int a)
        {
            List<List<int>> result = new List<List<int>>();
            solveQueens(a, 0, new List<int>(), result);
            return result;
        }

        private static void solveQueens(int n, int row, List<int> colPlacement, List<List<int>> result)
        {
            if (row == n)
            {
                result.Add(new List<int>(colPlacement));
            }
            else
            {
                for (int col = 0; col < n; col++)
                {
                    colPlacement.Add(col);
                    if (isValid(colPlacement))
                    {
                        solveQueens(n, row + 1, colPlacement, result);
                    }
                    colPlacement.RemoveAt(colPlacement.Count - 1);
                }
            }
        }

        private static bool isValid(List<int> colPlacement)
        {
            int rowID = colPlacement.Count - 1;
            for (int i = 0; i < rowID; i++)
            {
                int diff = Math.Abs(colPlacement[i] - colPlacement[rowID]);
                if (diff == 0 || diff == rowID - i)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
