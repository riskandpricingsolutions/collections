using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace RiskAndPricingSolutions.Algorithms.Collections.Implementations.SymbolTables.LinkedListSymbolTable
{
    public class LinkedListSymbolTableImpl<TKey, TValue> : ISymbolTable<TKey, TValue>
    {
        private class Node
        {
            public Node(TKey key, TValue value, Node next = null)
            {
                Key = key;
                Value = value;
                Next = next;
            }

            public readonly TKey Key;
            public TValue Value;
            public readonly Node Next;
        }

        public TValue this[TKey key]
        {
            get
            {
                for (var n = _root; n != null; n = n.Next)
                {
                    Indexgetcomparisons++;
                    if (n.Key.Equals(key))
                        return n.Value;
                }
                // In line with Csharp implementation search miss is exception
                throw new InvalidOperationException("Key not present");
            }
            set
            {
                for (var n = _root; n != null; n = n.Next)
                {
                    Indexsetcomparisons++;
                    if (n.Key.Equals(key))
                        n.Value = value;
                }
                _root = new Node(key, value, _root);
            }
        }

        public void Add(TKey key, TValue value)
        {
            throw new NotImplementedException();
        }

        public void Remove(TKey key)
        {
            throw new NotImplementedException();
        }

        public bool ContainsKey(TKey key)
        {
            throw new NotImplementedException();
        }

        public bool TryAdd(TKey key, TValue value)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TKey> Keys { get; }
        private Node _root;
        private int _count = 0;

        // Instrumentation for education
        public int Indexsetcomparisons;

        public int Indexgetcomparisons;

        public LinkedListSymbolTableImpl(int count)
        {
            _count = count;
        }
    }


    [TestFixture]
    public class LinkedListSymbolTableCalculatorTest
    {
        [Test]
        public void Test()
        {
        }
    }
}