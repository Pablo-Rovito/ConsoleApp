public class Book
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string ISBN { get; set; }
    public int AuthorId { get; set; }
    public int AvailableCopies { get; set; }
    public Author Author { get; set; }
    public ICollection<LibraryBranch> LibraryBranches { get; set; } = new List<LibraryBranch>();


    public Book(int id, string title, string isbn, int authorId, int availableCopies, Author author, ICollection<LibraryBranch> libraryBranches) {
        Id = id;
        Title = title;
        ISBN = isbn;
        AuthorId = authorId;
        AvailableCopies = availableCopies;
        Author = author;
        LibraryBranches = libraryBranches;
    }
}