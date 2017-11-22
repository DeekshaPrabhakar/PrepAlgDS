using PrepAlgDS.Checkpoints;
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
            RunCheckpoints();
            Console.ReadLine();
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
