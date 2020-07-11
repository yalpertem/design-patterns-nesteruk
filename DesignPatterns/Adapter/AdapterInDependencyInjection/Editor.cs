using System.Collections.Generic;

namespace DesignPatterns.Adapter.AdapterInDependencyInjection
{
    public class Editor
    {
        public IEnumerable<Button> Buttons { get; }

        public Editor(IEnumerable<Button> buttons)
        {
            Buttons = buttons;
        }

        public void ClickAll()
        {
            foreach (var button in Buttons)
            {
                button.Click();
            }
        }
    }
}