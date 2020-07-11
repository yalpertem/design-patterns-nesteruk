namespace DesignPatterns.Singleton.Exercise
{
    public class SingletonTesterData
    {
        private static readonly object _singleton = new object();

        public static object GetSingletonObject()
        {
            return _singleton;
        }

        public static object GetNonSingletonObject()
        {
            return new object();
        }
    }
}