int n;
if (int.TryParse(Console.ReadLine(), out n))
{
    bool isPowerOfThree = n > 0;

    while (n > 1 && isPowerOfThree)
    {
        if (n % 3 != 0)
        {
            isPowerOfThree = false;
        }
        n = n / 3;
    }

    if (isPowerOfThree && n == 1)
    {
        Console.WriteLine("True");
    }
    else
    {
        Console.WriteLine("False");
    }
}
else
{
    Console.WriteLine("Invalid input. Please enter a valid integer.");
}
