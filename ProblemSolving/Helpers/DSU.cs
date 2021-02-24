namespace Helpers
{
    public class DSU
    {
        private readonly int _count;
        public int _componentsCount;
        public int[] parents;
        public int[] sizes;

        public DSU(int count)
        {
            _count = count;
            _componentsCount = count;
            parents = new int[count];
            sizes = new int[count];
            for (int i = 0; i < count; i++)
            {
                parents[i] = i;
                sizes[i] = 1;
                //parents[i] = -1;
                //sizes[i] = 0;
            }
        }

        public bool Union(int i, int j)
        {
            var p1 = GetParent(i);
            var p2 = GetParent(j);

            if (p1 == p2) return false;
            if (sizes[p1] >= sizes[p2])
            {
                parents[p2] = p1;
                parents[j] = p1;
                sizes[p1] += sizes[p2];
                sizes[p2] = 0;
            }
            else
            {
                parents[p1] = p2;
                parents[i] = p2;
                sizes[p2] += sizes[p1];
                sizes[p1] = 0;
            }

            _componentsCount--;
            return true;
        }

        public int GetParent(in int p)
        {
            if (parents[p] != p) parents[p] = GetParent(parents[p]);
            return parents[p];
        }
    }
}