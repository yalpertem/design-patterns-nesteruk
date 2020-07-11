namespace DesignPatterns.Specification.Base
{
    /// <summary>
    /// An example for "O" of "SOLID
    /// Open for extension, but closed for modification
    /// Instead of adding FilterByColor, FilterBySize etc. methods,
    /// we can create new classes and extend to IFilter
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface ISpecification<T>
    {
        bool IsSatisfied(T t);
    }
}