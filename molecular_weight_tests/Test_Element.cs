using System;
using molecular_weight;
using NUnit.Framework;

namespace molecular_weight_tests
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestHydrogenElement()
        {   
            Element hydrogen = new Element("Hydrogen",1,"H",1.01);
            Assert.AreEqual("Hydrogen",hydrogen.ElementName);
            Assert.AreEqual(1, hydrogen.AtomicNumber);
            Assert.AreEqual("H", hydrogen.Symbol);
            Assert.AreEqual(1.01, hydrogen.Weight);



        }
    }
}
