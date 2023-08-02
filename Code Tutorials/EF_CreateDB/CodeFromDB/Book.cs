using System;
using System.Collections.Generic;

namespace CodeFromDB;

public partial class Book
{
    public long BookId { get; set; }

    public string Title { get; set; } = null!;

    public long PublicationYear { get; set; }

    public long BookAuthorAuthorId { get; set; }

    public virtual Author BookAuthorAuthor { get; set; } = null!;
}
