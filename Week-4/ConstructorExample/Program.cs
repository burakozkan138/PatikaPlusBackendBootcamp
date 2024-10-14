using ConstructorExample;

Console.Clear();

Baby baby = new Baby("Burak", "Özkan");
Console.WriteLine($"Name: {baby.Name} Surname: {baby.Surname} Date of Birth: {baby.DateOfBirth}");
Console.WriteLine();

Baby baby2 = new Baby();
Console.WriteLine("Default constructor create a baby with default values");
Console.WriteLine($"Name: {baby2.Name} Surname: {baby2.Surname} Date of Birth: {baby2.DateOfBirth}");
baby2.Name = "İlayda";
baby2.Surname = "Taş";
baby2.DateOfBirth = new DateTime(2024, 12, 12); // This date is in the future
Console.WriteLine("We set the date of birth to a future date, so it should be set to today");
Console.WriteLine($"Name: {baby2.Name} Surname: {baby2.Surname} Date of Birth: {baby2.DateOfBirth}");

Console.ReadLine();