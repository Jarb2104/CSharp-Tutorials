using BookLibrary;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework
{
    class Program
    {
        static IEnumerable<Author> CreateFakeData()
        {
            List<Author> Authors = new List<Author>
            {
                new Author
                {
                    Name = "Sweet Kings", Books = new List<Book>
                    {
                        new Book {Title = "Emma", PublicationYear = 2023 },
                        new Book {Title = "Has Some", PublicationYear = 2025 },
                        new Book {Title = "War Driven Thongs", PublicationYear = 2026 },
                    }
                },
                new Author
                {
                    Name = "Alex Kings", Books = new List<Book>
                    {
                        new Book {Title = "Ian", PublicationYear = 2021 },
                        new Book {Title = "Has Some", PublicationYear = 2025 },
                        new Book {Title = "Anal Driven Impulses", PublicationYear = 2027 },
                    }
                }
            };

            return Authors;
        }

        static void Main()
        {
            DbContextOptions<BooksContext> options = new DbContextOptionsBuilder<BooksContext>()
                .UseSqlite($"Filename=../../../MyBookLibrary.db")
                .Options;

            using BooksContext db = new BooksContext(options);
            db.Database.EnsureCreated();

            //IEnumerable<Author> Authors = CreateFakeData();
            //db.Authors.AddRange( Authors );
            //db.SaveChanges();

            foreach (Author author in db.Authors.Include(ath => ath.Books))
            {
                Console.WriteLine($"{author.Name} wrote...");

                foreach (Book book in author.Books)
                    Console.WriteLine($"    {book.Title} [{book.PublicationYear}]");

                Console.WriteLine("");
                Console.WriteLine("(_!_)");
                Console.WriteLine("");
            }
        }
    }
}