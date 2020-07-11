using Autofac;
using Autofac.Features.Metadata;
using DesignPatterns.Adapter.AdapterInDependencyInjection;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.UnitTests.Adapter.AdapterInDependencyInjection
{
    [TestFixture]
    public class ButtonTests
    {
        [Test]
        public void PrintMe_SetTheNameForButtons_TwoButtonsAreCreated()
        {
            var b = new ContainerBuilder();
            b.RegisterType<SaveCommand>().As<ICommand>()
                .WithMetadata("Name", "Save");
            b.RegisterType<OpenCommand>().As<ICommand>()
                .WithMetadata("Name", "Open");
            b.RegisterAdapter<Meta<ICommand>, Button>(cmd =>
                new Button(cmd.Value, (string)cmd.Metadata["Name"]));

            b.RegisterType<Editor>();

            using (var c = b.Build())
            {
                var editor = c.Resolve<Editor>();
                Assert.That(editor.Buttons.Count(), Is.EqualTo(2));
            }
        }

        [Test]
        public void PrintMe_SetTheNameForButtons_TwoNamesAreSet()
        {
            var b = new ContainerBuilder();
            b.RegisterType<SaveCommand>().As<ICommand>()
                .WithMetadata("Name", "Save");
            b.RegisterType<OpenCommand>().As<ICommand>()
                .WithMetadata("Name", "Open");
            b.RegisterAdapter<Meta<ICommand>, Button>(cmd =>
                new Button(cmd.Value, (string)cmd.Metadata["Name"]));

            b.RegisterType<Editor>();

            var expectedNames = new string[] { "Save", "Open" };

            using (var c = b.Build())
            {
                var editor = c.Resolve<Editor>();
                foreach(var button in editor.Buttons)
                {
                    var buttonName = button.PrintMe();
                    Assert.That(buttonName, Is.AnyOf(expectedNames));
                }
            }
        }
    }
}
