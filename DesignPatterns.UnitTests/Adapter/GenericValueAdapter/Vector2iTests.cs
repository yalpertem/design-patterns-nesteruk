using DesignPatterns.Adapter.GenericValueAdapter;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.UnitTests.Adapter.GenericValueAdapter
{
    [TestFixture]
    public class Vector2iTests
    {
        [Test]
        public void AddOperator_AddTwoVectors_ValidateFirstParam()
        {
            Vector2i u = new Vector2i(new int[] { 2, 4 });
            Vector2i uu = new Vector2i(new int[] { 1, 5 });
            var result = u + uu;

            Assert.That(result[0], Is.EqualTo(3));
        }

        [Test]
        public void AddOperator_AddTwoVectors_ValidateSecondParam()
        {
            Vector2i u = new Vector2i(new int[] { 2, 4 });
            Vector2i uu = new Vector2i(new int[] { 1, 5 });
            var result = u + uu;

            Assert.That(result[1], Is.EqualTo(9));
        }
    }
}
