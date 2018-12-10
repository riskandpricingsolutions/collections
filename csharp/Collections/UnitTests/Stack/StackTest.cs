using System;
using NUnit.Framework;
using RiskAndPricingSolutions.Algorithms.Collections.Implementations.Stack;

namespace RiskAndPricingSolutions.Algorithms.UnitTests.Stack
{
    [TestFixture]
    public class StackCalculatorTest
    {
        private readonly IStack<int> _stack = new StackImpl<int>(2);

        [Test]
        public void Test()
        {
            Assert.Throws(typeof(InvalidOperationException), () => { _stack.Pop(); });

            _stack.Push(2);
            _stack.Push(4);
            _stack.Push(6);

            Assert.AreEqual(3, _stack.Count);
            Assert.AreEqual(6, _stack.Pop());
            Assert.AreEqual(4, _stack.Pop());
            Assert.AreEqual(2, _stack.Pop());
        }
    }
}