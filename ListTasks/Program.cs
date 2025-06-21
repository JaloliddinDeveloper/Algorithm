//task 1:
using ListTasks.Classes;

List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

List<int> list =Practice.ShowListElements(numbers);

list.ForEach(x=> Console.Write($" {x}"));