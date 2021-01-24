using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Adi = "Elçin";
            musteri1.Soyadi = "Karapinar";
            musteri1.TcNo = "111111111111";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Adi = "Fatih Bereket";
            musteri2.Soyadi = "İnan";
            musteri2.TcNo = "2222222222222";

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Silme(musteri2);

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };
            foreach (var musteri in musteriler)
            {
                musteriManager.Listele(musteri);
            }
        }
    }
}
