using System;

namespace ArrayHW
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] girilensayilar = new int[20];
            
            for (int i = 0; i < 20; i++)
            {
                girilensayilar[i] = Convert.ToInt32(Console.ReadLine());
            }

            Array.Sort(girilensayilar);

            int kucukortalama = 0;
            int buyukortalama = 0;
            Console.WriteLine("En küçük 3 sayı: ");

            for (int i = 0; i < 3; i++)
            {
                buyukortalama += girilensayilar[i];
                
                Console.Write(girilensayilar[i]+" ");
            }

            Console.WriteLine("\nEn küçük 3 sayının toplamı = "+kucukortalama);
            Console.WriteLine("En küçük 3 sayının ortalaması = " + kucukortalama/3);
            Console.WriteLine("En büyük 3 sayı: ");


            for (int i =19; i>16; i--)
            {
                buyukortalama += girilensayilar[i];
                Console.Write(girilensayilar[i] + " ");
            }
            Console.WriteLine("\nEn büyük 3 sayının toplamı = " + buyukortalama);
            Console.WriteLine("En büyük 3 sayının ortalaması = " + buyukortalama/3);
            int toplamortalama = (buyukortalama + kucukortalama) / 3;
            Console.WriteLine("Ortalamaların toplamları = " + toplamortalama);
        }
    }
}