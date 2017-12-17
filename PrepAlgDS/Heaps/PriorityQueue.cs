using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrepAlgDS.Heaps
{
    public class PriorityQueue<T> where T : IComparable<T>
    {
        Heap<T> _heap = new Heap<T>();
        public void Enqueue(T value)
        {
            _heap.Add(value);
        }
        public T Dequeue()
        {
            return _heap.RemoveMax();
        }
        public void Clear()
        {
            _heap.Clear();
        }
        public int Count
        {
            get
            {
                return _heap.Count;
            }
        }
    }
}
