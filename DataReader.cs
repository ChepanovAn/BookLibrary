using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary
{
    public class DataReader
    {
        public int Id { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }        
        public int Year { get; set; }
        public string Adress { get; set; }
        public int Phone { get; set; }

        public List<Reader> Readers { get; set; }
    }
}
