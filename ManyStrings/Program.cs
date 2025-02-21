using System;
using System.Runtime.CompilerServices;

namespace ManyStrings
{
    public class Program
    {
        private static void Main(string[] args)
        {
            // Ex.6*

            double xx = 1.23456;
            int ii = 19;


            // Ex.4

            string s1 = "Olá... \n...Adeus!";
            string s2 = "Símbolo \u03A9!";
            string s3 = "Tab \t !";

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);


            // Ex.5

            sbyte x = 10;
            sbyte y = 36;
            string si = $"{x} plus {y} is equal to {x + y}.";
            string si1 = $"O valor de x é {x}";
            string sc = "9" + x;


            Console.WriteLine(si);
            Console.WriteLine(si1);
            Console.WriteLine(sc);


            // Ex.6*

            string xxf = $"xx = {xx:f2}";
            string xxp = $"xx = {xx:p1}";

            string iihx = $"ii = {ii:x}";
            string iim = $"ii = {ii:c}";


            Console.WriteLine(xxf);
            Console.WriteLine(xxp);

            Console.WriteLine(iihx);
            Console.WriteLine(iim);
        }
    }
}
