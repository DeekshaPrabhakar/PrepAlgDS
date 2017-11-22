using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrepAlgDS.Checkpoints
{
    class PrettyPrint
    {
        public static void Run()
        {
            Console.WriteLine("Checkpoint 2: Print concentric rectangular pattern in a 2d matrix: Enter A");
            int n = Convert.ToInt32(Console.ReadLine());
            Util.Display(prettyPrint(n));
        }

        private static List<List<int>> prettyPrint(int A)
        {
            int arrDimension = 2 * A - 1;//5
            List<List<int>> outputArray = new List<List<int>>(arrDimension);

            //fill matrix with initial value A
            for (int i = 0; i < arrDimension; i++)
            {
                List<int> sublist = new List<int>(arrDimension);
                //List<string> sublist = new List<string>(arrDimension);
                for (int j = 0; j < arrDimension; j++)
                {
                    sublist.Add(0);
                    //sublist.Add("(" + i.ToString() + ", " + j.ToString() + ")");
                }

                outputArray.Add(sublist);
            }

            int count = 0;
            int x, y;

            int lowerBound = 0;
            int upperBound = arrDimension - 1;//4
            int fill = A;


            while (count < A)
            {
                x = lowerBound;
                for (y = lowerBound; y <= upperBound; y++)
                {//fill top
                    if (outputArray[x][y] == 0)
                    {
                        outputArray[x][y] = fill;
                    }
                }

                y = upperBound;
                for (x = lowerBound; x <= upperBound; x++)
                {//fill right
                    //Console.WriteLine("outputArray[x][y]: " + outputArray[x][y]);
                    if (outputArray[x][y] == 0)
                    {
                        outputArray[x][y] = fill;
                    }
                }

                x = upperBound;
                for (y = lowerBound; y <= upperBound; y++)
                {//fill bottom
                    if (outputArray[x][y] == 0)
                    {
                        outputArray[x][y] = fill;
                    }
                }

                y = lowerBound;
                for (x = lowerBound; x <= upperBound; x++)
                {//fill left
                    if (outputArray[x][y] == 0)
                    {
                        outputArray[x][y] = fill;
                    }
                }

                count++;
                lowerBound++;
                upperBound--;
                fill--;

            }

            return outputArray;
        }
    }
}
