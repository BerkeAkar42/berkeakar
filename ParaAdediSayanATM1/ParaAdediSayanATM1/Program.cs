using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaAdediSayanATM1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* ATM makinesinde para vermek için bir program istenmektedir. ATM kasasına sadece 5, 10, 20, 50, 100 ve 200 TL'lik
            banknotlar yerleştirilmektedir. Makineden (işlem kolaylığı açısından) en az 100 TL ve en fazla 5000 TL para çekilmektedir.
            Makineden para çekilirken önce 4 adet 5 TL, 4 adet 10 TL ve 4 adet 20 TL para vermektedir. Paranın kalan kısmı önce büyük
            banknotlar kullanılarak vermektedir. Buna göre makineden çekilecek para adetlerini hesaplayıp ekrana uygun mesajı veren
            programın akış diyagramını oluşturunuz */

            int adet = 0;
            baslangic:

            Console.Write("Çekmek İstediğiniz Tutarı Giriniz (Not:Çekilen Tutar Min:100TL, Max:5000TL Olmalıdır): ");
            int x = Convert.ToInt32(Console.ReadLine());

            //Talep edilen miktarı kontrol ettik
            if (100 <= x && x <= 5000)
            {
                x -= 100;
                adet += 10;

            }
            else
            {
                Console.WriteLine("Lütfen 100 İla 5000 Arasında Bir Tutar Giriniz!");
                goto baslangic;

            }

            //(1) Para miktarına göre kontrol gerçekleştirdik
            if (x >= 20)
            {
                adet++;
                x -= 20;

                //(2) Para miktarına göre kontrol gerçekleştirdik
                if (x >= 20)
                {
                    adet++;
                    x -= 20;

                    if (x/200!=0)
                    {
                        int bolum1 = x / 200;
                        adet += bolum1;
                        x -= (bolum1 * 200);
                    }
                    else
                    {

                    }

                    if (x/100!=0)
                    {
                        int bolum2 = x / 100;
                        adet += bolum2;
                        x -= (bolum2 * 100);
                    }
                    else
                    {

                    }

                    if (x/50!=0)
                    {
                        int bolum3 = x / 50;
                        adet += bolum3;
                        x -= (bolum3 * 50);
                    }
                    else
                    {

                    }

                    if (x/20!=0)
                    {
                        int bolum4 = x / 20;
                        adet += bolum4;
                        x -= (bolum4 * 20);
                    }

                    else
                    {

                    }

                    if (x/10!=0)
                    {
                        int bolum5 = x / 10;
                        adet += bolum5;
                        x -= (bolum5 * 10);
                    }
                    else
                    {

                    }

                    if (x/5!=0)
                    {
                        int bolum6 = x / 5;
                        adet += bolum6;
                        x -= (bolum6 * 5);
                    }
                    else
                    {

                    }

                    Console.WriteLine("Çekilen Banknot Adedi= " + adet);
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Çekilen Banknot Adedi= " + adet);
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("Çekilen Banknot Adedi= " + adet);
                Console.ReadLine();
            }
        }
    }
}
