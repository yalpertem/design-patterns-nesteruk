using DesignPatterns.Iterator.BinaryTreeInOrder;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.UnitTests.Iterator.BinaryTreeInOrder
{
    [TestFixture]
    public class BinaryTreeTests
    {
        [Test]
        public void NaturalInOrder_StringJoinIterations_ValidateString()
        {
            var root = new Node<int>(1,
                new Node<int>(2), new Node<int>(3));
            var bt = new BinaryTree<int>(root);

            var result = string.Join(",", bt.NaturalInOrder.Select(x => x.Value));
            Assert.That(result, Is.EqualTo("2,1,3"));
        }

        [Test]
        public void NaturalInOrder_DuckType_ValidateString()
        {
            var root = new Node<int>(1,
                new Node<int>(2), new Node<int>(3));
            var bt = new BinaryTree<int>(root);

            var expectedResult = new int[] { 2, 1, 3 };
            var i = 0;
            foreach (var node in bt)
            {
                Assert.That(node.Value, Is.EqualTo(expectedResult[i++]));
            }
        }
    }
}
