using LibraryManagement;

Member member1 = new Member("M001", "Minh ne", "minh@");
Book book1 = new Book("B001", "Sach hay", "Minh luon", 2020, 999);

BorrowTransaction bt = new BorrowTransaction("1", DateTime.Now, member1, book1);
ReturnTransaction rt = new ReturnTransaction("1", DateTime.Now, member1, book1);

List<Transaction> transactions = new List<Transaction>();
transactions.Add(bt);
transactions.Add(rt);

foreach (var item in transactions)
{
    item.Excute();
}