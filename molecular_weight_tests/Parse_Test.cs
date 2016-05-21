using System;
using NUnit.Framework;
using molecular_weight;
using System.Collections.Generic;

namespace molecular_weight_tests
{
    [TestFixture]
    public class Parse_Test
    {
        private string path = "c:/users/robert/documents/visual studio 2015/Projects/molecular_weight/molecular_weight/elements.csv";
        [Test]
        public void TestParserCanParseHydrogen()
        {
            Parser parser = new Parser(path);
            List<Element> periodicTable = parser.parse();

            Element hydrogen = periodicTable[0];

            Assert.AreEqual("Hydrogen", hydrogen.ElementName);
        }
    }
}
