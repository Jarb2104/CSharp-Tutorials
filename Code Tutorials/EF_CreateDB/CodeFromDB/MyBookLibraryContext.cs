using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CodeFromDB;

public partial class MyBookLibraryContext : DbContext
{
    public MyBookLibraryContext()
    {
    }

    public MyBookLibraryContext(DbContextOptions<MyBookLibraryContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Author> Authors { get; set; }

    public virtual DbSet<Book> Books { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Author>(entity =>
        {
            entity.Property(e => e.AuthorId).HasColumnName("AuthorID");
        });

        modelBuilder.Entity<Book>(entity =>
        {
            entity.HasIndex(e => e.BookAuthorAuthorId, "IX_Books_BookAuthorAuthorID");

            entity.Property(e => e.BookId).HasColumnName("BookID");
            entity.Property(e => e.BookAuthorAuthorId).HasColumnName("BookAuthorAuthorID");

            entity.HasOne(d => d.BookAuthorAuthor).WithMany(p => p.Books).HasForeignKey(d => d.BookAuthorAuthorId);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
