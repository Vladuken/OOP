using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Xsl;
using Interfaces;

namespace XMLToTXTTransformer
{
    public class XMLToTXTTransformer : IPlugin
    {

        public String GetExtention()
        {
            return "txt";
        }
        public String PName()
        {
            return "XML to TXT transforming";
        }

        public void Transform(string filename)
        {
            string text = System.IO.File.ReadAllText(filename);
            string rules = System.IO.File.ReadAllText(@"TXTRules.txt");

            XslCompiledTransform transform = new XslCompiledTransform();
            using (XmlReader reader = XmlReader.Create(new StringReader(rules)))
            {
                transform.Load(reader);
            }
            StringWriter results = new StringWriter();
            using (XmlReader reader = XmlReader.Create(new StringReader(text)))
            {
                transform.Transform(reader, null, results);
            }

            File.WriteAllText(filename.Split('.')[0] + ".txt", results.ToString());


        }
    }
}
