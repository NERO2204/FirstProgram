using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        public static void WriteOut(int[] numArray3)
        {
            for (int i = 0; i < numArray3.Length; i++)
            {
                Console.Write($" {numArray3[i]} ");
            }
            Console.WriteLine();
            //foreach (var item in numArray3)
            //{
            //    Console.WriteLine(item);
            //}
        }
        public static int minSearch(int[] input)
        {
            int min = 0;

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] < input[min])
                {
                    min = i;
                }
            }

            return min;
        }
        public static int maxSearch(int[] input)
        {
            int max = 0;

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] < input[max])
                {
                    max = i;
                }
            }

            return max;
        }
        static void Main(string[] args)
        {
           
           
            int[] numarray = {2,4,8,12,11,32};
            int[] numArray2 = new int[3];
            numArray2[0] = 1;
            numArray2[1] = 2;
            numArray2[2] = 3;
           
            int[] numArray3 = new int[15];
            //véletlen 3-50 között
            Random rnd = new Random();
            for (int i = 0; i < numArray3.Length; i++)
            {
                numArray3[i] = rnd.Next(3,51);
                
            }

            string menu;
          
            Console.WriteLine("Ird be a választott menü számát");
       
            



            menu = Console.ReadLine();

            Console.WriteLine("1.kiir");
            Console.WriteLine("2.keresett sszam");
            Console.WriteLine("3.linear search");
            Console.WriteLine("minmax");




            switch (menu)
            {


                case "1": Console.WriteLine("Az 1 est választottad");

                    WriteOut(numArray3);
                    Console.ReadKey();
                    break;

                case "2":
                    Console.WriteLine("Az 2 est választottad");
                    WriteOut(numArray3);
                    int sum = 0;
                    for (int i = 0; i < numArray3.Length; i++)
                    {
                        sum += numArray3[i];

                    }


                    Console.WriteLine(sum);
                    Console.WriteLine($"Összeg: {sum}");
                    Console.ReadKey();
                    break;


                case "3":
                    Console.WriteLine("Az 3 est választottad");
                    WriteOut(numArray3);
                    Console.WriteLine("Linearis keresés");
                    Console.WriteLine("Kérem a keresett számot");
                    int targetNum = int.Parse(Console.ReadLine());
                    int j = 0;
                    while (j < numArray3.Length && numArray3[j] != targetNum)
                    {

                        j++;


                    }
                    if (j < numArray3.Length)
                    {
                        Console.WriteLine($"A keresett {targetNum} szám ");
                    }
                    else
                    {
                        Console.WriteLine("nincs benne");
                    }


                    Console.ReadKey();
                    break;
                case "4":
                    Console.WriteLine("Az 4 est választottad");
                    Console.WriteLine("Megszámlálás");
                    WriteOut(numArray3);
                    Console.WriteLine();
                    int count = 0;
                    for (int i = 0; i < numArray3.Length; i++)
                    {
                        if (numArray3[i] % 3 == 0)
                        {
                            count++;
                        }
                    }
                    Console.WriteLine($"3 oszthatók:  {count}");
                    Console.ReadKey();
                    break;
                case "6":
                    WriteOut(numArray3);
                  
                    
                   


                    Console.WriteLine($" legkisebb elem: {num}");
                    
                    break;
                default :
                    Console.WriteLine("Nem jo egyet se választottál");
                    Console.ReadKey();
                    break;




            }





        }
    }
}
