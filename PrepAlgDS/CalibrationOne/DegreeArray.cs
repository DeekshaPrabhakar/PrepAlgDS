using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrepAlgDS.CalibrationOne
{
    class DegreeArray
    {
        public static void Run()
        {
            int res;
            int arr_size = 0;
            arr_size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[arr_size];
            int arr_item;
            for (int arr_i = 0; arr_i < arr_size; arr_i++)
            {
                arr_item = Convert.ToInt32(Console.ReadLine());
                arr[arr_i] = arr_item;
            }

            res = degreeOfArray(arr);
            Console.WriteLine("Output");
            Console.WriteLine(res);
        }

        static int degreeOfArray(int[] arr)
        {
            Dictionary<int, int> elementOccurences = new Dictionary<int, int>();
            int degree = 0;
            List<int> repeatingElements = new List<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (elementOccurences.ContainsKey(arr[i]))
                {
                    elementOccurences[arr[i]] = elementOccurences[arr[i]] + 1;
                    degree = degree < elementOccurences[arr[i]] ? elementOccurences[arr[i]] : degree;
                    if (!repeatingElements.Contains(arr[i]))
                    {
                        repeatingElements.Add(arr[i]);
                    }
                }
                else
                {
                    elementOccurences.Add(arr[i], 1);
                }
            }

            int sarray = 0;
            int minimumLength = -1;

            foreach(int repeatingElement in repeatingElements)
            {
                if (elementOccurences[repeatingElement] == degree)
                {
                    sarray = subArrayLength(repeatingElement, arr);
                    minimumLength = sarray < minimumLength && minimumLength == -1 ? minimumLength : sarray;
                }
            }

            return minimumLength;
        }

        static int subArrayLength(int repeatingElement, int[] arr)
        {
            int startIndex = Array.IndexOf(arr, repeatingElement);
            int endIndex = Array.LastIndexOf(arr, repeatingElement);
            int len = endIndex-startIndex + 1;
            return len;
        }
    }
}
