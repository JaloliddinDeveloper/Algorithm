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

Console.Beep(220, 400); // A3 (Low)
Console.Beep(294, 400); // D4
Console.Beep(247, 400); // B3
Console.Beep(220, 600); // A3 (Long sustain)
Console.Beep(196, 400); // G3
Console.Beep(220, 800); // A3 (Distant echo)
Console.Beep(247, 400); // B3
Console.Beep(294, 600); // D4 (Resonant end)
