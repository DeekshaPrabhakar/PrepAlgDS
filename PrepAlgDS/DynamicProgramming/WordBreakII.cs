using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrepAlgDS.DynamicProgramming
{
    class WordBreakII
    {
        public static void Run()
        {
            Util.DisplayListOfStrings(wordBreak("catsanddog", new List<string>(new string[] {"cat", "cats", "and", "sand", "dog" })));
        }


        private static List<List<string>> cache;
        private static HashSet<string> words = new HashSet<string>();
        public static List<string> wordBreak(string A, List<string> B)
        {
            cache = new List<List<string>>();

            for (int i = 0; i < A.Length; i++)
            {
                cache.Add(null);
            }

            for (int i = 0; i < B.Count; i++)
            {
                words.Add(B[i]);
            }

            var result = recur(A, 0);
            return result;
        }

        private static List<string> recur(string A, int ia)
        {
            if (cache[ia] != null)
                return cache[ia];

            List<string> result = new List<string>();
            cache[ia] = result;
            for (int l = 1; ia + l <= A.Length; l++)
            {
                string word = A.Substring(ia, l);

                if (words.Contains(word))
                {

                    if (ia + l == A.Length)
                    {
                        result.Add(word);
                    }
                    else
                    {
                        var sr = recur(A, ia + l);
                        for (int k = 0; k < sr.Count; k++)
                        {
                            string t = word + " " + sr[k];
                            result.Add(t);
                        }
                    }
                }
            }

            return result;
        }
    }
}
