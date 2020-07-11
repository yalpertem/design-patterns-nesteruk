using DesignPatterns.Composite.NeuralNetworks;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.UnitTests.Composite.NeuralNetworks
{
    [TestFixture]
    public class NeuronTests
    {
        [Test]
        public void ConnectTo_ConnectLayerToNeuron_ValidateOut()
        {
            var neuron = new Neuron();
            var layer = new NeuronLayer();
            var neuronInLayer = new Neuron();
            layer.Add(neuronInLayer);
            layer.ConnectTo(neuron);
            
            Assert.That(layer[0].Out[0], Is.InstanceOf<Neuron>());
        }

        [Test]
        public void ConnectTo_ConnectLayerToNeuron_ValidateIn()
        {
            var neuron = new Neuron();
            var layer = new NeuronLayer();
            var neuronInLayer = new Neuron();
            layer.Add(neuronInLayer);
            layer.ConnectTo(neuron);

            Assert.That(neuron.In[0], Is.InstanceOf<Neuron>());
        }
    }
}
