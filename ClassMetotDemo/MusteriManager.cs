using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Eklendi : " + musteri.Adi + " " + musteri.Soyadi);
        }

        public void Silme(Musteri musteri)
        {
            Console.WriteLine("Silindi : " + musteri.Adi + " " + musteri.Soyadi);
        }

        public void Listele(Musteri musteri)
        {
            Console.WriteLine(musteri.Id + " " + musteri.Adi + " " + musteri.Soyadi);
        }

    }
}
