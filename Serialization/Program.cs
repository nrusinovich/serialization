using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
namespace Serialization
{
    class Program
    {
        static void Main(string[] args)
        {
           
            XmlSerializer formatter = new XmlSerializer(typeof(Catalog));
            Catalog books = new Catalog();
            // десериализация
            using (FileStream fs = new FileStream(@"C:\Users\Nadzeya_Rusinovich\Documents\Visual Studio 2015\Projects\Serialization\Serialization\RD. HW - AT Lab#. 08 - Books.xml", FileMode.Open))
            {
              books = (Catalog)formatter.Deserialize(fs);
            }
            // сериализация
            using (FileStream fs = new FileStream("persons.xml", FileMode.OpenOrCreate))
            {
               formatter.Serialize(fs, books);     
               Console.WriteLine("Объект сериализован");
            }
        }
    }
}
