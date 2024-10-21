Console.Clear();

List<string> guests = new List<string>();

Console.WriteLine("Welcome to the Patika Plus Gala Night!");

while (true)
{
  Console.WriteLine("Please enter the name of the guest you want to add to the list. If you want to exit, type 'q/exit'");
  Console.Write("Guest Name: ");
  string guest = Console.ReadLine();

  if (string.IsNullOrEmpty(guest))
  {
    Console.WriteLine("Please enter a valid name.");
    continue;
  }

  if (guest.ToLower() == "q" || guest.ToLower() == "exit")
  {
    break;
  }

  guests.Add(guest);
}
Console.Clear();
Console.WriteLine("The guests who will attend the gala night are as follows:");
int i = 1;
foreach (var guest in guests)
{
  Console.WriteLine($"{i}. {guest}");
  i++;
}

Console.WriteLine("Press any key to exit...");
Console.ReadKey();