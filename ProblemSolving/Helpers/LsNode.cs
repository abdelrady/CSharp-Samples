namespace Helpers
{
    public class LsNode 
    {
        public int val;
        public LsNode left;
        public LsNode right;
        public LsNode(int val = 0, LsNode left = null, LsNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }

        public override string ToString()
        {
            return $"LSNode | {this.val}";
        }
    }
}