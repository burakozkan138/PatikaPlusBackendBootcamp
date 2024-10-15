using LibraryDemo;

Console.Clear();

Library library = new Library();

library.PrintLibraryInfo();
Console.WriteLine("*************************************************************");

while (true) // if the user selects 5, the loop will break
{
  library.PrintMenu();
}