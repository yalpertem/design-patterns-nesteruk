using DesignPatterns.Adapter.GenericValueAdapter;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.UnitTests.Adapter.GenericValueAdapter
{
    [TestFixture]
    public class Vector3fTests
    {
        [Test]
        public void AddOperator_AddTwoVectors_ValidateFirstParam()
        {
            Vector3f u = Vector3f.Create(3.5f, 1.2f, 4);
            Vector3f uu = Vector3f.Create(1.5f, 1.5f, 4.2f);
            var result = u + uu;

            Assert.That(result[0], Is.EqualTo(5f));
        }

        [Test]
        public void AddOperator_AddTwoVectors_ValidateSecondParam()
        {
            Vector3f u = Vector3f.Create(3.5f, 1.2f, 4);
            Vector3f uu = Vector3f.Create(1.5f, 1.5f, 4.2f);
            var result = u + uu;

            Assert.That(result[1], Is.EqualTo(2.7f));
        }

        [Test]
        public void AddOperator_AddTwoVectors_ValidateThirdParam()
        {
            Vector3f u = Vector3f.Create(3.5f, 1.2f, 4);
            Vector3f uu = Vector3f.Create(1.5f, 1.5f, 4.2f);
            var result = u + uu;

            Assert.That(result[2], Is.EqualTo(8.2f));
        }
    }
}
