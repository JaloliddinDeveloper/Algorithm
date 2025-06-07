//Learn Dictionary
//Task 1:
// Create a dictionary to store the names and ages of people

using System.Xml.Linq;
int n = 5;
Dictionary<string, int> people = new Dictionary<string, int>();
   
for (int i = 1; i <= n; i++)
{
    Console.Write("Enter your name: ");
    string name = Console.ReadLine();
    Console.Write("Enter your age: ");
    int age = int.Parse(Console.ReadLine());

    people.Add(name, age);
}

foreach (var person in people)
{
    Console.WriteLine($"Name: {person.Key}, Age: {person.Value}");
}
