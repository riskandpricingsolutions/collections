using System;
using System.Collections.Generic;

namespace Implementations.BinaryTree
{
    public interface IBinaryTree<T> : IEnumerable<T> where T : IComparable<T>
    {
        int Count { get; }

        // Add the data using a recursive algorithm
        void AddRecursive(T data);

        // Add the data using an iterative algorithm
        void AddIterative(T data);

        IEnumerable<T> PreorderTraversal();

    }
}