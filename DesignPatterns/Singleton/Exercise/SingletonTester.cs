using System;

namespace DesignPatterns.Singleton.Exercise
{
    public class SingletonTester
    {
        public static bool IsSingleton(Func<object> func)
        {
            var object1 = func.Invoke();
            var object2 = func.Invoke();
            return ReferenceEquals(object1, object2);
        }
    }
}