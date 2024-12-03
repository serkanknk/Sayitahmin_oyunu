using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sayitahmin_oyunu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Sayı Tahmin Oyunu";
            int sayi = 0, sayaç = 0, rastgele;

            Random rand = new Random();
            rastgele = rand.Next(1, 100);

            while (sayi != rastgele)
            {
                sayaç++;

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Bir sayı giriniz:");
                sayi = int.Parse(Console.ReadLine());

                if (sayi < rastgele)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Daha büyük bir sayı giriniz:");
                }
                else if (sayi > rastgele)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Daha küçük bir sayı giriniz:");
                }

            }
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("TEBRİKLER TAHMİNİNİZ DOĞRU");
            Console.WriteLine("TAHMİNİNİZ={0}", rastgele);
            Console.WriteLine("{0}.Hamlede Sonuca ulaştınız.", sayaç);


            Console.ReadLine();

        }
    }
}
