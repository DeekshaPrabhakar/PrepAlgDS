using PrepAlgDS.Arrays;
using PrepAlgDS.CalibrationOne;
using PrepAlgDS.Checkpoints;
using PrepAlgDS.Strings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrepAlgDS
{
    class Program
    {
        static void Main(string[] args)
        {
            //RunArrays();
            RunStrings();
            //RunCalibrationOne();
            //RunCheckpoints();
            Console.ReadLine();
        }

        private static void RunStrings()
        {
            JustifyText.Run();
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
