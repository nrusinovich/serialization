using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
     public class Catalog1 : List<Book>
    {
        public Catalog1()
        {

        }
        public Catalog1(List<Book> books)
        {
           AddRange(books);
        }
    }
}
