namespace Massivs.Classes
{
    public class Massiv
    {
        public static bool NumberKV(int t)
        {
            bool k = Math.Sqrt(t) % 1 == 0;
            return k;
        }

        public static bool IsPrime(int k)
        {
            if (k <= 1) return false;
            if (k == 2) return true;
            if (k % 2 == 0) return false;

            for (int i = 3; i <= Math.Sqrt(k); i += 2)
            {
                if (k % i == 0) return false;
            }
            return true;
        }

        public static int SumMassiv(int[] a)
        {
            int s = 0;
            for (int i = 0; i < a.Length; i++)
            {
                s += a[i];
            }
            return s;
        }

        public static int KvSum(int[] a)
        {
            int s = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (NumberKV(a[i]))
                {
                    s += a[i];
                }
            }
            return s;
        }

        public static int SumMassivTub(int[] a)
        {
            int s = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (IsPrime(a[i]))
                {
                    s += a[i];
                }
            }
            return s;
        }

        public static int SumIndexToq(int[] a)
        {
            int s = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (i % 2 == 1)
                {
                    s += a[i];
                }
            }
            return s;
        }

        public static int SumIndexKv(int[] a)
        {
            int s = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (NumberKV(i))
                {
                    s += a[i];
                }
            }
            return s;
        }

        public static int[] ShowAllOddNumbers(int n)
        {
           
            int count = (n + 1) / 2; 
            int[] odd = new int[count]; 
            int k = 0; 

            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 1) 
                {
                    odd[k] = i;
                    k++; 
                }
            }

            return odd;
        }

    }
}
