using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrepAlgDS.HashTables
{
    class Anagram
    {
        public static void Run()
        {
            List<string> inpt = new List<string>(new string[] { "cat", "dog", "god", "tca" });
            Util.Display(anagramIndex(inpt));
        }

        public static List<List<int>> anagramIndex(List<string> A)
        {
            List<List<int>> outputarray = new List<List<int>>();
            Dictionary<string, List<int>> dict = new Dictionary<string, List<int>>();
            char[] inptChararray =  null;
            for(int i = 0; i< A.Count; i++)
            {
                inptChararray = A[i].ToCharArray();
                Array.Sort(inptChararray);
                String sortedChars = new String(inptChararray);
                if(!dict.ContainsKey(sortedChars))
                {
                    dict.Add(sortedChars, new List<int>(new int[] { i + 1 }));
                }
                else
                {
                    dict[sortedChars].Add(i + 1);
                }
            }

            foreach(KeyValuePair<string, List<int>> kv in dict)
            {
                List<int> anagramIndexes = kv.Value;
                anagramIndexes.Sort();
                outputarray.Add(anagramIndexes);
            }

            return outputarray;
        }

    }
}
