using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary
{
    public class BookLibrary
    {
        public int Id { get; set; }
        public string Autor { get; set; }
        public int BookTitle { get; set; }
        public int Rest { get; set; }

        public List<Reader> Readers { get; set; }
    }
}
