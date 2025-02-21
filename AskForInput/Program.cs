using System;
using System.Runtime.InteropServices;

namespace AskForInput
{
    public class Program
    {
        private static void Main(string[] args)
        {
            // Ex.7

            Console.WriteLine("Insert an int number");
            int i = int.Parse(Console.ReadLine());


            Console.WriteLine("Insert a real number");
            double f = float.Parse(Console.ReadLine());
            
        }
    }
}
