using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PostgresWebApp.Models
{
    public class Book
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string AuthorName { get; set; }
        public DateTime Release { get; set; }
        public decimal Price { get; set; }
        public string Genre { get; set; }
    }
}
