//massiv
using Massivs.Classes;

int[] massiv = new int[] { 1, 7, 3, 5, 5, 6, 8, 2 ,9};

int s = Massiv.SumMassiv(massiv);

int kvs = Massiv.KvSum(massiv);

int stub = Massiv.SumMassivTub(massiv);

int sIndexToq = Massiv.SumIndexToq(massiv);

int SumIndexKv = Massiv.SumIndexKv(massiv);

Console.WriteLine($"S={s}");

Console.WriteLine($"KvSum={kvs}");

Console.WriteLine($"Toq={stub}");

Console.WriteLine($"IndexToq={sIndexToq}");

Console.WriteLine($"Sum Index KV={SumIndexKv}");

MassivSort.Sort(massiv);

Console.WriteLine("\nTartiblangan massiv:");
Console.WriteLine(string.Join(" ", massiv));