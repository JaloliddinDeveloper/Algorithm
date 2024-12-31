//two numbers sum
using Algorithm.Classes;

Console.Write("a=");
int a = int.Parse(Console.ReadLine());
Console.Write("b=");
int b = int.Parse(Console.ReadLine());

int s= Algoritm.Sum(a, b);

Console.WriteLine($"{a}+{b}={s}");

//factorial
Console.Write("n=");
int n = int.Parse(Console.ReadLine());
int f = Algoritm.Factorial(n);
Console.WriteLine($"{n}!={f}");