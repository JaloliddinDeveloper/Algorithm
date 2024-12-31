namespace Algorithm.Classes
{
    public class Algoritm
    {
        public static int Sum(int a, int b)=>
             a + b;
        

        public static int Factorial(int a)
        {
            int p = 1;
            for (int i = 1; i <= a; i++)
            {
                p *= i;
            }
            return p;
        }
    }
}
