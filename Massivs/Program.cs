//Sum massiv
using Massivs.Classes;

int[] massiv = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 ,9};

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
