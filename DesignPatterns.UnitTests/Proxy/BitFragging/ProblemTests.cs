using DesignPatterns.Proxy.BitFragging;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.UnitTests.Proxy.BitFragging
{
    [TestFixture]
    public class ProblemTests
    {
        [Test]
        public void Eval_GiveSomeNumbers_FindSolutionWhenExists()
        {
            var numbers = new[] { 1, 4, 5, 7 };
            var operators = new Op[] { Op.Add, Op.Sub, Op.Mul };
            var problem = new Problem(numbers, operators);
            var result = problem.Eval();
            Assert.That(result, Is.EqualTo(-30));
        }

        public void Eval_FindAllPossibleSolutionsForASet()
        {
            var numbers = new[] { 1, 3, 5, 7 };
            int numberOfOps = numbers.Length - 1;
            for (var result = 0; result <= 10; result++)
            {
                for (var key = 0UL; key < 1UL << 2 * numberOfOps; key++)
                {
                    var tbs = new TwoBitSet(key);
                    var ops = Enumerable.Range(0, numberOfOps)
                        .Select(x => tbs[x]).Cast<Op>().ToArray();
                    var problem = new Problem(numbers, ops);
                    if (problem.Eval() == result)
                    {

                    }
                }
            }
        }
    }
}
