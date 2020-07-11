namespace DesignPatterns.Factories.AbstractFactoryPattern
{
    public interface IHotDrinkFactory
    {
        IHotDrink Prepare(int amount);
    }
}