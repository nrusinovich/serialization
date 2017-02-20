using System;
using System.IO;
using System.Xml.Serialization;

namespace Serialization
{
    [Serializable]
    [XmlType("book")]
   public class Book
    {
        [XmlAttribute("id")]
        public string Id { get; set; }
        [XmlElement("ibsn")]
        public string Ibsn { get; set; }
        [XmlElement("author")]
        public string Author { get; set; }
        [XmlElement("publisher")]
        public string Publisher { get; set; }
        [XmlElement("title")]
        public string Title { get; set; }
        [XmlElement("genre")]
        public Genre Genre { get; set; }
        [XmlElement("description")]
        public string Description{ get; set; }
        [XmlElement("publish_date")]
        public DateTime PublishDate { get; set; }
        [XmlElement("register_date")]
        public DateTime RegisterDate { get; set; }
        public Book()
        {

        }
        public Book(string id = "", string ibsn = "", string author = "", string title = "", string description = "", string publisher = "", Genre genre = Genre.Computer, string pdate = "2001-01-01", string rdate = "2001-01-01")
        {
            Id = id;
            Ibsn = ibsn;
            Author = author;
            Title = title;
            Description = description;
            Publisher = publisher;
            PublishDate = DateTime.Parse(pdate).Date;
            RegisterDate = DateTime.Parse(rdate).Date;
            Genre = genre;

        }

    }
  
   public enum Genre
    {
        Fantasy,
        Computer,
        Romance
    }
}
