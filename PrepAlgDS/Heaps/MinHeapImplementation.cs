using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrepAlgDS.Heaps
{
    public class MinHeapImplementation
    {
        private List<int> priorityQueue;

        public MinHeapImplementation()
        {
            priorityQueue = new List<int>();
        }

        public int getCount()
        {
            return priorityQueue.Count;
        }
        public int getMinimum()
        {
            return priorityQueue[0];
        }

        public void deleteElement(int val)
        {
            priorityQueue.Remove(val);
            heapifyFromEndToStart();
        }

        public void enqueue(int val)
        {
            priorityQueue.Add(val);
            heapifyFromEndToStart();
        }

        private void heapifyFromEndToStart()
        {
            int pos = priorityQueue.Count - 1;
            int parent = getParent(pos);

            while (pos > 0)
            {
                //heap[i] will have children at 2i+1 & 2i-1 and parent heap at (i-1)/2
                int parentPos = (pos - 1) / 2;
                if (priorityQueue[parentPos] > priorityQueue[pos])
                {
                    swap(parentPos, pos);
                    pos = parentPos;
                }
                else
                {
                    break;
                }
            }
        }

        private int getParent(int pos)
        {
            if (pos <= 0)
                return 0;
            else
            {
                double parentPos = pos / 2;
                double d = Math.Floor(parentPos);
                return priorityQueue[int.Parse(d.ToString())];
            }
        }

        public void swap(int pos1, int pos2)
        {
            int temp = priorityQueue[pos1];
            priorityQueue[pos1] = priorityQueue[pos2];
            priorityQueue[pos2] = temp;
        }
    }
}
