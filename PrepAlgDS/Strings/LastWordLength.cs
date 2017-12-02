using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrepAlgDS.Strings
{
    class LastWordLength
    {
        public static void Run()
        {
            Console.WriteLine(lengthOfLastWord(Console.ReadLine()));
        }

        public static int lengthOfLastWord(String a)
        {
            int count = 0;
            int startingIndex = (a.Length - 1);

            while (startingIndex >= 0 && a[startingIndex] == ' ')
            {
                startingIndex = startingIndex - 1;
            }

            if (startingIndex < 0)
            {
                return 0;
            }

            for (int i = startingIndex; i >= 0; i--)
            {
                if (a[i] != ' ')
                {
                    count = count + 1;
                }
                else
                {
                    break;
                }
            }

            return count;
        }
    }
}
