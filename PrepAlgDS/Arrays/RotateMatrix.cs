using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrepAlgDS.Arrays
{
    class RotateMatrix
    {
        public static void Run()
        {
            int arrDimension = Convert.ToInt32(Console.ReadLine());
            List<List<int>> inputArray = new List<List<int>>(arrDimension);
            List<int> subarray = new List<int>();

            String elements = Console.ReadLine();
            String[] split_elements = elements.Split(' ');
            for (int i = 0; i < arrDimension; i++)
            {
                elements = Console.ReadLine();
                split_elements = elements.Split(' ');
                subarray = new List<int>();
                for (int j = 0; j < split_elements.Length; j++)
                {
                    subarray.Add(Convert.ToInt32(split_elements[j]));
                }
                inputArray.Add(subarray);
            }
            Util.Display(rotateMatrix(inputArray));
        }

        private static List<List<int>> rotateMatrix(List<List<int>> inputArr)
        {
            List<List<int>> outputArray = new List<List<int>>();
            return outputArray;
        }
    }
}
