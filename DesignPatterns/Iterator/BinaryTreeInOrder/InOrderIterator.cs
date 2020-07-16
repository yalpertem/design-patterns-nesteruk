using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Iterator.BinaryTreeInOrder
{
    public class InOrderIterator<T>
    {
        private readonly Node<T> _root;
        private bool _yieldedStart;
        public Node<T> Current { get; set; }

        public InOrderIterator(Node<T> root)
        {
            _root = root;
            Current = root;
            while (Current.Left != null)
            {
                Current = Current.Left;
            }
        }

        public bool MoveNext()
        {
            if (!_yieldedStart)
            {
                _yieldedStart = true;
                return true;
            }

            if (Current.Right != null)
            {
                Current = Current.Right;
                while (Current.Left != null)
                {
                    Current = Current.Left;
                }
                return true;
            }
            else
            {
                var p = Current.Parent;
                while (p != null && Current == p.Right)
                {
                    Current = p;
                    p = p.Parent;
                }
                Current = p;
                return Current != null;
            }
        }

        public void Reset()
        {

        }
    }
}
