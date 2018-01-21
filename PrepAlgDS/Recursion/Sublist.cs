using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrepAlgDS.Recursion
{
    class Sublist
    {
        public static void Run()
        {
            List<List<int>> result = new List<List<int>>();
            List<int> A = new List<int>(new int[] { 15, 20, 12, 19, 4 });
            
            //subset(A, new List<int>(), result);
             A.Sort();
        var empty = new List<int>();
        result.Add(empty);
        subset1(0, empty, A, result);

        Util.Display(result);
            /*
                  [],
                  [1],
                  [1, 2],
                  [1, 2, 3],
                  [1, 3],
                  [2],
                  [2, 3],
                  [3],
                ]
            */
        }



        public static void subset1(int index, List<int> soFar, List<int> A, List<List<int>> resultList)
        {
            for (int i = index; i < A.Count; i++)
            {
                var sub = new List<int>(soFar);
                sub.Add(A[i]);
                resultList.Add(sub);
                subset1(i + 1, sub, A, resultList);
            }
            return;
        }
        private static void subset(List<int> A, List<int> chosen, List<List<int>> resultList)
        {
            if (A.Count == 0)
            {
                List<int> x = new List<int>(chosen);                
                resultList.Add(x);                
                return;
            }
            else
            {
                //there are 2 choices to explore
                //the subset with first element and one without it
                
                int first = A[0];
                A.RemoveAt(0);

                chosen.Add(first);
                subset(A, chosen, resultList);

                chosen.RemoveAt(chosen.Count - 1);
                subset(A, chosen, resultList);

                A.Insert(0, first);              
            }
        }
    }
}
