namespace Numbers.Classes
{
    public class Find
    {
        public static void SumOddAndEven(int n)
        {
            int sumEven = 0;
            int sumOdd = 0;
            for (int i = 0; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    sumEven++;
                }
                else
                {
                    sumOdd++;
                }
            }
            Console.WriteLine($"Sum of odd numbers: {sumOdd}");
            Console.WriteLine($"Sum of even numbers: {sumEven}");
        }

        public static string ReserveWord(string word)
        {
            string result = "";
            for (int i = word.Length - 1; i >= 0; i--)
            {
                result += word[i];
            }
            return result;
        }

        public static string ChangeLotinToKrilWord(string word)
        {
            string result = "";
            foreach (var letter in word)
            {
                char cyrillicLetter = ' ';
                if (letter >= 'a' && letter <= 'z')
                {
                    switch (letter)
                    {
                        case 'a': cyrillicLetter = 'а'; break;
                        case 'b': cyrillicLetter = 'б'; break;
                        case 'c': cyrillicLetter = 'ц'; break;
                        case 'd': cyrillicLetter = 'д'; break;
                        case 'e': cyrillicLetter = 'е'; break;
                        case 'f': cyrillicLetter = 'ф'; break;
                        case 'g': cyrillicLetter = 'г'; break;
                        case 'h': cyrillicLetter = 'х'; break;
                        case 'i': cyrillicLetter = 'и'; break;
                        case 'j': cyrillicLetter = 'й'; break;
                        case 'k': cyrillicLetter = 'к'; break;
                        case 'l': cyrillicLetter = 'л'; break;
                        case 'm': cyrillicLetter = 'м'; break;
                        case 'n': cyrillicLetter = 'н'; break;
                        case 'o': cyrillicLetter = 'о'; break;
                        case 'p': cyrillicLetter = 'п'; break;
                        case 'q': cyrillicLetter = 'к'; break;
                        case 'r': cyrillicLetter = 'р'; break;
                        case 's': cyrillicLetter = 'с'; break;
                        case 't': cyrillicLetter = 'т'; break;
                        case 'u': cyrillicLetter = 'у'; break;
                        case 'v': cyrillicLetter = 'в'; break;
                        case 'w': cyrillicLetter = 'в'; break;
                        case 'x': cyrillicLetter = 'х'; break;
                        case 'y': cyrillicLetter = 'ы'; break;
                        case 'z': cyrillicLetter = 'з'; break;
                        case ' ': cyrillicLetter = ' '; break;
                        default: break;
                    }
                }
                else if (letter >= 'A' && letter <= 'Z')
                {
                    switch (letter)
                    {
                        case 'A': cyrillicLetter = 'А'; break;
                        case 'B': cyrillicLetter = 'Б'; break;
                        case 'C': cyrillicLetter = 'Ц'; break;
                        case 'D': cyrillicLetter = 'Д'; break;
                        case 'E': cyrillicLetter = 'Е'; break;
                        case 'F': cyrillicLetter = 'Ф'; break;
                        case 'G': cyrillicLetter = 'Г'; break;
                        case 'H': cyrillicLetter = 'Х'; break;
                        case 'I': cyrillicLetter = 'И'; break;
                        case 'J': cyrillicLetter = 'Й'; break;
                        case 'K': cyrillicLetter = 'К'; break;
                        case 'L': cyrillicLetter = 'Л'; break;
                        case 'M': cyrillicLetter = 'М'; break;
                        case 'N': cyrillicLetter = 'Н'; break;
                        case 'O': cyrillicLetter = 'О'; break;
                        case 'P': cyrillicLetter = 'П'; break;
                        case 'Q': cyrillicLetter = 'К'; break;
                        case 'R': cyrillicLetter = 'Р'; break;
                        case 'S': cyrillicLetter = 'С'; break;
                        case 'T': cyrillicLetter = 'Т'; break;
                        case 'U': cyrillicLetter = 'У'; break;
                        case 'V': cyrillicLetter = 'В'; break;
                        case 'W': cyrillicLetter = 'В'; break;
                        case 'X': cyrillicLetter = 'Х'; break;
                        case 'Y': cyrillicLetter = 'Ы'; break;
                        case 'Z': cyrillicLetter = 'З'; break;
                        case ' ': cyrillicLetter = ' '; break;
                        default: break;
                    }
                }
                result += cyrillicLetter;
            }
            return result;
        }

        public static string changeTwoNumbers(int a)
        {
            string s = "";
            string hexDigits = "0123456789ABCDEF";

            while (a > 0)
            {
                int remainder = a % 16;
                s = hexDigits[remainder] + s;
                a = a / 16;
            }

            return s == "" ? "0" : s; // Return "0" if the input is 0
        }

        public static int IsPowerOf3(int n)
        {

            if (n <= 0)
            {
                return -1; 
            }

            int i = 0; 
            while (n % 3 == 0)
            {
                n /= 3; 
                i++; 
            }
            return n == 1 ? i : -1;
        }


    }
}
