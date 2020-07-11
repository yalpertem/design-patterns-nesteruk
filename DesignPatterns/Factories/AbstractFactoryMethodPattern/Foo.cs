using System.Threading.Tasks;

namespace DesignPatterns.Factories.AbstractFactoryMethodPattern
{
    public class Foo
    {
        public string Bar { get; set; }

        private Foo(string bar)
        {
            Bar = bar;
        }

        private async Task<Foo> InitAsync()
        {
            await Task.Delay(1);
            return this;
        }

        public static async Task<Foo> CreateAsync(string bar)
        {
            var foo = new Foo(bar);
            return await foo.InitAsync();
        }
    }
}