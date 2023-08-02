namespace BookLibrary
{
    public class Book
    {
        public int BookID { get; set; }
        public string Title { get; set; } = null!;
        public int PublicationYear { get; set; }
        public Author BookAuthor { get; set; } = null!;

        public override string ToString()
        {
            return $"{Title} [{PublicationYear}]";
        }
    }
}