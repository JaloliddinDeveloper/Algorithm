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
//Dictionary<string, decimal> fruits = new Dictionary<string, decimal>();

//for (int i = 1; i <= 3; i++)
//{
//    Console.Write("Enter fruit name: ");
//    string fruitName = Console.ReadLine();
//    Console.Write("Enter fruit price: ");
//    decimal fruitPrice = decimal.Parse(Console.ReadLine());
//    fruits.Add(fruitName, fruitPrice);
//}

//Console.WriteLine("Choose fruit");

//string chosenFruit = Console.ReadLine();

//if (fruits.ContainsKey(chosenFruit))
//{
//    Console.WriteLine($"The price of {chosenFruit} is {fruits[chosenFruit]}");
//}
//else
//{
//    Console.WriteLine("This fruit is not available in the dictionary.");
//}


// Task 3:
// Puple Dictionary

//Dictionary<string, List<double>> student = new Dictionary<string, List<double>>();

//for (int i = 1; i <= 2; i++)
//{
//    Console.Write("Enter Name: ");
//    string name = Console.ReadLine();

//    List<double> marks = new List<double>();

//    for (int j = 1; j <= 3; j++)
//    {
//        Console.Write("Enter Mark: ");
//        double mark = double.Parse(Console.ReadLine());

//        marks.Add(mark);
//    }

//    student.Add(name, marks);
//}

//foreach (var item in student)
//{
//    double average = item.Value.Average();
//    if (item.Value.Count > 0)
//    {
//         Console.WriteLine($"Name: {item.Key}, Average Marks: {average:F2}");
//    }   
//}

// Task 4:

//Dictionary<string, int> students = new Dictionary<string, int>();

//for (int i = 1; i <= 3; i++)
//{
//    Console.Write("Enter name: ");
//    string name = Console.ReadLine();
//    Console.Write("Enter age: ");
//    int age = int.Parse(Console.ReadLine());

//    students.Add(name, age);
//}

//int maxAge = students.Values.Max();
//string oldestStudent = students.FirstOrDefault(x => x.Value == maxAge).Key;
//Console.WriteLine($"Oldest student: {oldestStudent}, Age: {maxAge}");

// Task 5:

//Dictionary<string, int> students = new Dictionary<string, int>();

//for (int i = 1; i <= 3; i++)
//{
//    Console.Write("Enter name: ");
//    string name = Console.ReadLine();
//    Console.Write("Enter age: ");
//    int age = int.Parse(Console.ReadLine());

//    students.Add(name, age);
//}
//var studentSorted = students.OrderByDescending(a => a.Value);

//foreach (var student in studentSorted)
//{
//    Console.WriteLine($"Name: {student.Key}, Age: {student.Value}");
//}       

// Task 6:

//Dictionary<string, int> students = new Dictionary<string, int>();

//students.Add("Alice", 20);
//students.Add("Bob", 22);
//students.Add("Charlie", 21);


//Console.WriteLine(students["Alice"]);


int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int k = 6;
bool found = false;
int left = 0;
int right = nums.Length - 1;

while (left <= right)
{
    int mid= (left + right) / 2;

    if(nums[mid] == k)
    {
        Console.WriteLine($"Topildi: {nums[mid]} Index: {mid}");
        found = true;
        break;
    }

    else if(nums[mid] > k)
    {
        right = mid - 1;
    }
    else
    {
        left = mid + 1;
    }
}

if(!found)
{
    Console.WriteLine("Yo'q");
}

//for (int i = 0; i < nums.Length; i++)
//{
//    if (nums[i] == k)
//    {
//        Console.WriteLine($"Found {k} at index {i}");
//        found = true;
//        break;
//    }
//}

//if (!found)
//{
//    Console.WriteLine($"{k} not found in the array.");
//}
