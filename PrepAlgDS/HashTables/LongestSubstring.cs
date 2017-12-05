using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrepAlgDS.HashTables
{
    class LongestSubstring
    {
        public static void Run()
        {
            Console.WriteLine(longestSubStringWithoutRepeat("u"));
        }

        private static int longestSubStringWithoutRepeat(string A)
        {
            int count = 0;
            Dictionary<char, int> dict = new Dictionary<char, int>();
            StringBuilder sb = new StringBuilder();
            int i = 0;
            while(i< A.Length)
            { 
                if(!dict.ContainsKey(A[i]))
                {
                    dict.Add(A[i], i);
                    sb.Append(A[i].ToString());
                    i = i + 1;
                }
                else
                {
                    count = sb.Length > count ? sb.Length : count;
                    sb = new StringBuilder();
                    i = dict[A[i]] + 1;
                    dict = new Dictionary<char, int>();
                }
            }

            return count;
        }
    }
}
