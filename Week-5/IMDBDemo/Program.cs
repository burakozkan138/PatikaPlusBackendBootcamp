using IMDBDemo;

Console.Clear();

List<Movie> movies = new List<Movie>() {
  new Movie("The Shawshank Redemption", 9.3),
    new Movie("The Godfather", 9.2),
    new Movie("The Dark Knight", 9.0),
    new Movie("The Lord of the Rings: The Return of the King", 8.9),
    new Movie("Pulp Fiction", 8.9),
    new Movie("Forrest Gump", 8.8),
    new Movie("Inception", 8.8),
    new Movie("The Matrix", 8.7),
    new Movie("The Lion King", 8.5),
    new Movie("The Terminator", 8.0),
    new Movie("A Beautiful Mind", 8.2),
    new Movie("A Clockwork Orange", 8.3),
    new Movie("A Nightmare on Elm Street", 7.5),
};

while (true)
{
  Console.WriteLine("Create a new movie");

  Console.Write("Movie Name: ");
  string name = Console.ReadLine() ?? string.Empty;
  if (string.IsNullOrEmpty(name)) // Check if the name is empty or null continue
  {
    Console.WriteLine("Not a valid movie name!");
    continue;
  }
  Console.Write("IMDB Score: ");
  double score = Convert.ToDouble(Console.ReadLine());
  if (score < 0 || score > 10) // Check if the score is between 0 and 10
  {
    Console.WriteLine("Not a valid IMDB score! Please enter a score between 0 and 10.");
    continue;
  }

  movies.Add(new Movie(name, score)); // Add the movie to the list
  Console.WriteLine("Movie added successfully!");

  Console.Write("Do you want to add another movie? (Y/N): ");
  string answer = Console.ReadLine()?.ToUpper() ?? string.Empty; // Get the answer and convert it to uppercase
  if (answer != "Y") // If the answer is not 'Y' break the loop
  {
    break;
  }
  Console.Clear();
  Console.WriteLine($"Movie List has been updated! Current movie count: {movies.Count}"); // Show the current movie count
}

Console.Clear();

if (movies.Count == 0) // If there are no movies added, show a message and close the program
{
  Console.WriteLine("No movies added!");
  return;
}

Console.WriteLine("Movie List:"); // Show the movie list
foreach (var movie in movies)
{
  Console.WriteLine(movie);
}

Console.WriteLine("\n----------------------------------------------------------------------------------------------------\n");
Console.WriteLine($"Movies with an IMDB score between 4 and 9:"); // Show the movies with an IMDB score between 4 and 9
foreach (var movie in movies)
{
  if (movie.Rating >= 4 && movie.Rating <= 9)
  {
    Console.WriteLine(movie);
  }
}

Console.WriteLine("\n----------------------------------------------------------------------------------------------------\n");
Console.WriteLine($"Movies starting with 'A':"); // Show the movies starting with 'A'
foreach (var movie in movies)
{
  if (movie.Name.StartsWith("A"))
  {
    Console.WriteLine(movie);
  }
}

Console.Write("Please press any key to exit...");
Console.ReadKey();