Console.Clear();

try // try to run the code in this blcok
{
  Console.Write("Enter a number: "); // prompt the user for a number
  int number = Convert.ToInt32(Console.ReadLine()); // read the user input and convert it to an integer
  Console.WriteLine("The number squared is: " + number * number); // display the square of the number
}
catch (FormatException)
{
  Console.WriteLine("Invalid input. Please enter a number."); // display an error message if the user input is not a number
}
catch (Exception ex)
{
  Console.WriteLine("An error occurred: " + ex.Message); // display an error message if an exception occurs
}
finally
{
  Console.WriteLine("Program complete."); // display a message after the try-catch block has finished executing
}

Console.Write("Press any key to exit...");
Console.ReadKey();