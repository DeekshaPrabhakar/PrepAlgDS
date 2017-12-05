using PrepAlgDS.Arrays;
using PrepAlgDS.CalibrationOne;
using PrepAlgDS.Checkpoints;
using PrepAlgDS.HashTables;
using PrepAlgDS.LinkedLists;
using PrepAlgDS.Strings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrepAlgDS
{
    class Program
    {
        static void Main(string[] args)
        {
            RunLinkedLists();
            RunHashtables();
            //RunFirstPrep();
            //RunArrays();
            //RunStrings();
            //RunCalibrationOne();
            //RunCheckpoints();
            Console.ReadLine();
        }

        private static void RunHashtables()
        {
            LongestSubstring.Run();
            //Anagram.Run();
        }

        private static void RunLinkedLists()
        {
            //RemoveDuplicateSorted.Run();
            //AddTwoNumbers.Run();
        }

        private static void RunFirstPrep()
        {
            //Console.WriteLine(maxLength(new int[] { 3, 1, 2, 1 }, 4));
            Console.WriteLine(longestSubsequence("abc", "aedace"));
        }

        static int longestSubsequence(string x, string y)
        {
            int len = 0;
            System.Text.StringBuilder sbX = new System.Text.StringBuilder();
            System.Text.StringBuilder sbY = new System.Text.StringBuilder();


            for (int i = 0; i < y.Length;i++ )
            {
                if(x[i] == y[i])
                {
                    sbY.Append(y[i]);
                }
            }
            len = sbY.Length;
                //System.Text.StringBuilder sb = new System.Text.StringBuilder();
                //int i = 0;
                //char[] xArray = x.ToArray();

                //while(i < y.Length)
                //{
                //    if (isSubsequence(sb.ToString() + y[i], xArray))
                //    {
                //        sb.Append(y[i]);
                //        len = sb.Length > len ? sb.Length : len;
                //    }
                //    else
                //    {
                //        sb = new System.Text.StringBuilder();
                //    }
                //    i = i + 1;
                //}

                return len;
        }

        static bool isSubsequence(string partY, char[] x)
        {
            bool isSubsq = true;
            List<char> xList = x.ToList<char>();

            for (int i = 0; i < partY.Length; i++)
            {
                if (!xList.Contains(partY[i]))
                {
                    isSubsq = false;
                    break;
                }
                else
                {
                    xList.Remove(partY[i]);
                }
            }

            return isSubsq;
        }

        static int maxLength(int[] a, int k)
        {
            int longestSubarrayLength = 0;
            int sum = 0;
            int startingIndex = 0;
            List<int> subArray = new List<int>();

            int i = 0;
            while (i < a.Length)
            {
                if (sum + a[i] <= k)
                {
                    sum += a[i];
                    subArray.Add(a[i]);
                }
                else
                {
                    longestSubarrayLength = subArray.Count > longestSubarrayLength ? subArray.Count : longestSubarrayLength;
                    sum -= a[startingIndex];
                    subArray.RemoveAt(startingIndex);
                    startingIndex = startingIndex + 1;
                }
                i = i + 1;
            }

            if (subArray.Count > 0)
            {
                longestSubarrayLength = subArray.Count > longestSubarrayLength ? subArray.Count : longestSubarrayLength;
            }

            return longestSubarrayLength;
        }

        private static void RunStrings()
        {
            //PrettyJSON.Run();
            //AddBinaryStrings.Run();
            //SetMatrixZeros.Run();
            //JustifyText.Run();
            //LongestCommonPrefix.Run();
            //LastWordLength.Run();
            //ReverseAString.Run();
            //PalindromeString.Run();
        }
        private static void RunArrays()
        {
            //SpiralOderII.Run();
            //PascalTriangle.Run();
            //AddOneToNumber.Run();

            //Yet to complete
            //RotateMatrix.Run();
        }

        private static void RunCalibrationOne()
        {
            //Winner.Run();
            //Braces.Run();
            //ArrangingCoins.Run();
            //DegreeArray.Run();
        }

        private static void RunCheckpoints()
        {
            PrettyPrint.Run();
            NumRange.Run();
            NextGreater.Run();
            LongestConsecutiveSequence.Run();
        }
    }
}
