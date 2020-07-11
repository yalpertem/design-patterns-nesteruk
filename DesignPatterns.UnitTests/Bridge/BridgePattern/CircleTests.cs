using Autofac;
using DesignPatterns.Bridge.BridgePattern;
using Microsoft.VisualBasic;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.UnitTests.Bridge.BridgePattern
{
    [TestFixture]
    public class CircleTests
    {
        [Test]
        public void Draw_PassARasterRenderer_DrawsWithTheSpecifiedRenderer()
        {
            var renderer = new RasterRenderer();
            var circle = new Circle(renderer, 5);
            var drawn = circle.Draw();
            Assert.That(drawn, Is.EqualTo("raster"));
        }

        [Test]
        public void Draw_PassAVectorRenderer_DrawsWithTheSpecifiedRenderer()
        {
            var renderer = new VectorRenderer();
            var circle = new Circle(renderer, 5);
            var drawn = circle.Draw();
            Assert.That(drawn, Is.EqualTo("vector"));
        }

        [Test]
        public void Draw_PassAVectorRenderer_DrawsWithTheSpecifiedRendererWithDI()
        {
            var cb = new ContainerBuilder();
            cb.RegisterType<RasterRenderer>().As<IRenderer>()
                .SingleInstance();
            cb.Register((c, p) =>
                new Circle(c.Resolve<IRenderer>(),
                p.Positional<float>(0)));
            
            using(var c = cb.Build())
            {
                var circle = c.Resolve<Circle>(
                    new PositionalParameter(0, 5.0f));
                var drawn = circle.Draw();
                Assert.That(drawn, Is.EqualTo("raster"));
            }
        }
    }
}
