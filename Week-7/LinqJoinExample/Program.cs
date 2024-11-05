public class Program
{
  public static void Main()
  {
    Console.Clear();

    List<Author> authors = new List<Author>
        {
            new Author(1, "Orhan Pamuk"),
            new Author(2, "Elif Şafak"),
            new Author(3, "Ahmet Ümit")
        };

    List<Book> books = new List<Book>
        {
            new Book(1, "Kar", 1),
            new Book(2, "İstanbul", 1),
            new Book(3, "10 Minutes 38 Seconds in This Strange World", 2),
            new Book(4, "Beyoğlu Rapsodisi", 3)
        };

    var query = authors.Join(books, author => author.Id, book => book.AuthorId, (author, book) => new
    {
      AuthorName = author.Name,
      BookTitle = book.Title
    });

    foreach (var item in query)
    {
      Console.WriteLine($"Author: {item.AuthorName}, Book: {item.BookTitle}");
    }

    Console.WriteLine("Press any key to exit...");
    Console.ReadLine();
  }
}

public class Author
{
  public int Id { get; set; }
  public string Name { get; set; }

  public Author(int id, string name)
  {
    Id = id;
    Name = name;
  }
}

public class Book
{
  public int Id { get; set; }
  public string Title { get; set; }
  public int AuthorId { get; set; }

  public Book(int id, string title, int authorId)
  {
    Id = id;
    Title = title;
    AuthorId = authorId;
  }
}