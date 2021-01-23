using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya Başlangıç İçin Temel Kurs";
            string kurs3 = "Java";
            string kurs4 = "Python";
            string kurs5 = "C#";

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            Console.WriteLine(kurs4);
            Console.WriteLine(kurs5);
            //statik şekilde yazınca kursları göstermek için ayrı ayrı console.writeline kullanmamız gerekecekti,
            //bunun yerine dinamik olması için liste de tanımlayıp döngüleri kullandık

            //array - dizi
            //string array

            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", 
                "Programlamaya Başlangıç İçin Temel Kurs", "Java", "Python", "C#" };            
            
            //kursları tek tek tanımlamak yerine bir listede (array'de) tuttuk

            for (int i = 0; i<kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For Bitti");

            //diğer bir döngü yöntemi ise foreach' tur.
            //foreach: dizi temelli yapıları tek tek dönmeye yarıyor

            foreach (string kurs in kurslar)
            //burada ki kurs allias 'tır yani takma isim. kurs yerine başka birşey de yazılabilirdi.
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa Sonu - footer");

        }
    }
}
