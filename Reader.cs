using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary
{
    public class Reader
    {
        public int Id { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
             
        public int StorageTime { get; set; }

        public int BookLibraryId { get; set; }
        public BookLibrary BookLibrary { get; set; }

        public int DataReaderId { get; set; }
        public DataReader DataReader { get; set; }
    }
}
