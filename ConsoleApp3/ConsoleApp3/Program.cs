using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "java";
            string result = Convert.ToString(word);
            for (int i = word.Length - 1; i >= 0; i--)
            {
                word = word.ToUpper();
                Console.WriteLine(word[i]);
            }
            Console.Read();
        }
    }
}
