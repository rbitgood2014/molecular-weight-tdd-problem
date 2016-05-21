using System;
using System.IO;
using NUnit.Framework;

namespace molecular_weight_tests
{
    [TestFixture]
    public class Test_Structure
    {
        [Test]
        public void TestElementFileExists()
        {
            Assert.IsTrue(File.Exists("c:/users/robert/documents/visual studio 2015/Projects/molecular_weight/molecular_weight/elements.csv"));
        }
    }
}
