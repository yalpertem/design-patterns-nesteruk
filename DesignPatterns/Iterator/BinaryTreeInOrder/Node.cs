using MoreLinq.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Iterator.BinaryTreeInOrder
{
    public class Node<T>
    {
        public T Value { get; set; }
        public Node<T> Left { get; set; }
        public Node<T> Right { get; set; }

        public Node<T> Parent { get; set; }

        public Node(T value)
        {
            Value = value;
        }

        public Node(T value, Node<T> left, Node<T> right)
        {
            Value = value;
            Left = left;
            Right = right;
            Left.Parent = Right.Parent = this;
        }
    }
}
