using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "CodeAcademy is a good place to study";
            string[] result = sentence.Split(' ');
            Console.WriteLine($"Total number of words in the string is:{result.Length}");
        }
    }
}
