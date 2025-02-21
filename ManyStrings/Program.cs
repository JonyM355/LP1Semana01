using System;

namespace ManyStrings
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string s1 = "Olá... \n...Adeus!";
            string s2 = "Símbolo \u03A9!";
            string s3 = "Tab \t !";

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
        }
    }
}
