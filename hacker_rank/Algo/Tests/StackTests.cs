using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace Algo.Tests
{
    public class StackTests
    {
        [Test]
        public void Push_Is_Working()
        {
            var s = new Stack<int>();

            s.Push(1);
            s.Push(2);
            s.Push(3);

            Assert.AreEqual("3 2 1 ", s.ToString());
        }

        [Test]
        public void Pop_Is_Working()
        {
            var s = new Stack<int>();

            s.Push(1);
            s.Push(2);
            s.Push(3);
            s.Pop();
            Assert.AreEqual("2 1 ", s.ToString());

            s.Pop();
            s.Pop();
            Assert.AreEqual("", s.ToString());

            void PopException()
            {
                s.Pop();
            }
            Assert.Throws(typeof(EmptyStackException), PopException);
        }

        [Test]
        public void Peek_Is_Working()
        {
            var s = new Stack<int>();

            s.Push(1);
            s.Push(2);
            s.Push(3);
            s.Peek();
            Assert.AreEqual("3 2 1 ", s.ToString());

            s.Peek();
            s.Peek();
            Assert.AreEqual("3 2 1 ", s.ToString());
        }

        [Test]
        public void Size_Is_Working()
        {
            var s = new Stack<int>();

            s.Push(1);
            s.Push(2);
            s.Push(3);
            s.Peek();
            Assert.AreEqual(3, s.Size());

            s.Pop();
            s.Peek();
            Assert.AreEqual(2, s.Size());
            s.Pop();
            s.Pop();
            Assert.AreEqual(0, s.Size());
        }

        [Test]
        public void IsEmpty_Is_Working()
        {
            var s = new Stack<int>();

            s.Push(1);
            s.Push(2);
            s.Push(3);
            s.Pop();
            Assert.False(s.IsEmpty());
            s.Pop();
            s.Pop();
            Assert.True(s.IsEmpty());
        }
    }
}
