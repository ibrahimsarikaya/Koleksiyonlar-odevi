using System;

namespace Soru3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir kelime Yazınız: ");
            char[] kelime = Console.ReadLine().ToCharArray();
            
            int j = 0;
            for (int i = 0; i<kelime.Length; i++)
            {

                if((kelime[i] == 'a') || (kelime[i] == 'e') || (kelime[i] == 'i') || (kelime[i] == 'o') || (kelime[i] == 'u'))
                {
                    j++;
                }
                
            }
            char[] sesliharf = new char[j];
            Console.WriteLine("Sesli Harf Sayısı: "+j);

            int p = 0;
            for (int i = 0; i < kelime.Length; i++)
            {

                if ((kelime[i] == 'a') || (kelime[i] == 'e') || (kelime[i] == 'i') || (kelime[i] == 'o') || (kelime[i] == 'u'))
                {
                    sesliharf[p] = kelime[i];
                    p++;
                }
              
            }
            Array.Sort(sesliharf);
            foreach (var harf in sesliharf)
            {
                Console.Write(harf + " ");
            }

        }
    }
}