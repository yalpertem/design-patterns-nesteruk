using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Specification
{
    public class Product
    {
        public string Name { get; set; }
        public ProductColor Color { get; set; }
        public ProductSize Size { get; set; }

        public Product(string name, ProductColor color, ProductSize size)
        {
            Name = name;
            Color = color;
            Size = size;
        }
    }

    public enum ProductColor
    {
        Green = 1,
        Blue = 2,
        Red = 3,
        Black = 4,
        White = 5
    }

    public enum ProductSize
    {
        XS = 1,
        S = 2,
        M = 3,
        L = 4,
        XL = 5
    }
}
