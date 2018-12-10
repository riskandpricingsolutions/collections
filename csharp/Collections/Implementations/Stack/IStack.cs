namespace RiskAndPricingSolutions.Algorithms.Collections.Implementations.Stack
{
    public interface IStack<T>
    {
        void Push(T item);
        T Pop();

        long Count { get; }
    }
}