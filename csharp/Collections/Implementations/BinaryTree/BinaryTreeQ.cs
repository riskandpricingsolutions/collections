using System;
using System.Collections;
using System.Collections.Generic;

namespace Implementations.BinaryTree
{
    public class BinaryTreeQ<T> : IBinaryTree<T> where T : IComparable<T>, IEnumerable<T>
    {
        public int Count { get; }
        public void AddRecursive(T data)
        {
            throw new NotImplementedException();
        }

        public void AddIterative(T data)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> PreorderTraversal()
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}