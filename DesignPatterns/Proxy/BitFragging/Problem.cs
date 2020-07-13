using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Proxy.BitFragging
{
    public class Problem
    {
        private readonly List<int> _numbers;
        private readonly List<Op> _ops;

        public Problem(IEnumerable<int> numbers, IEnumerable<Op> ops)
        {
            _numbers = new List<int>(numbers);
            _ops = new List<Op>(ops);
        }

        public int Eval()
        {
            var opGroups = new[]
            {
                new[] {Op.Mul, Op.Div},
                new[] {Op.Add, Op.Sub}
            };

            //deep breath, go to
            startAgain:
            foreach (var group in opGroups)
            {
                for (var i = 0; i < _ops.Count; i++)
                {
                    if (group.Contains(_ops[i]))
                    {
                        var op = _ops[i];
                        var result = op.Call(_numbers[i], _numbers[i + 1]);
                        if (result != (int)result)
                        {
                            return int.MinValue;
                        }
                        _numbers[i] = (int)result;
                        _numbers.RemoveAt(i + 1);
                        _ops.RemoveAt(i);
                        if (_numbers.Count == 1)
                        {
                            return _numbers[0];
                        }
                        goto startAgain;
                    }
                }
            }
            return _numbers[0];
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            int i = 0;

            for (; i < _ops.Count; ++i)
            {
                sb.Append(_numbers[i]);
                sb.Append(_ops[i].Name());
            }

            sb.Append(_numbers[i]);
            return sb.ToString();
        }
    }
}
