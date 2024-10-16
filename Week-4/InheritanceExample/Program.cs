using InheritanceExample;

Console.Clear();

Teacher teacher = new Teacher("Yiğit", "Hacıefendioğlu");
teacher.Print();

Console.WriteLine("**********");

Student student = new Student("Burak", "Özkan");
student.Print();

Console.WriteLine("Please press any key to exit...");
Console.ReadKey();