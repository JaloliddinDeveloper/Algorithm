using OOP.Classes;

Group group1 = new Group { GroupName = "Math 101" };

List<Student> students = new List<Student>();

Console.Write("How many students would you like to add? ");
int studentCount = int.Parse(Console.ReadLine());

for (int i = 0; i < studentCount; i++)
{
    Console.WriteLine($"Enter details for student #{i + 1}:");

    Console.Write("Enter Name: ");
    string name = Console.ReadLine();

    Console.Write("Enter Age: ");
    int age = int.Parse(Console.ReadLine());

    Student newStudent = new Student { Name = name, Age = age };
    students.Add(newStudent);
}


group1.AddMultipleStudents(students);

Console.WriteLine("\nList of students in the group:");
group1.ListStudents(); 