using System;
using System.Collections;

namespace soru1 
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList asal = new ArrayList();
            ArrayList asalolmayan = new ArrayList();

            
            int asal1 = 0;

            for(int i=0; i<20; i++)
            {
                Aga:
                Console.WriteLine("Lütfen Pozitif Bir Sayı Giriniz: ");
                string sayi1 =Console.ReadLine();
                int sayi;
                bool sonuc = int.TryParse(sayi1, out sayi);
                if (sonuc && sayi > 0)
                {
                    int deger = int.Parse(sayi1);
                    if (deger == 2)
                        asal.Add(deger);
                    else
                    {
                        for (int j = 2; j < deger; j++)
                        {
                            if (deger % j == 0)
                            {
                                asal1 = 0;
                                break;
                            }
                            else     
                                asal1 = 1;
                        }
                        if (asal1 == 0)
                            asalolmayan.Add(deger);
                        else
                            asal.Add(deger);
                    }
                }
                else
                {
                    Console.WriteLine("Pozitif olmayan bir sayı girdiniz");
                    goto Aga;
                }
                    
            }



            Console.WriteLine("Asal Sayılar: ");
            asal.Sort();
            int asaltoplam = 0;
            foreach (int deger1 in asal)
            {
                Console.Write(deger1 + " ");
                asaltoplam += deger1;
            }
            Console.WriteLine("\nAsal olanların sayısı: " + asal.Count);
            Console.WriteLine("Asal Sayıların Toplamı: " + asaltoplam);

            Console.WriteLine("\nAsal Olmayan Sayılar: ");

            asalolmayan.Sort();
            int asalolmayantoplam = 0;
            foreach (int deger2 in asalolmayan)
            {
                Console.Write(deger2 + " ");
                asalolmayantoplam += deger2;
            }
            Console.WriteLine("\nAsal olmayanların sayısı: " + asalolmayan.Count);
            Console.WriteLine("Asal olmayan sayıların toplamı: " + asalolmayantoplam);
        }
    }
}