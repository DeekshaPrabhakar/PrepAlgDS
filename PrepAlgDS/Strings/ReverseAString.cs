using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrepAlgDS.Strings
{
    class ReverseAString
    {
        public static void Run()
        {
            Console.WriteLine("ReverseTheString:    fwbpudnbrozzifml osdt  ulc jsx kxorifrhubk ouhsuhf  sswz qfho dqmy  sn myq igjgip iwfcqq");
            Console.WriteLine(reverseWords("   fwbpudnbrozzifml osdt  ulc jsx kxorifrhubk ouhsuhf  sswz qfho dqmy  sn myq igjgip iwfcqq"));
            Console.WriteLine();
        }
        private static String reverseWords(String a)
        {
            String[] words = a.Split(' ');
            StringBuilder sb = new StringBuilder();

            for (int i = words.Length - 1; i >= 0; i--)
            {
                if (words[i].Trim() != "")
                {
                    if (i == 0)
                    {
                        sb.Append(words[i]);
                    }
                    else
                    {
                        sb.Append(words[i] + " ");
                    }
                }
            }

            if (sb.Length > 1)
            {
                if (sb[sb.Length - 1].ToString().Trim().Length == 0)
                {
                    sb.Remove(sb.Length - 1, 1);
                }
            }

            return sb.ToString();
        }
    }
}
