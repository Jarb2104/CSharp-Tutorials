using CodeFromDB;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework
{
    class Program
    {
        static IEnumerable<CodeFromDB.Author> CreateFakeData()
        {
            List<CodeFromDB.Author> Authors = new List<CodeFromDB.Author>
            {
                new CodeFromDB.Author
                {
                    Name = "Sweet Kings", Books = new List<CodeFromDB.Book>
                    {
                        new CodeFromDB.Book {Title = "Emma", PublicationYear = 2023 },
                        new CodeFromDB.Book {Title = "Has Some", PublicationYear = 2025 },
                        new CodeFromDB.Book {Title = "War Driven Thongs", PublicationYear = 2026 },
                    }
                },
                new CodeFromDB.Author
                {
                    Name = "Alex Kings", Books = new List<CodeFromDB.Book>
                    {
                        new CodeFromDB.Book {Title = "Ian", PublicationYear = 2021 },
                        new CodeFromDB.Book {Title = "Has Some", PublicationYear = 2025 },
                        new CodeFromDB.Book {Title = "Anal Driven Impulses", PublicationYear = 2027 },
                    }
                }
            };

            return Authors;
        }

        static void Main()
        {
            DbContextOptions<MyBookLibraryContext> options = new DbContextOptionsBuilder<MyBookLibraryContext>()
                .UseSqlite($"Filename=../../../MyBookLibrary.db")
                .Options;

            using MyBookLibraryContext db = new MyBookLibraryContext(options);
            db.Database.EnsureCreated();

            //IEnumerable<Author> Authors = CreateFakeData();
            //db.Authors.AddRange( Authors );
            //db.SaveChanges();

            foreach (CodeFromDB.Author author in db.Authors.Include(ath => ath.Books))
            {
                Console.WriteLine($"{author.Name} wrote...");

                foreach (CodeFromDB.Book book in author.Books)
                    Console.WriteLine($"    {book.Title} [{book.PublicationYear}]");

                Console.WriteLine("");
                Console.WriteLine("(_!_)");
                Console.WriteLine("");
            }
        }
    }
}