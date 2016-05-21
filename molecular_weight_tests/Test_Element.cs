using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace molecular_weight_tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestHydrogenElement()
        {   
            Element hydrogen = new Element("Hydrogen",1,"H",1.01);
            Assert.Equals("Hydrogen",hydrogen.getElementName());
            
        }
    }
}
