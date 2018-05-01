using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Interfaces;
using Newtonsoft.Json;

namespace XMLToJSONTransformer
{
    public class XMLToJSONTransformer : IPlugin
    {


        public String GetExtention()
        {
            return "json";
        }
        public String PName()
        {
            return "XML to JSON transforming";
        }

        public void Transform(string filename)
        {

            string text = System.IO.File.ReadAllText(filename);
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(text);
            string jsonText = JsonConvert.SerializeXmlNode(doc);

            File.WriteAllText(filename.Split('.')[0] + ".json", jsonText);
        }
    }
}
