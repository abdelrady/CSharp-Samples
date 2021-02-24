using System;

namespace Algo
{
    public class EmptyStackException : Exception
    {
        public EmptyStackException(string message) : base(message)
        {
        }
    }
}