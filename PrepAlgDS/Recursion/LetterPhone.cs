using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrepAlgDS.Recursion
{
    class LetterPhone
    {
        public static void Run()
        {
            Util.DisplayListOfStrings(letterCombinations("23"));
        }

        public static List<string> letterCombinations(string A)
        {
            Dictionary<char, char[]> map = new Dictionary<char, char[]>();
            map.Add('0', new char[] { '0' });
            map.Add('1', new char[] { '1' });
            map.Add('2', new char[] { 'a', 'b', 'c' });
            map.Add('3', new char[] { 'd', 'e', 'f' });
            map.Add('4', new char[] { 'g', 'h', 'i' });
            map.Add('5', new char[] { 'j', 'k', 'l' });
            map.Add('6', new char[] { 'm', 'n', 'o' });
            map.Add('7', new char[] { 'p', 'q', 'r', 's' });
            map.Add('8', new char[] { 't', 'u', 'v' });
            map.Add('9', new char[] { 'w', 'x', 'y', 'z' });

            List<string> resultList = new List<string>();
            StringBuilder sb = new StringBuilder();
            phone(map, A, sb, resultList);
            return resultList;
        }

        public static void phone(Dictionary<char, char[]> map, String digits, StringBuilder combination, List<string> result)
        {
            if (combination.Length == digits.Length)
            {
                result.Add(combination.ToString());
                return;
            }

            char[] mappedCharacters = map[digits.ToCharArray()[combination.Length]];
            foreach (char c in mappedCharacters)
            {//choose - explore - unchoose
                combination.Append(c);
                phone(map, digits, combination, result);
                combination.Remove(combination.Length - 1, 1);
            }
        }
    }
}
