using System;

namespace Kampintro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güveniği
            //Do not repeat yourself - kendinin tekrarlama
            //kategori etiketi aslında bir değer tutucudur, aliastır.

            //string kategoriEtiketi = "Kategori";
            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true ;     //bool veri tipi kontrol işlemlerinde kull. true ve false değerleri atanır.
                                                   //gerçek hayatta true kısmı bir veri kaynağından gelir. Fonsiyona bağlı olur.
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi Butonu");
            }

            //tab tab
            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonunu Göster");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonunu Göster");
            }


            Console.WriteLine(kategoriEtiketi);

        }
    }
}
