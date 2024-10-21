Console.Clear();

List<string> coffees = new List<string>();

for (int i = 1; i <= 5; i++)
{
  Console.Write($"{1}. Enter a coffee: ");
  string coffee = Console.ReadLine();
  coffees.Add(coffee);
}
Console.Clear();
Console.WriteLine("Here are the coffees you entered");
foreach (string coffee in coffees)
{
  Console.WriteLine(coffee);
}

Console.Write("Press any key to exit...");
Console.ReadKey();