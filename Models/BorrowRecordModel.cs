public class BorrowRecord {
    public int Id { get; set; }
    public int BookId { get; set; }
    public int PatronId { get; set; }
    public DateTime BorrowDate { get; set; }
    public DateTime? ReturnDate { get; set; }
    public Book Book { get; set; }
    public Patron Patron { get; set; }

    public BorrowRecord(int id, int bookId, int patronId, DateTime borrowDate, DateTime? returnDate, Book book, Patron patron) {
        Id = id;
        BookId = bookId;
        PatronId = patronId;
        BorrowDate = borrowDate;
        ReturnDate = returnDate;
        Book = book;
        Patron = patron;
    }
}