using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //metotları yazmak için classlar kullanılır
        //naming convention - isimlendirme kuralı---metotlarda, metot adı büyük harfle başlar
        //syntax - yazım şekilleri
        //python'daki def komutu gibi

        public void Ekle(Urun urun)
        //sepete ekle derken neyi eklememiz gerektiğini belirtmemiz lazım. Ekle() içerisine paremetreleti yazarız
        {
            //Console.WriteLine( "Sepete Eklendi");
            Console.WriteLine("Tebrikler. Sepete Eklendi : " + urun.Adi);
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat)    //class yerine bu paremetleri kullanmak hata verebilir.
            //çünkü buradaki parametrelerden birini program.cs de girmezsek program hata verir ancak class da bu durum yaşanmaz.
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi : " + urunAdi);
        }
    }
}
