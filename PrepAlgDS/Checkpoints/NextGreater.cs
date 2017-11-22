using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrepAlgDS.Checkpoints
{
    class NextGreater
    {
        public static void Run()
        {
            Console.WriteLine("Checkpoint 4: find the next greater element G[i] for every element A[i] in the array. [4, 5, 2, 10]");
            List<int> input = new List<int>(new int[] { 4, 5, 2, 10 });            
            Util.DisplayList(nextGreater(input));
        }

        public static List<int> nextGreater(List<int> A)
        {
            List<int> outputList = new List<int>(A.Count);

            bool gotGreater = false;
            for (int i = 0; i < A.Count; i++)
            {
                gotGreater = false;
                for (int j = i + 1; j < A.Count; j++)
                {
                    if (A[j] > A[i])
                    {
                        gotGreater = true;
                        outputList.Add(A[j]);
                        break;
                    }
                }

                if (!gotGreater)
                {
                    outputList.Add(-1);
                }
            }
            return outputList;
        }
    }
}
