namespace BookLibrary
{
    public class Author
    {
        public int AuthorID { get; set; }
        public string Name { get; set; } = null!;
        public ICollection<Book> Books { get; set; } = null!;

        public override string ToString()
        {
            return $"Ayam! {Name}";
        }
    }
}
