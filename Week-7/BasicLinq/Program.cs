Console.Clear();
List<int> numbers = new List<int> { 3, 4, 5, 6, 7, 2, 23, 545, 76, 34, 23, 12 };

numbers.Where(x => x % 2 == 0).ToList().ForEach(x => Console.WriteLine(x)); // write even numbers
numbers.Where(x => x % 2 != 0).ToList().ForEach(x => Console.WriteLine(x)); // write odd numbers
numbers.Where(x => x < 0).ToList().ForEach(x => Console.WriteLine(x)); // write negative numbers
numbers.Where(x => x > 0).ToList().ForEach(x => Console.WriteLine(x)); // write positive numbers
numbers.Where(x => x > 15 && x < 22).ToList().ForEach(x => Console.WriteLine(x)); // write numbers greater than 15 and less than 22
numbers.Select(x => x * x).ToList().ForEach(x => Console.WriteLine(x)); // write square of each number