public class LibraryBranch {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Location { get; set; }
    public ICollection<Book> Books { get; set; } = new List<Book>();

    public LibraryBranch(int id, string name, string location, ICollection<Book> books) {
        Id = id;
        Name = name;
        Location = location;
        Books = books;
    }
}