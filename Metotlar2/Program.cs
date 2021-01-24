using System;
using System.Linq;

namespace Metotlar2
{
    class Program
    {
        static void Main(string[] args)
        {
            Add();
            Add();
            Add();
            Add();
            Add();
            
            int result = Add2(20,30);
            Console.WriteLine(result);
            
            int result1 = Add3(20);
            Console.WriteLine(result1);

            int number1 = 20;
            int number2 = 100;
            var result2 = Add4(ref number1, number2);
            Console.WriteLine(result2);
            Console.WriteLine(number1);

            int number3 ;
            int number4 = 100;
            var result3 = Add5(out number3, number4);
            Console.WriteLine(result3);
            Console.WriteLine(number3);

            Console.WriteLine(Multiply(2,4));
            Console.WriteLine(Multiply(2,4,8));

            Console.WriteLine(Add6(2,3,4,5,6));


            Console.ReadLine();
        }
        static void Add ( ) 
        {
            Console.WriteLine("Added!");
        }
        
        static int Add2(int number1, int number2)
        {
            var result = number1 + number2;
            return result;
        }

        //Default Parametreli Metotlarla Çalışmak
        //Add3 ün 2. paremetresi verilmediğinden default değer olan 25 atanır. 2. paremetre verilseydi o değer işleme alınırdı.
        //birden fazla default değerleri verilebilir ancak onların metotların en sonunda olması gerekir
        static int Add3(int number1=25, int number2=25)
        {
            var result1 = number1 + number2;
            return result1;
        }

        //ref keyword ile çalışmak
        //methot içerisinde yer alan number1 değerinin ilk verilen number1 değeri yerine geçmesini sağlar. ref koymasak değer 20 alınacaktı.
        //değer tipi referans tip gibi gönderir
        static int Add4(ref int number1, int number2)
        {
            number1 = 30;
            return number1 + number2; ;
        }

        //out keyword ile çalışmak
        //ref ile out mantıken aynıdır. out ta number 3 e değer ataması yapmasakta olur, refte hata verir.
        static int Add5(out int number3, int number4)
        {
            number3 = 30;
            return number3 + number4; ;
        }


        //method overloading-- metotların aşırı yüklenmesi--her iki metotta da Multiply 
        //değişkenini yazdık paremetre sayısı farklı olduğu için sorun çıkmadı
        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }

        static int Multiply(int number1, int number2, int number3)
        {
            return number1 * number2 * number3;
        }


        //params keyword ile çalışmak. Dizide ki bütün sayıları toplar
        static int Add6(int number1, params int[] numbers) 
        {
            return number1 + numbers.Sum();
        }

    }
}
