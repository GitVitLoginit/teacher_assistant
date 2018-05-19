using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PluginInterfaces;
using System.Xml.Serialization;
using System.IO;
using MilitaryUnits;
using System.Xml.Linq;


namespace InterfacesDescriptions
{
   
    public class SerDecMethods : ISerDecMethods
    {
        public void Ser(List<Detachment> list)
        {
            var serial = new System.Xml.Serialization.XmlSerializer(list.GetType());

            using (var stream = new FileStream("xml.txt", FileMode.Create))
            {
                serial.Serialize(stream, list);
                stream.Flush();
            }
        }
        public List<Detachment> Dec()
        {
            List<Detachment> resultList = new List<Detachment>();
            var serial = new System.Xml.Serialization.XmlSerializer(resultList.GetType());

            using (var stream = new FileStream("xml.txt", FileMode.Open))
            {
                resultList = (List<Detachment>)serial.Deserialize(stream);
                stream.Flush();
            }
            return resultList;

        }
    }

    public class hangeAttriburesMethods :IChangeAttriburesMethods
    {
       public void SerAttribute(List<Detachment> list)
        {
            var serial = new System.Xml.Serialization.XmlSerializer(list.GetType());

            using (var stream = new FileStream("xml2.txt", FileMode.Create))
            {
                serial.Serialize(stream, list);
                stream.Flush();
            }
            XDocument xmlFile = XDocument.Load("xml2.txt");

            foreach (XElement elem in xmlFile.Descendants().Where(m=>!m.Elements().Any()))
            {
                elem.SetAttributeValue("newValue",elem.Value);
                elem.Nodes().Remove();


            }
            xmlFile.Save("xml2.txt");



            //Here is the variable with which you assign a new value to the attribute
      

        }
        public List<Detachment> DecAttribute()
        {
            List<Detachment> resultList = new List<Detachment>();
            var serial = new System.Xml.Serialization.XmlSerializer(resultList.GetType());
            XDocument xmlFile = XDocument.Load("xml2.txt");
            xmlFile.Descendants().Attributes("newValue");

            foreach (XElement elem in xmlFile.Descendants().Where(m => !m.Elements().Any()))
            {
                elem.Value = elem.Attribute("newValue").Value;
            }
            xmlFile.Descendants().Attributes("newValue").Remove();
            xmlFile.Save("xml2.txt");

            using (var stream = new FileStream("xml2.txt", FileMode.Open))
            {
                resultList = (List<Detachment>)serial.Deserialize(stream);
                stream.Flush();
            }
            return resultList;

        }


    }
    
    

    
}
