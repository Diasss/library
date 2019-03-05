using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Book
    {
        public int bookId { get; set; }
        public string name { get; set; }
        public int code { get; set; }
        public string author { get; set; }
        public DateTime publishDate { get; set; }
        public int edition { get; set; }
        public int status { get; set; }

    }
}
