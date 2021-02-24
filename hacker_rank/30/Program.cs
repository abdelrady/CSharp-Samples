using System;
using System.Collections.Generic;

namespace _30
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    public class MyQueue<T>
    {
        Stack<T> stackNewestOnTop = new Stack<T>();
        Stack<T> stackOldestOnTop = new Stack<T>();

        public void enqueue(T value)
        {
            // Push onto newest stack
            stackNewestOnTop.Push(value);
        }

        public T peek()
        {
            while (stackNewestOnTop.Count > 0)
            {
                stackOldestOnTop.Push(stackNewestOnTop.Pop());
            }

            var val = stackOldestOnTop.Peek();

            while (stackOldestOnTop.Count > 0)
            {
                stackNewestOnTop.Push(stackOldestOnTop.Pop());
            }

            return val;
        }

        public T dequeue()
        {
            while (stackNewestOnTop.Count > 0)
            {
                stackOldestOnTop.Push(stackNewestOnTop.Pop());
            }

            return stackOldestOnTop.Pop();
        }
    }
}
