Console.Clear();

List<string> guests = new List<string>(); // Create a list to store the names of the guests

Console.WriteLine("Welcome to the Patika Plus Gala Night!");

while (true)
{
  Console.WriteLine("Please enter the name of the guest you want to add to the list. If you want to exit, type 'q/exit'");
  Console.Write("Guest Name: ");
  string guest = Console.ReadLine(); // Get the name of the guest from the user

  if (string.IsNullOrEmpty(guest)) // Check if the user entered a valid name
  {
    Console.WriteLine("Please enter a valid name.");
    continue;
  }

  if (guest.ToLower() == "q" || guest.ToLower() == "exit") // Check if the user wants to exit
  {
    break;
  }

  guests.Add(guest); // Add the guest to the list
}
Console.Clear(); // Clear the console
Console.WriteLine("The guests who will attend the gala night are as follows:"); // Display the list of guests
int i = 1;
foreach (var guest in guests) // Loop through the list of guests and display them
{
  Console.WriteLine($"{i}. - {guest}");
  i++;
}

Console.WriteLine("Press any key to exit...");
Console.ReadKey();