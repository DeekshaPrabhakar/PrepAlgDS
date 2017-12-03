using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrepAlgDS.Strings
{
    class AddBinaryStrings
    {
        public static void Run()
        {
            Console.WriteLine("AddBinaryStrings: " + "110, " + "11");
            Console.WriteLine(addBinary("110", "11"));

            Console.WriteLine("AddBinaryStrings: " + "100, " + "11");
            Console.WriteLine(addBinary("100", "11"));

            Console.WriteLine("AddBinaryStrings: " + "1010110111001101101000, " + "1000011011000000111100110");
            Console.WriteLine(addBinary("1010110111001101101000", "1000011011000000111100110"));

            Console.WriteLine();
        }
        private static string addBinary(string A, string B)
        {
            int aLength = A.Length;
            int bLength = B.Length;
            int max = aLength > bLength ? aLength : bLength;

            int carry = 0;
            StringBuilder sum = new StringBuilder();
            int add = 0;

            int firstDigit = 0;
            int secondDigit = 0;

            for (int i = 0; i < max; i++)
            {

                firstDigit = getBit(A, aLength - i - 1);
                secondDigit = getBit(B, bLength - i - 1);
                add = firstDigit + secondDigit + carry;
                sum.Append(add % 2);
                carry = add / 2;
            }

            if (carry == 1)
            {
                sum.Append("1");
            }

            char[] inputarray = sum.ToString().ToCharArray();
            Array.Reverse(inputarray);
            return new string(inputarray);
        }

        private static int getBit(String s, int index)
        {
            if (index < 0 || index >= s.Length)
                return 0;

            if (s.Substring(index, 1) == "0")
                return 0;
            else
                return 1;
        }
    }
}
