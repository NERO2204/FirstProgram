using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 2;
            int num2 = 23;
            num1 = 21;
            int num3 = num1 + num2;
            string text = "NERO";
            char alphabet = 'N';
            double sum =32.3;

            Console.WriteLine("Összeadás eredménye: "+(num3));
            Console.WriteLine("  Készitette: " + text);
            Console.WriteLine("név: {0} összeg: {1} betű: {2},",text,sum,alphabet);
            Console.WriteLine($"");
            Console.WriteLine("Kérlek irj be egy egész számot");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Kérlek irj be egy egész számot");
            int num4 = int.Parse(Console.ReadLine());
            Console.WriteLine("a két szám szorzata {0}",num1*num4);






        }
    }
}
