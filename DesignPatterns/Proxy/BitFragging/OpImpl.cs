using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Text;

namespace DesignPatterns.Proxy.BitFragging
{
    public static class OpImpl
    {
        static OpImpl()
        {
            var type = typeof(Op);
            foreach (Op op in Enum.GetValues(type))
            {
                MemberInfo[] memInfo = type.GetMember(op.ToString());
                if (memInfo.Length > 0)
                {
                    var attrs = memInfo[0].GetCustomAttributes(
                      typeof(DescriptionAttribute), false);

                    if (attrs.Length > 0)
                    {
                        _opNames[op] = ((DescriptionAttribute)attrs[0]).Description[0];
                    }
                }
            }
        }

        private static readonly Dictionary<Op, char> _opNames
          = new Dictionary<Op, char>();

        // notice the data types!
        private static readonly Dictionary<Op, Func<double, double, double>> _opImpl =
          new Dictionary<Op, Func<double, double, double>>()
          {
              [Op.Mul] = ((x, y) => x * y),
              [Op.Div] = ((x, y) => x / y),
              [Op.Add] = ((x, y) => x + y),
              [Op.Sub] = ((x, y) => x - y),
          };

        public static double Call(this Op op, int x, int y)
        {
            return _opImpl[op](x, y);
        }

        public static char Name(this Op op)
        {
            return _opNames[op];
        }
    }
}
