using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrepAlgDS.Recursion
{
    class PermuteString
    {
        public static void Run()
        {
            List<List<int>> result = new List<List<int>>();
            permutations(new List<int>(new int[] { 1, 2, 3 }), new List<int>(), result);
            Util.Display(result);
        }

        private static void permutations(List<int> A, List<int> chosen, List<List<int>> resultList)
        {
            if (A.Count == 0)
            {
                resultList.Add(new List<int>(chosen));
                return;
            }
            else
            {
                for(int i=0; i<  A.Count ; i++)
                {//choose - explore - unchoose
                    //choose
                    int c = A[i];
                    A.RemoveAt(i);
                    chosen.Add(c);
                    permutations(A, chosen, resultList);
                    //unchoose
                    A.Insert(i, c);
                    chosen.RemoveAt(chosen.Count-1);
                    ////choose
                    //int c = s[i];
                    //chosen += c;
                    //s = s.Remove(i, 1);
                    //permuteHelper(s, chosen);
                    ////unchoose
                    //s = s.Insert(i, c.ToString());
                    //chosen = chosen.Remove(chosen.Length - 1, 1);
                }
            }
        }
    }
}
