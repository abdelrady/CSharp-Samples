using NUnit.Framework;

namespace Algo.Tests
{
    public class LinkedListTests
    {
        [Test]
        public void Append_IsCorrect()
        {
            var ls = new LinkedList<int>();
            ls.Append(5);
            ls.Append(7);
            ls.Append(5);
            ls.Append(3);
            ls.Append(9);
            ls.Append(1);

            ls.Print();
            Assert.AreEqual("5 7 5 3 9 1 ", ls.ToString());
        }

        [Test]
        public void Find_Is_Working()
        {
            var ls = new LinkedList<int>();
            ls.Append(5);
            ls.Append(7);
            ls.Append(5);
            ls.Append(3);
            ls.Append(9);
            ls.Append(1);

            ls.Print();

            Assert.IsNull(ls.Find(11));
            Assert.AreEqual(9, ls.Find(9).Value);
        }

        [Test]
        public void Delete_Is_Working()
        {
            var ls = new LinkedList<int>();
            ls.Append(5);
            ls.Append(7);
            ls.Append(5);
            ls.Append(3);
            ls.Append(9);
            ls.Append(1);

            ls.Print();

            ls.Delete(18);
            Assert.AreEqual("5 7 5 3 9 1 ", ls.ToString());
            ls.Delete(5);
            Assert.AreEqual("7 5 3 9 1 ", ls.ToString());
            ls.Delete(1);
            Assert.AreEqual("7 5 3 9 ", ls.ToString());
        }

        [Test]
        public void DeleteDuplicate_Is_Working()
        {
            var ls = new LinkedList<int>();
            ls.Append(5);
            ls.Append(7);
            ls.Append(5);
            ls.Append(3);
            ls.Append(9);
            ls.Append(1);

            ls.Delete(18);
            ls.Delete(5);
            ls.Delete(1);

            ls.Append(5);
            ls.Append(3);

            ls.DeleteDuplicates();
            Assert.AreEqual("7 5 3 9 ", ls.ToString());
        }

        [Test]
        public void KTHFromLast_Is_Working()
        {
            var ls = new LinkedList<int>();
            ls.Append(5);
            ls.Append(7);
            ls.Append(5);
            ls.Append(3);
            ls.Append(9);
            ls.Append(1);
            ls.Print();
            ls.Delete(18);
            ls.Delete(5);
            ls.Delete(1);

            ls.Append(5);
            ls.Append(3);
            ls.DeleteDuplicates();

            ls.Append(19);
            ls.Append(21);
            Assert.AreEqual(9, ls.KTHFromLast(3).Value);
            Assert.AreEqual(9, ls.KTHFromLastSinglyList(3).Value);
            Assert.AreEqual(9, ls.KTHFromLastSinglyListNoBuffer(3).Value);
        }

        [Test]
        public void Reverse_Is_Working()
        {
            var ls = new LinkedList<int>();
            ls.Append(5);
            ls.Append(7);
            ls.Append(5);
            ls.Append(3);
            ls.Append(9);
            ls.Append(1);
            ls.Print();
            ls.Delete(18);
            ls.Delete(5);
            ls.Delete(1);
            ls.Append(5);
            ls.Append(3);
            ls.DeleteDuplicates();
            ls.Append(19);
            ls.Append(21);
            ls.Append(1);
            ls.Append(2);
            ls.Reverse();
            Assert.AreEqual("2 1 21 19 9 3 5 7 ", ls.ToString());
        }

        [Test]
        public void SumTwoLists_Is_Working()
        {
            var l1 = new LinkedList<int>(7, 1, 6);
            var l2 = new LinkedList<int>(5, 9, 2);
            Assert.AreEqual("2 1 9 ", LinkedList<int>.SumLists(l1, l2).ToString());
            Assert.AreEqual("2 1 9 ", LinkedList<int>.SumLists(l1.Reverse(), l2.Reverse(), false).ToString());
        }

        [Test]
        public void IsPalindrome_Is_Working()
        {
            Assert.False(new LinkedList<int>(7, 1, 6).IsPalindrome());
            Assert.True(new LinkedList<int>(6, 1, 1, 6).IsPalindrome());
            Assert.True(new LinkedList<int>(6, 1, 6).IsPalindrome());
        }

        [Test]
        public void Partition_Is_Working()
        {
            var ls = new LinkedList<int>();
            ls.Append(5);
            ls.Append(7);
            ls.Append(5);
            ls.Append(3);
            ls.Append(9);
            ls.Append(1);
            ls.Delete(18);
            ls.Delete(5);
            ls.Delete(1);
            ls.Append(5);
            ls.Append(3);
            ls.DeleteDuplicates();
            ls.Append(19);
            ls.Append(21);
            ls.Append(1);
            ls.Append(2);
            ls.Reverse();
            ls.Partition(5);
            Assert.AreEqual("3 1 2 5 21 19 9 7 ", ls.ToString());
        }
    }
}