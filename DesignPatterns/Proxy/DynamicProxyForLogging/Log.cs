using ImpromptuInterface;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace DesignPatterns.Proxy.DynamicProxyForLogging
{
    public class Log<T> : DynamicObject
        where T : class, new()
    {
        private readonly T _subject;
        private Dictionary<string, int> _methodCallCount
            = new Dictionary<string, int>();

        public Log(T subject)
        {
            _subject = subject;
        }

        public static I As<I>() where I : class
        {
            if (!typeof(I).IsInterface)
            {
                throw new ArgumentException("I must be interface.");
            }
            return new Log<T>(new T()).ActLike<I>();
        }

        public override bool TryInvokeMember(InvokeMemberBinder binder, object[] args, out object result)
        {
            try
            {
                // logging
                Console.WriteLine($"Invoking {_subject.GetType().Name}.{binder.Name} with arguments [{string.Join(",", args)}]");

                // more logging
                if (_methodCallCount.ContainsKey(binder.Name))
                {
                    _methodCallCount[binder.Name]++;
                }
                else
                {
                    _methodCallCount.Add(binder.Name, 1);
                }

                result = _subject.GetType().GetMethod(binder.Name).Invoke(_subject, args);
                return true;
            }
            catch
            {
                result = null;
                return false;
            }
        }

        public string Info
        {
            get
            {
                var sb = new StringBuilder();
                foreach (var kv in _methodCallCount)
                {
                    sb.AppendLine($"{kv.Key} called {kv.Value} times.");
                }
                return sb.ToString();
            }
        }

        public override string ToString()
        {
            return $"{Info}\r\n{_subject}";
        }
    }
}
