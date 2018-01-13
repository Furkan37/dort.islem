using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _8_Işlem_Turunu_Secme
{
    class Program
    {
        static void Main(string[] args)
        {
            float s1, s2, top, cık, car, bol;
            string secim;
        ust:
            Console.ResetColor();
            Console.Write("1. Sayıyı giriniz -> ");
            s1 = float.Parse(Console.ReadLine());
            Console.Write("2. Sayıyı giriniz -> ");
            s2 = float.Parse(Console.ReadLine());

            top = s1 + s2;
            cık = s1 - s2;
            bol = s1 / s2;
            car = s1 * s2;
            Console.Clear();

            Console.Write("1.Toplama\n2.Çıkarma\n3.Bölme\n4.Çarpma\nSeçiminiz -> ");
            secim = Console.ReadLine();
            switch (secim)
            {
                case "1":
                    Console.Write("{0}+{1} = {2}", s1, s2, top);
                    break;
                case "2":
                    Console.Write("{0}-{1} = {2}", s1, s2, cık);
                    break;
                case "3":
                    Console.Write("{0}/{1} = {2}", s1, s2, bol);
                    break;
                case "4":
                    Console.Write("{0}*{1} = {2}", s1, s2, car);
                    break;

                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Hatalı Seçim...\n");
                    goto ust;
                    
            }
            Console.ReadKey();
        }
    }
}
