using AbstractionExample;

Console.Clear();

ProjectDirector projectDirector = new ProjectDirector("Ali", "Yılmaz");
projectDirector.ShowInfo();
projectDirector.Work();
Console.WriteLine("***************************************************");

SoftwareDeveloper softwareDeveloper = new SoftwareDeveloper("Burak", "Özkan");
softwareDeveloper.ShowInfo();
softwareDeveloper.Work();

Console.WriteLine("\nPress any key to close...");
Console.ReadKey();