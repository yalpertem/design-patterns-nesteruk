namespace DesignPatterns.Factories.AbstractFactoryPatternOCP
{
    public interface IHotDrinkFactory
    {
        IHotDrink Prepare(int amount);
    }
}