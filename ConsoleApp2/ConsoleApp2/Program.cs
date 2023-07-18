using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var countofvowels = 0;
            var countofconsonats = 0;
            var sentence = "Hello Word";

            for (int i = 0; i < sentence.Length; i++)
            {
                int b = VowelsOrConsonats(sentence[i]);
                if (b == 1) countofvowels++;
                if (b == 2) countofconsonats++;
            }
            Console.WriteLine($"The count of vowels is: {countofvowels}   The count of consonants is: {countofconsonats}");
            Console.Read();
        }

        public static int VowelsOrConsonats(char symbol)
        {
            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u', 'y', 'A', 'E', 'I', 'O', 'U', 'Y' };
            if (symbol == ' ') return 0;

            for (int i = 0; i < vowels.Length; i++)
            {
                if (vowels[i] == symbol) return 1;
            }
            return 2;
        }
    }
}