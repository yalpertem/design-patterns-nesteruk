using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Iterator.BinaryTreeInOrder
{
    public class BinaryTree<T>
    {
        private readonly Node<T> _root;

        public BinaryTree(Node<T> root)
        {
            _root = root;
        }

        public InOrderIterator<T> GetEnumerator()
        {
            return new InOrderIterator<T>(_root);
        }

        public IEnumerable<Node<T>> NaturalInOrder
        {
            get
            {
                static IEnumerable<Node<T>> TraverseInOrder(Node<T> current)
                {
                    if (current.Left != null)
                    {
                        foreach (var left in TraverseInOrder(current.Left))
                            yield return left;
                    }
                    yield return current;
                    if (current.Right != null)
                    {
                        foreach (var right in TraverseInOrder(current.Right))
                            yield return right;
                    }
                }
                foreach (var node in TraverseInOrder(_root))
                    yield return node;
            }
        }

    }
}
