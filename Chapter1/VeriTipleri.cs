using System;

namespace console_programlama
{

    class Program
    {
        public static void Main(string[]args)
        {
            Console.WriteLine("Hello, World!");                      // " " İçindeki metni console'a yazdırır.
            Console.WriteLine("İsminizi Giriniz:");
            string name= Console.ReadLine();                        // name değişkenini console'a yazılan bilgiden okur
                                                                    // ve okuduğunu name değişkenine atar 
            Console.WriteLine("soyadınızı giriniz:");
            string surname= Console.ReadLine();                     // surname değişkenini console'a yazılan bilgiden okur
                                                                    // ve okuduğunu surname değişkenine atar
            Console.WriteLine("merhaba " + name + " " + surname);   // console'da aldığı bilgileri yandaki şekilde bir kez daha console'a yazdırır


// C# dilinde iki tür veri tipi mevcuttur.Bunlar değer ve referans tipleridir.
// Değer tipleri; veriyi taşıyan ve taşıdığı veriye göre bellek üzerinde yer dolduran değişken türleridir.
// Referans türleri ise, bellek bölgesinde veri yerine verinin bellekteki adresini tutarlar ve o adresin gösterdiği yerde de veri tutulur.
// Değer tipleri:  "int", "long", "float", "double", "decimal", "char", "bool", "byte", "short", "struct", "enum"
// Referans tipleri:  "string", "object", "class", "interface", "array", "delegate", "pointer"

            byte a = 5;                         // 1 byte yer kaplar.        0 ile 255 arasındaki değerleri alabilir.
            sbyte b = 6;                        // 1 byte yer kaplar.        -128 ile 127 arasındaki değerleri alabilir.

            short c = 7;                        // 2 byte yer kaplar.       -32768 ile 32767 arasındaki değerleri alabilir.
            ushort d = 8;                       // 2 byte yer kaplar.       0 ile 65365 arasındaki değerleri alabilir.


            // Integer
            Int16 ee = 1;                       // 2 byte yer kaplar.
            int ff = 2;                         // 4 byte yer kaplar.       -2.147.483.648 ile 2.147.483.647 arasındaki değerleri alabilir.
            Int32 gg = 3;                       // 4 byte yer kaplar.
            Int64 hh = 4;                       // 8 byte yer kaplar.       int'ten daha geniş.
             

            // Reel Sayılar
            float degisken1 = 9;                // 4 byte yer kaplar.
            double degisken2 = 10;              // 8 byte yer kaplar.
            decimal degisken3 = 11;             // 16 byte yer kaplar.


            //
            char degisken4 = 'A';               // 2 byte yer kaplar.       tek bir karakteri tutar
            

            //
            bool b1 = true;
            bool b2 = false;


            //
            object o1 = 'X';                    // char.
            object o2 = "x";
            object o3 = 4;
            object o4 = 4.3;

            // string

            string st1 = "";
            string st2 = null;
            string st3 = string.Empty;
            st3 = "Enes Ozmus";                 // st3 değişkenine yeni atma yapıldı.

            string degisken5 = "Enes";          // sınırsızdır.
            string degisken6 = "Ozmus";
            string tamIsim = degisken5 + " " + degisken6;

            // Dönüştürme

            string degisken7 = "10";
            int degisken8 = 99;
            string yeniDeger = degisken7 + degisken8.ToString();        //1099  yan yana gelme durumu.
            Console.WriteLine(yeniDeger);

            // Dönüştürme
            int degisken9 = degisken8 + Convert.ToInt32(degisken7);
            Console.WriteLine(degisken9);                               // 109 bildiğimiz toplama durumu.

            int degisken10 = degisken8 + int.Parse(degisken7);          // 109      int.Parse, içinde string olmalı
            Console.WriteLine(degisken10);


            // Tarih ve Saat
            DateTime dt = DateTime.Now;
            string monthYear0 = DateTime.Now.ToString("dd.MM.yyyy"); // günü, ayı ve yılı aralarına nokta koyarak getir.
            Console.WriteLine(monthYear0);                           // 17.12.2021


            string monthYear1 = DateTime.Now.ToString("HH:mm");      // saati ve dakikayı aralarına : koyarak getir.
            Console.WriteLine(monthYear1);                           // 17:35                                                    
        }
    }
}