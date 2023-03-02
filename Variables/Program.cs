using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int sayi = 5;
            Console.WriteLine(sayi);
            Console.WriteLine(sayi+2);
            Console.WriteLine(sayi*sayi);
            Console.WriteLine(sayi-5);

            

            //4 farklı yerde bu değişken kullanıldı ve program çalıştığında ilgili ifadeleri göstericek.
            //Dolayısıyla değişkenler bu işlemlerin o anki bellek görüntüsüne bağlı olarak yürütülmesini sağlar. 
            //Yani bellekte değişken için bir yer ayrılıyor ve bu alana sürekli veriler kaydedilip, ilgili verilerin tekrar ilgili gözden okunması sağlanabiliyor.

            Console.ReadKey();

        }

        private static void DegiskenBasitOrnek()
        {
            //TİP-------
            //Bir değişken tanımı yağtığımız zaman bu değişken tanımına bağlı olarak bi takım ifadeler kullanırız.

            //int sayi1;
            //double pi = 3.14;
            //char secim = 'e';
            //string isim = "zafer";
            //bool dogruMu = false;


            //ATAMA------


            //Ex1

            string isim = "Ahmet";

            //doğrudan tanımlama noktasındada verilebilir bir değişiklik olmaz.
            // string isim = "Ahmet";

            Console.WriteLine("Merhaba " + isim + ".");

            //doğrudan tanımlama noktasındada verilebilir bir değişiklik olmaz.
            // string isim = "Ahmet";


            //Ex2
            string name = "Mehmet";
            Console.WriteLine("Merhaba " + name + ".");
            Console.WriteLine("Merhaba Sayın " + name + ".");

            // bu örnekte ilgili değişkenin iki defa kullanıldığını ve iki farklı değer üretmiş olduğunu görüyoruz.


            //Ex3

            string ad = "Ali";
            Console.WriteLine("Merhaba " + ad + ".");
            ad = "Burak";
            Console.WriteLine("Merhaba Sayın " + ad + ".");


            // ilk durumda değişken için bize bir kutu ayrılır, ve içine ali değeri atanır.
            // daha sonra ad değişkenine bir atama yapılıyor, değeri değiştiriliyor ve alinin yerine burak atanıyor.
            // dolayısıyla o an ki kutunun değeri neyse programın ona göre bir çıktı üretmesini bekleriz. 
        }
    }
}
