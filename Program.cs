using System;

namespace BookLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            using (DbLibrary context = new DbLibrary())
            {
                DataReader reader = new DataReader()
                {
                    Name = "Pavel",
                    Surname = "Teplov",
                    Year = 1994,
                    Adress = "Pushkin street, 23-57",
                    Phone = 123456789
                };

                BookLibrary library = new BookLibrary()
                {
                    Autor = "Pushkin A.S.",
                    BookTitle = 2,
                    Rest = 20
                };

                context.DataReaders.Add(reader);
                context.BookLibraries.Add(library);
                context.SaveChanges();

                Console.WriteLine($"id:{reader.Id}, name:{reader.Name}, surname:{reader.Surname}, adress:{reader.Adress}, phone:{reader.Phone}");
                Console.WriteLine($"id:{library.Id}, autor:{library.Autor}, bookTitle:{library.BookTitle}, rest:{library.Rest}");
                Console.ReadLine();
            }
        }
    }
}
