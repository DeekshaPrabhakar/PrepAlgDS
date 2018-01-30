using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrepAlgDS.Graphs
{
    class CloneGraph
    {
        public class UndirectedGraphNode
        {
            public int label;
            public List<UndirectedGraphNode> neighbors;
            public UndirectedGraphNode(int x) 
            { 
                label = x; 
                neighbors = new List<UndirectedGraphNode>(); 
            }
        }

        public static void Run()
        {
        }
        public UndirectedGraphNode cloneGraph(UndirectedGraphNode node)
        {
            Queue<UndirectedGraphNode> q = new Queue<UndirectedGraphNode>();
            q.Enqueue(node);

            // An HashMap to keep track of all the
            // nodes which have already been created
            Dictionary<UndirectedGraphNode, UndirectedGraphNode> hm = new Dictionary<UndirectedGraphNode, UndirectedGraphNode>();

            //Put the node into the HashMap
            hm.Add(node, new UndirectedGraphNode(node.label));

            while (q.Count != 0)
            {
                // Get the front node from the queue
                // and then visit all its neighbours
                UndirectedGraphNode u = q.Dequeue();

                // Get corresponding Cloned Graph Node
                UndirectedGraphNode cloneNodeU = hm[u];
                if (u.neighbors != null)
                {
                    List<UndirectedGraphNode> v = u.neighbors;
                    foreach (UndirectedGraphNode graphNode in v)
                    {
                        // Get the corresponding cloned node
                        // If the node is not cloned then we will
                        // simply get a null
                        UndirectedGraphNode cloneNodeG = hm[graphNode];

                        // Check if this node has already been created
                        if (cloneNodeG == null)
                        {
                            q.Enqueue(graphNode);

                            // If not then create a new Node and
                            // put into the HashMap
                            cloneNodeG = new UndirectedGraphNode(graphNode.label);
                            hm.Add(graphNode, cloneNodeG);
                        }

                        // add the 'cloneNodeG' to neighbour
                        // vector of the cloneNodeG
                        cloneNodeU.neighbors.Add(cloneNodeG);
                    }
                }
            }

            // Return the reference of cloned source Node
            return hm[node];
        }
    }
}
