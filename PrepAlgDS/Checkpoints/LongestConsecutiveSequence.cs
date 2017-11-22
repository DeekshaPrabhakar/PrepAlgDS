using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrepAlgDS.Checkpoints
{
    class LongestConsecutiveSequence
    {
        public static void Run()
        {
            Console.WriteLine("Checkpoint 5: Longest Consecutive Sequence: unsorted array of integers [100, 4, 200, 1, 3, 2], find the length of the longest consecutive elements sequence");
            List<int> input = new List<int>(new int[] { 100, 4, 200, 1, 3, 2 });
            Console.WriteLine(longestConsecutive(input));
        }

        public static int longestConsecutive(List<int> A)
        {
            int count = 0;
            int max = 0;
            var set = new HashSet<int>(A);

            if (A.Count == 0)
            {
                return 0;
            }

            for (int i = 0; i < A.Count; i++)
            {
                int left = A[i] - 1;
                int right = A[i] + 1;
                count = 1;

                while (set.Contains(left))
                {
                    count++;
                    set.Remove(left);
                    left--;
                }

                while (set.Contains(right))
                {
                    count++;
                    set.Remove(right);
                    right++;
                }

                max = Math.Max(count, max);
            }
            return max;
        }
    }
}
