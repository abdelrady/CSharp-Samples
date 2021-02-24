using System;
using System.Collections.Generic;
using System.Linq;

namespace FindPathBiBFS
{
    class Program
    {
        static void Main(string[] args)
        {
            var personsList = new List<Person>
            {
                new Person(1, "Rady", 2,6),
                new Person(2, "Bob", 3,7),
                new Person(3, "susan", 4,8),
                new Person(4, "Jason", 5,8),
                new Person(5, "Moaz", 7),
                new Person(6, "Eman", 8),
                new Person(7, "Aml", 8),
                new Person(8, "Wael", 2),
            };
            var peopleDic = personsList.ToDictionary(kv => kv.Id, kv => kv);
            var path = FindPathBiBfs(peopleDic, 1, 5);

            if (path != null)
            {
                while (path.First != null)
                {
                    Console.Write(path.First.Value + "->");
                    path.RemoveFirst();
                }
            }

            Console.WriteLine();
        }

        static LinkedList<Person> FindPathBiBfs(Dictionary<int, Person> people, int source, int dest)
        {
            var sourceData = new BFSData(people[source]);
            var destData = new BFSData(people[dest]);
            while (!sourceData.IsFinished() && !destData.IsFinished())
            {
                var collision = SearchLevel(people, sourceData, destData);
                if (collision != null)
                {
                    return MergePaths(sourceData, destData, collision.Id);
                }

                collision = SearchLevel(people, destData, sourceData);
                if (collision != null)
                {
                    return MergePaths(sourceData, destData, collision.Id);
                }
            }

            return null;
        }

        private static LinkedList<Person> MergePaths(BFSData sourceData, BFSData destData, int collisionId)
        {
            var end1 = sourceData.Visited[collisionId];
            var end2 = destData.Visited[collisionId];

            var path1 = end1.Collapse(false);
            var path2 = end2.Collapse(true);

            path2.RemoveFirst();
            while (path2.Count != 0)
            {
                path1.AddLast(path2.First.Value);
                path2.RemoveFirst();
            }

            return path1;
        }

        private static Person SearchLevel(Dictionary<int, Person> people, BFSData primary, BFSData secondary)
        {
            var count = primary.ToVisit.Count;
            for (int i = 0; i < count; i++)
            {
                var pathNode = primary.ToVisit.Dequeue();
                var personId = pathNode.Person.Id;

                if (secondary.Visited.ContainsKey(personId))
                    return pathNode.Person;

                var friends = pathNode.Person.GetFriends();
                foreach (var friendId in friends)
                {
                    if (!primary.Visited.ContainsKey(friendId))
                    {
                        var friend = people[friendId];
                        var next = new PathNode(friend, pathNode);
                        primary.Visited.Add(friendId, next);
                        primary.ToVisit.Enqueue(next);
                    }
                }

            }

            return null;
        }
    }

    internal class Person
    {
        public Person(int id, string name, params int[] friends)
        {
            this.Id = id;
            this.Name = name;
            this._friends = friends.ToList();
        }

        public string Name { get; set; }

        private List<int> _friends = new List<int>();
        public int Id { get; set; }

        public List<int> GetFriends()
        {
            return this._friends;
        }

        public override string ToString()
        {
            return this.Id + "|" + this.Name;
        }
    }

    class BFSData
    {
        public Queue<PathNode> ToVisit = new Queue<PathNode>();
        public Dictionary<int, PathNode> Visited = new Dictionary<int, PathNode>();

        public BFSData(Person root)
        {
            var source = new PathNode(root, null);
            ToVisit.Enqueue(source);
            Visited.Add(root.Id, source);
        }

        public bool IsFinished()
        {
            return ToVisit.Count == 0;
        }
    }

    internal class PathNode
    {
        public Person Person = null;
        public PathNode PrevNode = null;

        public PathNode(Person p, PathNode prev)
        {
            this.Person = p;
            this.PrevNode = prev;
        }

        public LinkedList<Person> Collapse(bool startWithRoot)
        {
            var path = new LinkedList<Person>();
            PathNode node = this;
            while (node != null)
            {
                if (startWithRoot)
                {
                    path.AddLast(node.Person);
                }
                else
                {
                    path.AddFirst(node.Person);
                }
                node = node.PrevNode;
            }
            return path;
        }
    }
}
