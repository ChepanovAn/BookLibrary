using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary
{
    public class DbLibrary : DbContext
    {
        public DbSet<BookLibrary> BookLibraries { get; set; }
        public DbSet<Reader> Readers { get; set; }
        public DbSet<DataReader> DataReaders { get; set; }

        public DbLibrary()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=LibraryDb;Trusted_Connection=True;");
        }

    }
}
