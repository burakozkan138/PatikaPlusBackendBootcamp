Console.Clear();

try
{
  Console.Write("Enter a number: ");
  int number = Convert.ToInt32(Console.ReadLine());
  Console.WriteLine("The number squared is: " + number * number);
}
catch (FormatException)
{
  Console.WriteLine("Invalid input. Please enter a number.");
}
catch (Exception ex)
{
  Console.WriteLine("An error occurred: " + ex.Message);
}
finally
{
  Console.WriteLine("Program complete.");
}

Console.Write("Press any key to exit...");
Console.ReadKey();