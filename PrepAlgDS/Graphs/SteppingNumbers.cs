using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrepAlgDS.Graphs
{
    class SteppingNumbers
    {
        public static void Run()
        {
            displaySteppingNumbers(0, 86);
        }

        private static void displaySteppingNumbers(int n, int m)
        {
            List<int> output = new List<int>();
            for (int i = 0; i <= 9; i++)
            {
                output.AddRange(bfs(n, m, i));
            }
            output.Sort();
            Util.DisplayList(output);
        }
        public static List<int> bfs(int n, int m, int num)
        {
            List<int> output = new List<int>();
            Queue<int> q = new Queue<int>();// all stepping numbers

            q.Enqueue(num);

            while (q.Count != 0)
            {
                int stepNum = q.Dequeue();

                if (stepNum <= m && stepNum >= n)
                {
                    output.Add(stepNum);
                    Console.Write(stepNum + " ");
                }

                if (stepNum == 0 || stepNum > m)
                    continue;

                int lastDigit = stepNum % 10;

                int stepNumA = stepNum * 10 + (lastDigit - 1);
                int stepNumB = stepNum * 10 + (lastDigit + 1);

                // If lastDigit is 0 then only possible
                // digit after 0 can be 1 for a Stepping
                // Number
                if (lastDigit == 0)
                    q.Enqueue(stepNumB);

                // If lastDigit is 9 then only possible
                // digit after 9 can be 8 for a Stepping
                // Number
                else if (lastDigit == 9)
                    q.Enqueue(stepNumA);

                else
                {
                    q.Enqueue(stepNumA);
                    q.Enqueue(stepNumB);
                }
            }
            return output;
        }
    }
}
