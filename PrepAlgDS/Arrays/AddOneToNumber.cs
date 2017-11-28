using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrepAlgDS.Arrays
{
    class AddOneToNumber
    {
        public static void Run()
        {
            String elements = Console.ReadLine();
            String[] split_elements = elements.Split(' ');
            List<int> inptArray = new List<int>();
            for (int j = 0; j < split_elements.Length; j++)
            {
                inptArray.Add(Convert.ToInt32(split_elements[j]));
            }
            Util.DisplayList(plusOne(inptArray));
        }

        public static List<int> plusOne(List<int> A) 
        {
            List<int> outputArray = new List<int>();
            int sum = 0, carry = 0;
            int startingIndex = 0;
            int i = A.Count - 1;

            while (A[startingIndex] == 0 && A.Count > 1)
            {
                startingIndex = startingIndex + 1;
            }

            while (i >= startingIndex)
            {
                sum = 0;

                if (i == A.Count - 1)
                {
                    sum = 1;
                }

                sum += A[i] + carry;
                carry = sum / 10;
                sum = sum % 10;
                outputArray.Add(sum);
                i = i - 1;
            }
            if (carry == 1)
            {
                outputArray.Add(carry);
            }
            outputArray.Reverse();
            return outputArray;
        }
    }
}
