using System;

namespace LibraryDemo;

public class Book // class is a blueprint for an object
{
  public string Name { get; set; } // properties is a access modifier for the fields of the class 
  public string AuthorName { get; set; }
  public string AuthorSurname { get; set; }
  public int PageCount { get; set; }
  public string Publisher { get; set; }
  public DateTime RecordDate { get; set; }

  public Book()
  {
    RecordDate = DateTime.Now;
  }

  public Book(string name, string authorName, string authorSurname, int pageCount, string publisher) : this() // this call the default constructor
  {
    Name = name;
    AuthorName = authorName;
    AuthorSurname = authorSurname;
    PageCount = pageCount;
    Publisher = publisher;
  }
}
