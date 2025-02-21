using System;

namespace VariousTypes
{
    public class Program
    {
        private static void Main(string[] args)
        {
            // Ex.3 Whole variables

            int n1 = 1;
            int n2 = 159;
            int n3 = 357;
            Console.WriteLine($"{n1}\n{n2}\n{n3}");


            // Ex.3 Character variables

            char c1 = '\u2620';
            char c2 = '\u24BB';
            char c3 = '\u261F';
            Console.WriteLine($"{c1}\n{c2}\n{c3}");


            // Ex.3 Real literals

            double d1 = 3.2154;
            float f1 = 9.654f;
            decimal dml1 = 0.482m;
            Console.WriteLine($"{d1}\n{f1}\n{dml1}");


            //Ex.3 Booleans

            bool T = true;
            bool F = false;
            Console.WriteLine($"{T}\n{F}");
        }
    }
}
