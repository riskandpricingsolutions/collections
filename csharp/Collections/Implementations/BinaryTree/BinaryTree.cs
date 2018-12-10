using System;
using System.Collections;
using System.Collections.Generic;
using Implementations.BinaryTree;

namespace RiskAndPricingSolutions.Algorithms.Collections.Implementations.BinaryTree
{
    public class BinaryTreeImpl<T> : IBinaryTree<T> where T : IComparable<T>
    {
        public void AddIterative(T data)
        {
            TreeNode<T> newNode = new TreeNode<T>() {Data = data};
            TreeNode<T> current = _root;

            // Special case
            if (_root == null)
                _root = newNode;

            while (current != null)
            {
                if (data.CompareTo(current.Data) > 0)
                {
                    if (current.Right == null)
                    {
                        current.Right = newNode;
                        Count++;
                        return;
                    }
                    current = current.Right;
                }
                else
                {
                    if (current.Left == null)
                    {
                        current.Left = new TreeNode<T>() { Data = data };
                        Count++;
                        return;
                    }
                    current = current.Left;
                }
            }
        }

        public IEnumerable<T> PreorderTraversal()
        {
            throw new NotImplementedException();
        }

        private TreeNode<T> _root;

        public int Count { get; private set; }


        public void AddRecursive(T data)
        {
            if (_root == null)
            {
                _root = new TreeNode<T>() {Data = data};
                return;
            }

            AddRecursive(_root,data);
        }


        private void AddRecursive(TreeNode<T> root, T data)
        { 
        if (data.CompareTo(root.Data) > 0)
            {
                if (root.Right == null)
                {
                    root.Right = new TreeNode<T> { Data = data };
                    Count++;
                    return;
                }
                AddRecursive(root.Right, data);
            }
            else
            {
                if (root.Left == null)
                {
                    root.Left = new TreeNode<T> { Data = data };
                    Count++;
                    return;
                }
                AddRecursive(root.Left, data);
            }

        }

        public IEnumerator<T> GetEnumerator()
        {
            var list = new List<T>();
            if (_root != null)
                DepthFirstSearch(_root, list);
            return list.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private void DepthFirstSearch(TreeNode<T> root, IList<T> values)
        {
            values.Add(root.Data);

            if (root.Left != null)
                DepthFirstSearch(root.Left, values);
            if (root.Right != null)
                DepthFirstSearch(root.Right, values);
        }

        private class TreeNode<T>
        {
            public T Data { get; set; }
            public TreeNode<T> Left { get; set; }
            public TreeNode<T> Right { get; set; }
        }
    }
}