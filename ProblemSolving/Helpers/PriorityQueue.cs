using System;
using System.Collections;
using System.Collections.Generic;

namespace Helpers
{
    //A binary heap impelemntation
    public class PriorityQueue<T> : IEnumerable<T>
    {
        private readonly List<T> list;
        private readonly IComparer<T> comparer;

        public PriorityQueue(IComparer<T> comparer = null)
        {
            this.comparer = comparer ?? Comparer<T>.Default;
            this.list = new List<T>();
        }

        public void Add(T x)
        {
            list.Add(x);
            SiftUp(Count - 1, x);
        }

        public T Poll()
        {
            var ret = list[0];
            RemoveAt(0);
            return ret;
        }

        public T Peek() => list[0];

        public bool Remove(T item)
        {
            var i = list.IndexOf(item);
            RemoveAt(i);
            return true;
        }

        public int Count => list.Count;//Count is cached in List implelemtation

        public void DisplayHeap() => list.ForEach(x => Console.WriteLine(x));

        private T RemoveAt(int i)
        {
            var lastIndex = Count - 1;
            if (lastIndex == i)
            {
                // removed last element
                list.RemoveAt(lastIndex);
                return default;
            }

            var moved = list[lastIndex];
            list.RemoveAt(lastIndex);
            SiftDown(i, moved);
            if (comparer.Compare(list[i], moved) == 0)
            {
                SiftUp(i, moved);
            }
            return moved;
        }

        private void SiftUp(int child, T x)
        {
            var count = Count;
            while (child > 0)
            {
                // parent index
                var parent = (child - 1) / 2;
                // child item is larger than (or equal) parent so we're done
                if (comparer.Compare(list[parent], x) <= 0) break;

                list[child] = list[parent];
                child = parent;
            }

            if (count > 0) list[child] = x;
        }

        private void SiftDown(int i, T root)
        {
            var count = Count;
            while (i * 2 + 1 < count)
            {
                var l = 2 * i + 1; //left child
                if (l > count) break;  // no children so we're done

                var r = 2 * i + 2; // right child
                var c = r < count && comparer.Compare(list[r], list[l]) < 0 ? r : l;

                if (comparer.Compare(list[c], root) >= 0) break;

                list[i] = list[c];
                i = c;
            }

            if (count > 0) list[i] = root;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var item = Poll();
            yield return item;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}