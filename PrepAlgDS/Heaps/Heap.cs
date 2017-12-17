using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrepAlgDS.Heaps
{
    public class Heap<T> where T : IComparable<T>
    {
        T[] _items;
        int _count;
        const int DEFAULT_LENGTH = 100;
        public Heap()
            : this(DEFAULT_LENGTH)
        {
        }
        public Heap(int length)
        {
            _items = new T[length];
            _count = 0;
        }
        public void Add(T value)
        {
            if (_count >= _items.Length)
            {
                GrowBackingArray();
            }
            _items[_count] = value;
            int index = _count;
            while (index > 0 && _items[index].CompareTo(_items[Parent(index)]) > 0)
            {
                Swap(index, Parent(index));
                index = Parent(index);
            }
            _count++;
        }
        private void GrowBackingArray()
        {
            T[] newItems = new T[_items.Length * 2];
            for (int i = 0; i < _items.Length; i++)
            {
                newItems[i] = _items[i];
            }
            _items = newItems;
        }
        public T Peek()
        {
            if (Count > 0)
            {
                return _items[0];
            }
            throw new InvalidOperationException();
        }
        public T RemoveMax()
        {
            if (Count <= 0)
            {
                throw new InvalidOperationException();
            }
            T max = _items[0];
            _items[0] = _items[_count - 1];
            _count--;
            int index = 0;
            while (index < _count)
            {
                // Get the left and right child indexes.
                int left = (2 * index) + 1;
                int right = (2 * index) + 2;
                // Make sure we are still within the heap.
                if (left >= _count)
                {
                    break;
                }
                // To avoid having to swap twice, we swap with the largest value.
                // E.g.,
                // 5
                // 6 8
                //
                // If we swapped with 6 first we'd have
                //
                // 6
                // 5 8
                //
                // and we'd require another swap to get the desired tree.
                //
                // 8
                // 6 5
                //
                // So we find the largest child and just do the right thing at the start.
                int maxChildIndex = IndexOfMaxChild(left, right);
                if (_items[index].CompareTo(_items[maxChildIndex]) > 0)
                {
                    // The current item is larger than its children (heap property is satisfied).
                    break;
                }
                Swap(index, maxChildIndex);
                index = maxChildIndex;
            }
            return max;
        }
        private int IndexOfMaxChild(int left, int right)
        {
            // Find the index of the child with the largest value.
            int maxChildIndex = -1;
            if (right >= _count)
            {
                // No right child.
                maxChildIndex = left;
            }
            else
            {
                if (_items[left].CompareTo(_items[right]) > 0)
                {
                    maxChildIndex = left;
                }
                else
                {
                    maxChildIndex = right;
                }
            }
            return maxChildIndex;
        }
        public int Count
        {
            get
            {
                return _count;
            }
        }
        public void Clear()
        {
            _count = 0;
            _items = new T[DEFAULT_LENGTH];
        }
        private int Parent(int index)
        {
            return (index - 1) / 2;
        }
        private void Swap(int left, int right)
        {
            T temp = _items[left];
            _items[left] = _items[right];
            _items[right] = temp;
        }
    }

}
