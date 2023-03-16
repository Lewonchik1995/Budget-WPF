using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Budget_WPF
{
    class DeSerialize
    {
        public static void Serialize<T>(T obj)
        {
            XmlSerializer xml = new XmlSerializer(typeof(T));
            using (var fs = new FileStream(path: @"..\..\..\db.xml", FileMode.Create))
            {
                xml.Serialize(fs, obj);
            }
        }
        public static T Deserialize<T>()
        {
            T obj;
            XmlSerializer xml = new XmlSerializer(typeof(T));
            using (var fs = new FileStream(path: @"..\..\..\db.xml", FileMode.Open))
            {
                obj = (T?)xml.Deserialize(fs);
            }
            return obj;
        }

        public static void Serialize_type()
        {
            XmlSerializer xml = new XmlSerializer(typeof(List<string>));
            using (var fs = new FileStream(path: @"..\..\..\db-types.xml", FileMode.Create))
            {
                xml.Serialize(fs, MainWindow.types);
            }
        }
        public static void Deserialize_type()
        {
            XmlSerializer xml = new XmlSerializer(typeof(List<string>));
            using (var fs = new FileStream(path: @"..\..\..\db-types.xml", FileMode.Open))
            {
                MainWindow.types = (List<string>)xml.Deserialize(fs);
            }
        }
    }
}
