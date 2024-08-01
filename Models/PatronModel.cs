public class Patron {
    public int Id { get; set; }
    public string Name { get; set; }
    public string MembershipNumber { get; set; }
    public ICollection<BorrowRecord> BorrowRecords { get; set; }

    public Patron(int id, string name, string membershipNumber, ICollection<BorrowRecord> borrowRecords) {
        Id = id;
        Name = name;
        MembershipNumber = membershipNumber;
        BorrowRecords = borrowRecords;
    }
}