using DependencyInjection;

Console.Clear();

Teacher teacher = new Teacher("Burak", "Özkan");
SoftwareTeacher softwareTeacher = new SoftwareTeacher("Yigit", "Hacıefendioğlu", "C#");

Classrom classrom = new Classrom(teacher);
Classrom patika = new Classrom(softwareTeacher);

classrom.GetTeacherInfo();
patika.GetTeacherInfo();

Console.ReadKey();