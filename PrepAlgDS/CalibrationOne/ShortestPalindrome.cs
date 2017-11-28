using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrepAlgDS.CalibrationOne
{
    class ShortestPalindrome
    {
         public static void Run()
        {
            int res;
            string s;
            s = Console.ReadLine();

            res = shortestPalindrome(s);
            Console.WriteLine(res);

        }

         static int shortestPalindrome(string s)
         {
             int shortest = 0;
             int index = s.Length / 2;
             int startIndex = 0;
             int endIndex = s.Length - 1;
             int count = index;


             while(count <= 0)
             {
                 if (s[startIndex] != s[endIndex])
                 {
                     shortest++;
                 }
                 startIndex = startIndex + 1;
                 endIndex = endIndex - 1;
             }



             return shortest;
         }
    }
}
