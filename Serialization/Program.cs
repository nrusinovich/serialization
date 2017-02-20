using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Catalog = System.Collections.Generic.List<Serialization.Book>;
namespace Serialization
{
    class Program
    {
        static void Main(string[] args)
        {
            // объект для сериализации
            Book book1 = new Book("1",author: "author1", genre:Genre.Computer);
            Book book2 = new Book("2", author: "author2", genre: Genre.Computer);

            Book book3 = new Book("3", author: "author3", genre: Genre.Fantasy);
            Console.WriteLine("Объект создан");
            Catalog books = new Catalog {book1, book2, book3};
           // Catalog catalog = new Catalog();
            // передаем в конструктор тип класса
            XmlSerializer formatter = new XmlSerializer(typeof(Catalog));
            XmlSerializer formatter1 = new XmlSerializer(typeof(Book));
    
            // получаем поток, куда будем записывать сериализованный объект
            using (FileStream fs = new FileStream("persons.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, books);
               // formatter1.Serialize(fs, book1);
               // formatter1.Serialize(fs, book2);
                Console.WriteLine("Объект сериализован");
            }

            // десериализация
            using (FileStream fs = new FileStream(@"persons.xml", FileMode.OpenOrCreate))
            {
                // Book newBook1 = (Book)formatter.Deserialize(fs);
                // Book newBook2 = (Book)formatter.Deserialize(fs);
                Catalog newCatalog = (Catalog)formatter.Deserialize(fs);

                Console.WriteLine("Объект десериализован");
              Console.WriteLine(newCatalog.ElementAt(0).RegisterDate);
            }
        }
    }
}
