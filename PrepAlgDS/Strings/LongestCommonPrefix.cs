using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrepAlgDS.Strings
{
    class LongestCommonPrefix
    {
        public static void Run()
        {
            List<string> inptList = new List<string>();
            int numberOfStrings = int.Parse(Console.ReadLine());
            for(int i=0; i < numberOfStrings; i++)
            {
                inptList.Add(Console.ReadLine());
            }
            Console.WriteLine(commonPrefix(inptList));
        }

        public static string commonPrefix(List<string> A) 
        {
            StringBuilder sb = new StringBuilder();
            string prefix = "";

            int smallestString = 0;
            foreach(string s in A)
            {
                smallestString = smallestString > 0 && s.Length > smallestString ? smallestString : s.Length;
            }

            int i = 0;
            bool endComparison = false;
            while(i<smallestString)
            {
                endComparison = false;
                foreach(string s in A)
                {
                    if(prefix == "")
                    {
                        prefix = s[i].ToString();
                    }
                    else
                    {
                        if(s[i].ToString() != prefix)
                        {
                            endComparison = true;
                            break;
                        }
                    }
                }
                if (endComparison)
                {
                    break;
                }

                sb.Append(prefix);
                prefix = "";
                i = i + 1;
            }

            return sb.ToString();
        }

    }
}
