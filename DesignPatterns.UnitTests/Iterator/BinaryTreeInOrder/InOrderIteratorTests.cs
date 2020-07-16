using DesignPatterns.Iterator.BinaryTreeInOrder;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.UnitTests.Iterator.BinaryTreeInOrder
{
    [TestFixture]
    public class InOrderIteratorTests
    {
        [Test]
        public void MoveNext_MoveOnce_GetCorrectValue()
        {
            var root = new Node<int>(1,
                new Node<int>(2), new Node<int>(3));

            // C++ style
            var it = new InOrderIterator<int>(root);
            it.MoveNext();

            Assert.That(it.Current.Value, Is.EqualTo(2));
        }

        [Test]
        public void MoveNext_MoveTwice_GetCorrectValue()
        {
            var root = new Node<int>(1,
                new Node<int>(2), new Node<int>(3));

            // C++ style
            var it = new InOrderIterator<int>(root);
            it.MoveNext();
            it.MoveNext();

            Assert.That(it.Current.Value, Is.EqualTo(1));
        }

        [Test]
        public void MoveNext_MoveThreeTimes_GetCorrectValue()
        {
            var root = new Node<int>(1,
                new Node<int>(2), new Node<int>(3));

            // C++ style
            var it = new InOrderIterator<int>(root);
            it.MoveNext();
            it.MoveNext();
            it.MoveNext();

            Assert.That(it.Current.Value, Is.EqualTo(3));
        }
    }
}
