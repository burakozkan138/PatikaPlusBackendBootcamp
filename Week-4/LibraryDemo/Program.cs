using LibraryDemo;

Console.Clear();


Library.PrintLibraryInfo();
Console.WriteLine("*************************************************************");

while (true) // if the user selects 5, the loop will break
{
  Library.PrintMenu();
}