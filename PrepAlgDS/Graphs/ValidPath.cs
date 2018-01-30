using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrepAlgDS.Graphs
{
    class ValidPath
    {
        public static void Run()
        {
        }
        struct Point
        {
            public int x;
            public int y;

            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }

        bool isInCircle(int x, int y, int R, List<int> centerX, List<int> centerY)
        {
            int R2 = R * R;

            for (int i = 0; i < centerX.Count; i++)
            {
                int dx = Math.Abs(x - centerX[i]);
                int dy = Math.Abs(y - centerY[i]);
                if (dx + dy <= R) return true;
                if (dx > R) continue;
                if (dy > R) continue;

                if ((dx * dx + dy * dy) <= R2) return true;
            }

            return false;
        }

        public string solve(int x, int y, int N, int R, List<int> centerX, List<int> centerY)
        {
            bool[,] matrix = new bool[x + 1, y + 1];
            Queue<Point> toExplore = new Queue<Point>();
            matrix[0, 0] = true;
            toExplore.Enqueue(new Point(0, 0));

            while (toExplore.Count > 0)
            {
                Point p = toExplore.Dequeue();

                if (p.x == x && p.y == y)
                {
                    return "YES";
                }

                for (int i = -1; i <= 1; i++)
                {
                    for (int j = -1; j <= 1; j++)
                    {
                        if (i != 0 || j != 0)
                        {
                            int lx = p.x + i;
                            int ly = p.y + j;

                            if (lx >= 0 && lx <= x && ly >= 0 && ly <= y && !matrix[lx, ly])
                            {
                                matrix[lx, ly] = true;
                                if (!isInCircle(lx, ly, R, centerX, centerY))
                                {
                                    toExplore.Enqueue(new Point(lx, ly));
                                }
                            }
                        }
                    }
                }
            }

            return "NO";
        }
    }
}
