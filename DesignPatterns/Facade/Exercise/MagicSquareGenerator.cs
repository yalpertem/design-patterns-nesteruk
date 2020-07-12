using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Facade.Exercise
{
    public class MagicSquareGenerator
    {
        public List<List<int>> Generate(int size)
        {
            var generator = new Generator();
            var splitter = new Splitter();
            var verifier = new Verifier();
            while (true)
            {
                var matrix = new List<List<int>>();
                for (var i = 0; i < size; i++)
                {
                    matrix.Add(generator.Generate(size));
                }

                var splittedMatrix = splitter.Split(matrix);

                if (verifier.Verify(splittedMatrix))
                {
                    return matrix;
                }
            }
        }
    }
}
