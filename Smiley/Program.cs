using System;

namespace Smiley
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Escreva um número inteiro:");

            int i = int.Parse(Console.ReadLine());

            string s = $"{i:x}";

            Console.WriteLine(s);

            char c = Convert.ToChar(i);

            
            Console.WriteLine(c);
        }
    }
}
