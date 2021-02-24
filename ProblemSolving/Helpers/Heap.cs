using System;
using System.Collections;
using System.Collections.Generic;

namespace Helpers
{
    public class Heap<T> : IEnumerable where T : IComparable<T>
    {
        private readonly bool _isMin;
        private readonly IComparer<T> _comparer;
        public int Capacity { get; }

        public Heap(int size, bool isMin = true, IComparer<T> comparer = null)
        {
            Capacity = size;
            _isMin = isMin;
            _comparer = comparer ?? Comparer<T>.Create((n1, n2) => n1.CompareTo(n2));
            Elements = new T[size];
        }

        public int Count { get; private set; }
        public T[] Elements { get; private set; }

        private int GetLeftChildIndex(int elementIndex) => 2 * elementIndex + 1;
        private int GetRightChildIndex(int elementIndex) => 2 * elementIndex + 2;
        private int GetParentIndex(int elementIndex) => (elementIndex - 1) / 2;

        private bool HasLeftChild(int elementIndex) => GetLeftChildIndex(elementIndex) < Count;
        private bool HasRightChild(int elementIndex) => GetRightChildIndex(elementIndex) < Count;
        private bool IsRoot(int elementIndex) => elementIndex == 0;

        private T GetLeftChild(int elementIndex) => Elements[GetLeftChildIndex(elementIndex)];
        private T GetRightChild(int elementIndex) => Elements[GetRightChildIndex(elementIndex)];
        private T GetParent(int elementIndex) => Elements[GetParentIndex(elementIndex)];

        private void Swap(int firstIndex, int secondIndex)
        {
            var temp = Elements[firstIndex];
            Elements[firstIndex] = Elements[secondIndex];
            Elements[secondIndex] = temp;
        }

        public bool IsEmpty()
        {
            return Count == 0;
        }

        public T Peek()
        {
            if (Count == 0)
                throw new IndexOutOfRangeException();

            return Elements[0];
        }

        public T Pop()
        {
            if (Count == 0)
                throw new IndexOutOfRangeException();

            var result = Elements[0];
            Elements[0] = Elements[Count - 1];
            Count--;

            if (_isMin) ReCalculateDown();
            else ReCalculateDownMax();

            return result;
        }

        public void Add(T element)
        {
            if (Count == Elements.Length)
            {
                var temp = new T[Count * 2 + 1];
                Array.Copy(Elements, temp, Count);
                Elements = temp;
            }
            Elements[Count] = element;
            Count++;

            if (_isMin) ReCalculateUp();
            else ReCalculateUpMax();
        }

        private void ReCalculateDownMax()
        {
            int index = 0;
            while (HasLeftChild(index))
            {
                var biggerIndex = GetLeftChildIndex(index);
                if (HasRightChild(index) && _comparer.Compare(GetRightChild(index), GetLeftChild(index)) > 0)
                {
                    biggerIndex = GetRightChildIndex(index);
                }

                if (_comparer.Compare(Elements[biggerIndex], Elements[index]) < 0)
                {
                    break;
                }

                Swap(biggerIndex, index);
                index = biggerIndex;
            }
        }

        private void ReCalculateUpMax()
        {
            var index = Count - 1;
            while (!IsRoot(index) && _comparer.Compare(Elements[index], GetParent(index)) > 0)
            {
                var parentIndex = GetParentIndex(index);
                Swap(parentIndex, index);
                index = parentIndex;
            }
        }

        private void ReCalculateDown()
        {
            int index = 0;
            while (HasLeftChild(index))
            {
                var smallerIndex = GetLeftChildIndex(index);
                if (HasRightChild(index) && _comparer.Compare(GetRightChild(index), GetLeftChild(index)) < 0)
                {
                    smallerIndex = GetRightChildIndex(index);
                }

                var diff = _comparer.Compare(Elements[smallerIndex], Elements[index]);
                if (diff == 0 || diff == 1)
                {
                    break;
                }

                Swap(smallerIndex, index);
                index = smallerIndex;
            }
        }

        private void ReCalculateUp()
        {
            var index = Count - 1;
            while (!IsRoot(index) && _comparer.Compare(Elements[index], GetParent(index)) < 0)
            {
                var parentIndex = GetParentIndex(index);
                Swap(parentIndex, index);
                index = parentIndex;
            }
        }

        public void Delete(T num)
        {
            for (int i = 0; i < Count; i++)
            {
                if (Elements[i].Equals(num))
                {
                    DeleteAt(i);
                    return;
                }
            }
        }

        // To heapify a subtree rooted with node i which is  
        // an index in arr[].Nn is size of heap  
        void heapify(int n, int i)
        {
            int largest = i; // Initialize largest as root  
            int l = 2 * i + 1; // left = 2*i + 1  
            int r = 2 * i + 2; // right = 2*i + 2  

            if (_isMin)
            {
                if (l < n && _comparer.Compare(Elements[l], Elements[largest]) < 0)
                    largest = l;

                if (r < n && _comparer.Compare(Elements[r], Elements[largest]) < 0)
                    largest = r;
            }
            else
            {
                // If left child is larger than root  
                if (l < n && _comparer.Compare(Elements[l], Elements[largest]) > 0)
                    largest = l;

                // If right child is larger than largest so far  
                if (r < n && _comparer.Compare(Elements[r], Elements[largest]) > 0)
                    largest = r;
            }

            // If largest is not root  
            if (largest != i)
            {
                T swap = Elements[i];
                Elements[i] = Elements[largest];
                Elements[largest] = swap;

                // Recursively heapify the affected sub-tree  
                heapify(n, largest);
            }
        }

        // Function to delete the root from Heap  
        int DeleteAt(int n)
        {
            // Get the last element  
            T lastElement = Elements[Count - 1];

            // Replace root with first element  
            Elements[n] = lastElement;

            // Decrease size of heap by 1  
            Count--;

            // heapify the root node  
            heapify(Count, 0);

            // return new size of Heap  
            return n;
        }

        public IEnumerator GetEnumerator()
        {
            return Elements.GetEnumerator();
        }
    }
}
