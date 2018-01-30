using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrepAlgDS.Graphs
{
    class Graph
    {
        private Dictionary<int, Node> map = new Dictionary<int, Node>();

        public class Node
        {
            public  int id;
            public LinkedList<Node> adjacent = new LinkedList<Node>();
            private Node(int id)
            {
                this.id = id;
            }
        }

        private Node getNode(int id)
        {
            return map[id];
        }

        public void addEdge(int source, int destination)
        {
            Node s = getNode(source);
            Node d = getNode(destination);
            s.adjacent.AddLast(d);
        }

        public bool hasPathDFS(int source, int destination)
        {
            Node s = getNode(source);
            Node d = getNode(destination);
            List<int> visited = new List<int>();
            return hasPathDFS(s, d, visited);
        }

        private bool hasPathDFS(Node source, Node destination, List<int> visited)
        {
            if (visited.Contains(source.id))
            {
                return false;
            }
            if (source == destination)
            {
                return true;
            }
            foreach (Node child in source.adjacent)
            {
                if (hasPathDFS(child, destination, visited))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
