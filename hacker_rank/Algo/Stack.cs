using System.Text;

namespace Algo
{
    public class Stack<T>
    {
        private Node<T> _first;
        private long _size = 0;

        public void Push(T val)
        {
            var n = new Node<T>(val);
            if (_first == null)
                _first = n;
            else
            {
                n.Next = _first;
                _first = n;
            }
            _size++;
        }

        public T Pop()
        {
            if (_first == null)
                throw new EmptyStackException("Stack is empty.");
            var n = _first;
            _first = _first.Next;
            _size--;
            return n.Value;
        }

        public T Peek()
        {
            if (_first == null)
                return (default(T));
            return _first.Value;
        }

        public bool IsEmpty()
        {
            return _first == null;
        }

        public long Size()
        {
            return _size;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            var n = _first;
            while (n!=null)
            {
                sb.Append(n.Value + " ");
                n = n.Next;
            }

            return sb.ToString();
        }
    }
}