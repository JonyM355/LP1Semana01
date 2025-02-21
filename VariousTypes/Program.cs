using System;

namespace VariousTypes
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int n1 = 1;
            int n2 = 159;
            int n3 = 357;
            Console.WriteLine($"{n1},\n{n2},\n{n3}");

            char c1 = '\u2620';
            char c2 = '\u24BB';
            char c3 = '\u261F';
            Console.WriteLine($"{c1},\n{c2},\n{c3}");
        }
    }
}
