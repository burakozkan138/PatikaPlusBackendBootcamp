Console.Clear();

int[] numbers = new int[10];
for (int i = 0; i < numbers.Length; i++)
{
  numbers[i] = i;
}

foreach (var number in numbers)
{
  Console.WriteLine($"Number: {number}");
}

Console.Write("Enter a number to add to the array: ");

int newNumber = Convert.ToInt32(Console.ReadLine());

//Array.Resize(ref numbers, numbers.Length + 1); // Resizes the array to add a new element 

numbers[numbers.Length - 1] = newNumber; // Adds the new element to the last index of the array

Array.Sort(numbers); // Sorts the array in ascending order

Array.Reverse(numbers); // Reverses the array

foreach (var number in numbers)
{
  Console.WriteLine($"Number: {number}");
}

Console.WriteLine("Press any key to exit...");
Console.ReadKey();