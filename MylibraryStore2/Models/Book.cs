using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MylibraryStore2.Models
{
    public class Book
    {
        public int id { get; set; }
        public string BookName { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public string Genre { get; set; }
        public DateTime PublishedDate { get; set; }
    }
}
