using System;
using System.Runtime.InteropServices;

namespace LibraryDemo;

public class Library
{
  public string Name { get; set; }
  public string Address { get; set; }
  public string City { get; set; }
  public string Country { get; set; }
  public List<Book> Books { get; set; }

  public Library()
  {
    Name = "Patika Kitaplığı";
    Address = "No: 1, Patika Sk.";
    City = "İstanbul";
    Country = "Türkiye";
    Books = new List<Book>()
    {
        new Book("Kürk Mantolu Madonna", "Sabahattin", "Ali", 177, "Yapı Kredi Yayınları"),
        new Book("Tutunamayanlar", "Oğuz", "Atay", 724, "İletişim Yayınları"),
        new Book("Saatleri Ayarlama Enstitüsü", "Ahmet Hamdi", "Tanpınar", 392, "Dergah Yayınları"),
        new Book("İnce Memed", "Yaşar", "Kemal", 436, "Yapı Kredi Yayınları"),
        new Book("Aşk", "Elif", "Şafak", 420, "Doğan Kitap"),
        new Book("Serenad", "Zülfü", "Livaneli", 484, "Doğan Kitap"),
        new Book("Beyaz Kale", "Orhan", "Pamuk", 160, "İletişim Yayınları"),
        new Book("Puslu Kıtalar Atlası", "İhsan Oktay", "Anar", 240, "İletişim Yayınları"),
        new Book("Huzur", "Ahmet Hamdi", "Tanpınar", 400, "Dergah Yayınları"),
        new Book("Eylül", "Mehmet Rauf", "", 368, "Ötüken Neşriyat")
    };
  }

  public void PrintLibraryInfo()
  {
    PrintWelcomeMessage();
    Console.WriteLine($"Name: {Name}\nAddress: {Address}\nCity: {City}\nCountry: {Country}");
  }

  public void PrintWelcomeMessage()
  {
    Console.WriteLine($"*** Welcome to {Name} Library! ***");
  }

  public void PrintMenu()
  {
    Console.WriteLine("Please select an option to continue:");
    Console.WriteLine("1- List Books");
    Console.WriteLine("2- Book Details");
    Console.WriteLine("3- Add Book");
    Console.WriteLine("4- Remove Book");
    Console.WriteLine("5- Exit");
    Console.Write("Your choice: ");

    string? choice = Console.ReadLine();
    PerformOperation(choice);
  }

  public void PerformOperation(string? choice)
  {
    Console.Clear();
    switch (choice)
    {
      case "1":
        PrintBooks();
        break;
      case "2":
        Console.Write("Enter the name of the book: ");
        string? bookName = Console.ReadLine();
        PrintBookDetails(bookName);
        break;
      case "3":
        CreateBook();
        break;
      case "4":
        Console.Write("Enter the name of the book: ");
        string? bookNameToRemove = Console.ReadLine();
        RemoveBook(bookNameToRemove);
        break;
      case "5":
        Console.WriteLine("Goodbye!");
        Environment.Exit(0);
        break;
      default:
        Console.WriteLine("Invalid option! Please try again.");
        PrintMenu();
        break;
    }
    Console.WriteLine("Press any key to continue...");
    Console.ReadLine();
    Console.Clear();
  }

  public void PrintBooks()
  {
    Console.WriteLine("Books in the Library:");
    foreach (var book in Books)
    {
      Console.WriteLine($"- {book.Name} by {book.AuthorName} {book.AuthorSurname}");
    }
  }

  public void PrintBookDetails(string? bookName)
  {
    var book = Books.FirstOrDefault(b => b.Name.ToLower() == bookName?.ToLower());
    if (book != null)
    {
      Console.WriteLine($"Book Details:\nName: {book.Name}\nAuthor: {book.AuthorName} {book.AuthorSurname}\nPage Count: {book.PageCount}\nPublisher: {book.Publisher}\nRecord Date: {book.RecordDate}");
    }
    else
    {
      Console.WriteLine($"Book named {bookName} is not found in the library.");
    }
  }

  public void CreateBook()
  {
    Console.Write("Enter the name of the book: ");
    string? name = Console.ReadLine();
    Console.Write("Enter the author name of the book: ");
    string? authorName = Console.ReadLine();
    Console.Write("Enter the author surname of the book: ");
    string? authorSurname = Console.ReadLine();
    Console.Write("Enter the page count of the book: ");
    int pageCount = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter the publisher of the book: ");
    string? publisher = Console.ReadLine();
    AddBook(new Book(name, authorName, authorSurname, pageCount, publisher));
  }

  public void AddBook(Book book)
  {
    Books.Add(book);
    Console.WriteLine($"{book.Name} is successfully added to the library.");
  }

  public void RemoveBook(string? bookName)
  {
    var book = Books.FirstOrDefault(b => b.Name.ToLower() == bookName?.ToLower());
    if (book != null)
    {
      Books.Remove(book);
      Console.WriteLine($"{book.Name} is successfully removed from the library.");
    }
    else
    {
      Console.WriteLine($"Book named {bookName} is not found in the library.");
    }
  }
}