using System.Collections.Generic;

namespace RiskAndPricingSolutions.Algorithms.Collections.Implementations.SymbolTables
{
    public interface ISymbolTable<TKey, TValue>
    {
        TValue this[TKey key] { get; set; }

  
        /// <summary>
        /// Throws an exception if we try to add the same key twice
        /// </summary>
        void Add(TKey key, TValue value);

        void Remove(TKey key);

        bool ContainsKey(TKey key);

        /// <summary>
        ///     Return false if the key is already present
        /// </summary>
        /// <returns></returns>
        bool TryAdd(TKey key, TValue value);

        IEnumerable<TKey> Keys { get; }
    }
}