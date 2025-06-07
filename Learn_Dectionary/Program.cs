//Learn Dictionary
//Task 1:
// Create a dictionary to store the names and ages of people

//using System.Xml.Linq;
//int n = 5;
//Dictionary<string, int> people = new Dictionary<string, int>();

//for (int i = 1; i <= n; i++)
//{
//    Console.Write("Enter your name: ");
//    string name = Console.ReadLine();
//    Console.Write("Enter your age: ");
//    int age = int.Parse(Console.ReadLine());

//    people.Add(name, age);
//}

//foreach (var person in people)
//{
//    Console.WriteLine($"Name: {person.Key}, Age: {person.Value}");
//}

// Task 2:
// Fructy Dictionary
Dictionary<string, decimal> fruits = new Dictionary<string, decimal>();

for (int i = 1; i <= 3; i++)
{
    Console.Write("Enter fruit name: ");
    string fruitName = Console.ReadLine();
    Console.Write("Enter fruit price: ");
    decimal fruitPrice = decimal.Parse(Console.ReadLine());
    fruits.Add(fruitName, fruitPrice);
}

Console.WriteLine("Choose fruit");

string chosenFruit = Console.ReadLine();

if (fruits.ContainsKey(chosenFruit))
{
    Console.WriteLine($"The price of {chosenFruit} is {fruits[chosenFruit]}");
}
else
{
    Console.WriteLine("This fruit is not available in the dictionary.");
}
