using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrepAlgDS.Strings
{
    class JustifyText
    {
        public static void Run()
        {
            //List<string> inptList = new List<string>();
            //int numberOfStrings = int.Parse(Console.ReadLine());
            //for (int i = 0; i < numberOfStrings; i++)
            //{
            //    inptList.Add(Console.ReadLine());
            //}

            //int L = int.Parse(Console.ReadLine());

            List<string> inptList = new List<string>(new string[] { "What", "must", "be", "shall", "be." });
            int L = 12;
            Util.DisplayListOfStrings(fullJustify(inptList, L));
        }

        private static List<string> fullJustify(List<string> A, int B) 
        {
            List<string> lines = new List<string>();
            StringBuilder sbLine = new StringBuilder();
            int lineCount = 0;

            foreach(string inpt in A)
            {
                if((lineCount + inpt.Length) <= B)
                {
                    sbLine.Append(inpt + " ");
                    lineCount = sbLine.Length;
                }
                else
                {
                    lineCount = lineCount - 1;
                    lines.Add(addSpaceToJustifyText(sbLine.ToString(), (B-lineCount)));
                    sbLine = new StringBuilder();
                    lineCount = 0;
                    if ((lineCount + inpt.Length) <= B)
                    {
                        sbLine.Append(inpt + " ");
                        lineCount = sbLine.Length;
                    }
                }
            }

            if(!string.IsNullOrEmpty(sbLine.ToString()))
            {
                lineCount = sbLine.Length;
                lineCount = lineCount - 1;
                string lastLine = addSpaceToJustifyTextLastLine(sbLine.ToString(), (B - lineCount));
                lines.Add(lastLine);
            }

            return lines;
        }

        private static string addSpaceToJustifyTextLastLine(string text, int spaceCount)
        {
            StringBuilder sb = new StringBuilder();
            String[] textarray = text.Split(' ');
            for (int i = 0; i < textarray.Length - 1; i++)
            {
                sb.Append(textarray[i] + " ");
                spaceCount = spaceCount - 1;
            }

            sb.Append(textarray[textarray.Length - 1]);
            while (spaceCount >= 0)
            {
                sb.Append(" ");
                spaceCount = spaceCount - 1;
            }
            return sb.ToString();
        }

        private static string addSpaceToJustifyText(string text, int spaceCount)
        {
            text = text.Substring(0, text.Length - 1);
            StringBuilder sb = new StringBuilder();
            String[] textarray = text.Split(' ');
            int spacesBw = textarray.Length -1;
            bool extraSpaceToTheFirstWord = (spacesBw == 0 || (spaceCount % spacesBw == 0)) ? false : true;
            int noOfSpacesBW = spacesBw != 0 ? (spaceCount / spacesBw) + 1 : spaceCount;
            int firstWordSpace = extraSpaceToTheFirstWord ? noOfSpacesBW + (spaceCount % spacesBw) : noOfSpacesBW;

            sb.Append(textarray[0]);
            while (firstWordSpace > 0)
            {
                sb.Append(" ");
                firstWordSpace = firstWordSpace - 1;
            }

            for (int i = 1; i < textarray.Length; i++)
            {
                int j = noOfSpacesBW;
                sb.Append(textarray[i]);
                if (i != textarray.Length - 1)
                {
                    while (j > 0)
                    {
                        sb.Append(" ");
                        j = j - 1;
                    }
                }
            }

            return sb.ToString();
        }
    }
}
