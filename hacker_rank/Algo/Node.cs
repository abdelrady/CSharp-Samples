namespace Algo
{
    public class Node<T>
    {
        public Node(T val)
        {
            this.Value = val;
        }

        public T Value { get; set; }
        public Node<T> Next { get; set; }
        public Node<T> Prev { get; set; }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}