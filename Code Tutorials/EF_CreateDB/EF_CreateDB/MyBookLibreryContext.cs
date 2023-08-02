using Microsoft.EntityFrameworkCore;

namespace BookLibrary
{
    public class MyBookLibreryContext : DbContext
    {
        public DbSet<Author> Authors{ get; set; }
        public DbSet<Book> Books { get; set; }

        public MyBookLibreryContext(DbContextOptions<MyBookLibreryContext> options)
            : base(options) { }
    }
}
