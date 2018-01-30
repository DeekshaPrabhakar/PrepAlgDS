using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrepAlgDS.Graphs
{
    class WordLadder
    {
        public static void Run()
        {
            string start = "hit";
            string end = "cog";
            List<string> dict = new List<string>(new string[] { "hot", "dot", "dog", "lot", "log" });
            Console.Write(ladderLength(start, end, dict));
        }

        public class StrNode
        {
            public string str;
            public int distance;
            public StrNode(String str, int distance)
            {
                this.str = str;
                this.distance = distance;
            }
        }
        public static int ladderLength(string start, string end, List<string> dictV)
        {
            if (start == end)
            {
                return 1;
            }
            Queue<StrNode> qe = new Queue<StrNode>();
            int min = int.MaxValue;
            Dictionary<string, bool> mp = new Dictionary<string, bool>();
            qe.Enqueue(new StrNode(start, 1));
            mp.Add(start, true);

            while (qe.Count != 0)
            {
                StrNode st = qe.Dequeue();
                /*System.out.println(st.str + st.distance());*/
                int distance = st.distance;
                if (changeString(st.str, end))
                {
                    min = Math.Min(min, distance + 1);
                }

                foreach (string pr in dictV)
                {
                    if (!mp.ContainsKey(pr) && changeString(st.str, pr))
                    {
                        mp.Add(pr, true);
                        qe.Enqueue(new StrNode(pr, distance + 1));
                    }
                }
            }

            if (min != int.MaxValue)
            {
                return min;
            }
            return 0;
        }
        public static bool changeString(string dictVstr, string end)
        {
            int i = 0;
            int count = 0;
            while (i < end.Length)
            {
                if (dictVstr[i] != end[i])
                {
                    count++;
                }
                if (count == 2)
                {
                    return false;
                }
                i++;
            }
            return true;

        }
    }
}
