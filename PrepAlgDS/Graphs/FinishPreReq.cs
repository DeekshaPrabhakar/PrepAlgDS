using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrepAlgDS.Graphs
{
    class FinishPreReq
    {
        public class GraphNode
        {
            public int id;
            public List<GraphNode> dids;
            public GraphNode(int id)
            {
                this.id = id;
                this.dids = new List<GraphNode>();
            }
        }
        public static void Run()
        {
        }

        public int solve(int A, List<int> B, List<int> C)
        {
            var nodes = new List<GraphNode>();
            for (int i = 1; i <= A; i++)
            {
                nodes.Add(new GraphNode(i));
            }

            for (int i = 0; i < B.Count(); i++)
            {
                nodes[B[i] - 1].dids.Add(nodes[C[i] - 1]);
            }

            foreach (var node in nodes)
            {
                if (Bfs(node) == 0)
                {
                    return 0;
                }
            }

            return 1;
        }
        public int Bfs(GraphNode g)
        {
            var q = new Queue<GraphNode>();
            q.Enqueue(g);
            var visited = new HashSet<GraphNode>();
            while (q.Count() != 0)
            {
                var node = q.Dequeue();
                foreach (var n in node.dids)
                {
                    if (visited.Contains(n))
                    {
                        return 0;
                    }
                    q.Enqueue(n);
                }
                visited.Add(node);
            }
            return 1;
        }



    }
}
