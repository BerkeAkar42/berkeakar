using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VucutKitleEndeksiniHesaplayanProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // klavyeden vücut ağırlığını ve boyunu alarak vücut kitle endeksini hesaplayan program
            /*
            vke<18.5 -> Ekrana "Zayıf" Yazdırsın,
            18.5<=vke<24.9 -> "Ekrana" Yazdırsın,
            25<=vke<29.9 -> "Kilolu" Yazdırsın,
            30<=vke --> "Obez" Yazdırsın.
            */

            //Kullanıcıdan kilo verisini alır.
            Console.Write("Lütfen Kilonuzu Giriniz (Örn: 80): ");
            int kilo = Convert.ToInt32(Console.ReadLine());

            //Kullanıcıdan boy verisini alır.
            Console.Write("Lütfen Boyunuzu Giriniz (Örn: 1,80): ");
            double boy = Convert.ToDouble(Console.ReadLine());

            //Vücut kitle endeksini hesaplar.
            double vke = kilo / (boy * boy);

            //Vücut kitle endeksini kıyaslar.
            if (vke<18.5)
            {
                Console.WriteLine("Zayıf");
            }
            else if (18.5<= vke && vke<24.9)
            {
                Console.WriteLine("Normal Kilolu");
            }
            else if (25<= vke && vke<29.9)
            {
                Console.WriteLine("Kilolu");
            }
            else if (30<=vke)
            {
                Console.WriteLine("Obez");
            }
            Console.ReadLine();
        }
    }
}
