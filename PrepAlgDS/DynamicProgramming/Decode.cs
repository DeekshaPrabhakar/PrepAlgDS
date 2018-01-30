using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrepAlgDS.DynamicProgramming
{
    class Decode
    {
        public static void Run()
        {
            Console.WriteLine(numDecodings("12"));
        }

        public static int numDecodings(string A)
        {
            int prevPrev = 0;
            int prev = 1;
            for (int i = 0; i < A.Length; ++i)
            {
                int currentCharValue = A[i] - '0';
                int prevCharValue = -1;
                if (i > 0) { prevCharValue = A[i - 1] - '0'; }

                int current;
                if (currentCharValue == 0)
                {
                    current = prevPrev;
                    if ((prevCharValue != 1) && (prevCharValue != 2))
                    {
                        return 0;
                    }
                }
                else
                {
                    current = prev;
                    if ((prevCharValue == 1))
                    {
                        current += prevPrev;
                    }
                    else if ((prevCharValue == 2) && (currentCharValue < 7))
                    {
                        current += prevPrev;
                    }
                }

                prevPrev = prev;
                prev = current;
            }

            return prev;
        }
    }
}
