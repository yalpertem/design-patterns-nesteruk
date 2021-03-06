﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace DesignPatterns.Interpreter.Exercise
{
    /*
     You are asked to write an expression processor for simple numeric expressions with the following constraints:

     - Expressions use integral values (e.g., '13'), single-letter variables defined in Variables, as well as + and - operators only
     - There is no need to support braces or any other operations
     - If a variable is not found in Variables (or if we encounter a variable with >1 letter, e.g. ab), the evaluator returns 0 (zero)
     - In case of any parsing failure, evaluator returns 0
    */
    public class ExpressionProcessor
    {
        public Dictionary<char, int> Variables = new Dictionary<char, int>();

        public enum NextOp
        {
            Nothing,
            Plus,
            Minus
        }

        public int Calculate(string expression)
        {
            int current = 0;
            var nextOp = NextOp.Nothing;

            var parts = Regex.Split(expression, @"(?<=[+-])");

            foreach (var part in parts)
            {
                var noOp = part.Split(new[] { "+", "-" }, StringSplitOptions.RemoveEmptyEntries);
                var first = noOp[0];
                int value;

                if (int.TryParse(first, out int z))
                    value = z;
                else if (first.Length == 1 && Variables.ContainsKey(first[0]))
                    value = Variables[first[0]];
                else return 0;

                switch (nextOp)
                {
                    case NextOp.Nothing:
                        current = value;
                        break;
                    case NextOp.Plus:
                        current += value;
                        break;
                    case NextOp.Minus:
                        current -= value;
                        break;
                }

                if (part.EndsWith("+")) nextOp = NextOp.Plus;
                else if (part.EndsWith("-")) nextOp = NextOp.Minus;
            }
            return current;
        }
    }
}
