public class Author {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Biography { get; set; }
    public ICollection<Book> Books { get; set; } = new List<Book>();

    public Author (int id, string name, string biography) {
        Id = id;
        Name = name;
        Biography = biography;
    }
}