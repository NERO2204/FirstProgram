using System;
using System.Collections;
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
            #region deklaráció
            int num1 = 2;
            int num2 = 23;
            num1 = 21;
            int num3 = num1 + num2;
            string text = "NERO";
            char alphabet = 'N';
            double sum = 32.3;

            //Console.WriteLine("Összeadás eredménye: "+(num3));
            //Console.WriteLine("  Készitette: " + text);
            //Console.WriteLine("név: {0} összeg: {1} betű: {2},",text,sum,alphabet);
            //Console.WriteLine($"");
            //Console.WriteLine("Kérlek irj be egy egész számot");
            //num1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Kérlek irj be egy egész számot");
            //int num4 = int.Parse(Console.ReadLine());
            //Console.WriteLine("a két szám szorzata {0}",num1*num4);
            #endregion
            //if (num1 > num4)
            //{
            //    Console.WriteLine($"Az első szám {num1} a nagyobb");
            //}
            //else if (num4 > num1)
            //{
            //    Console.WriteLine($"A második szám {num4} a nagyobb");
            //}
            //else
            //{
            //    Console.WriteLine("A két szám egyenlő");
            //}
            //if (num1 == 12)
            //{
            //    Console.WriteLine("Ezt a számotvártuk");
            //}
            //else
            //{
            //    Console.WriteLine("Nem 12 az első szám");
            //}
            //if (num4 >= 2 && num4 <= 24)
            //{
            //    Console.WriteLine("A második beirt szám 2 és 24 közé esik");
            //}
            const double PI = 3.14;
            string inputData = null;
            Console.WriteLine(PI);
            sum = num1;//inplicit tipuskonverzio.
            num1 = (int)sum;
            Console.WriteLine("A sum egész része: " + num1);
            num1++;//postfix inkrementáció
            Console.WriteLine(num1);
            ++num1;//pefix
            num1--;//postfix dekrementáció
            --num1;//prefix dekrementáció
            num1 -= 12;
            num1 -= 2;
            num1 *= 3;
            num1 /= 2;
            string even;
            Console.WriteLine($"A num1 értéke:{num1}");
            if (num1 % 2 == 0)
            {
                even = "Páros";
            }
            else
            { even = "Páratlan"; }
            Console.WriteLine(even);
            //trejális operátor
            even = num1 % 2 == 0 ? "Páros" : "Nem páros";
            Console.WriteLine(even);
            dynamic x = 12;
            x++;
            Console.WriteLine("Az x értéke: "+x);
            x = "szöveg";

           
          
            //CTRL k C kommentel
            //CTRL K u visszavinja a kommentet
            

           






        }
    }
}
