using DesignPatterns.Facade.Exercise;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.UnitTests.Facade.Exercise
{
    [TestFixture]
    public class MagicSquareGeneratorTests
    {
        [Test]
        public void Generate_ThreeByThreeMatrix_GeneratesVerifiedMatrix()
        {
            var generator = new MagicSquareGenerator();
            var square = generator.Generate(3);
            var myVerifier = new MyVerifier();
            Assert.IsTrue(myVerifier.Verify(square));
        }
    }
}
