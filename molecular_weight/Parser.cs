using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace molecular_weight
{
   public class Parser
    {
        public string path { get; private set; }

        public Parser(string path)
        {
            this.path = path;
        }

        public List<Element> parse()
        {
            var periodicTable = new List<Element>();
            var fileStream = new FileStream(path, FileMode.Open);
            var streamReader = new StreamReader(fileStream, Encoding.UTF8);
            string line;
            //skip header of csv file
            streamReader.ReadLine();
            while ((line = streamReader.ReadLine()) != null)
            {
                string[] splitLineIntoComponents = line.Split(',');
                periodicTable.Add(new Element(splitLineIntoComponents[0], Int32.Parse(splitLineIntoComponents[1]), 
                    splitLineIntoComponents[2], Double.Parse(splitLineIntoComponents[3])));
            }
            return periodicTable;
        }

        
    }
}
