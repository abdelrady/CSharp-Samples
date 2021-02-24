namespace Helpers
{
    public class TreeNodeWithPayload<T>
    {
        public int val;
        public TreeNodeWithPayload<T> left;
        public TreeNodeWithPayload<T> right;
        public T payload;

        public TreeNodeWithPayload(int val = 0, TreeNodeWithPayload<T> left = null, TreeNodeWithPayload<T> right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }

        public override string ToString()
        {
            return $"Node | {this.val}";
        }
    }
}