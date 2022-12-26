using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace homew1
{
    public class Item
    {
        public string Title { get; set; }
        public string Link { get; set; }    
        public string Description { get; set; }
        public string PubDate { get; set; }

        public void saveData(object obj, string filename)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(obj.GetType());
            TextWriter writer = new StreamWriter(filename);
            xmlSerializer.Serialize(writer, obj);
            writer.Close();
        }
      
    }
  
}
