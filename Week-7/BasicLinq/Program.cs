Console.Clear();
List<int> numbers = new List<int> { -1, -33, 3, 4, 5, 6, 7, 2, 23, 16, 19, 545, 76, 34, 23, 12 };

Console.WriteLine("Even Numbers:");
numbers.Where(x => x % 2 == 0).ToList().ForEach(x => Console.WriteLine(x)); // write even numbers

Console.WriteLine("Odd Numbers:");
numbers.Where(x => x % 2 != 0).ToList().ForEach(x => Console.WriteLine(x)); // write odd numbers

Console.WriteLine("Negative Numbers:");
numbers.Where(x => x < 0).ToList().ForEach(x => Console.WriteLine(x)); // write negative numbers

Console.WriteLine("Positive Numbers:");
numbers.Where(x => x > 0).ToList().ForEach(x => Console.WriteLine(x)); // write positive numbers

Console.WriteLine("Numbers greater than 15 and less than 22:");
numbers.Where(x => x > 15 && x < 22).ToList().ForEach(x => Console.WriteLine(x)); // write numbers greater than 15 and less than 22

Console.WriteLine("Square of each number:");
numbers.Select(x => x * x).ToList().ForEach(x => Console.WriteLine(x)); // write square of each number

Console.WriteLine("Please press any key to exit...");
Console.ReadLine();