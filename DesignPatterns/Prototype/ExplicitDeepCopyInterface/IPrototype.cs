namespace DesignPatterns.Prototype.ExplicitDeepCopyInterface
{
    public interface IPrototype<T>
    {
        T DeepCopy();
    }
}