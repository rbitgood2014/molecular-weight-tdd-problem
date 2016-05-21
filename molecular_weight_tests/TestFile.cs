using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace molecular_weight_tests
{
    [TestClass]
    public class TestFile
    {
        [TestMethod]
        public void TestElementFileExists()
        {
            Assert.IsTrue(File.Exists("c:/users/robert/documents/visual studio 2015/Projects/molecular_weight/molecular_weight/elements.csv"));
        }
    }
}
