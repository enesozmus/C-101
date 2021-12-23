﻿using System;
namespace Chapter14
{
    class Program
    {
        static void Main(string[] args)
        {
            string demo = "Fare, çıktığı deliği bilir.";
            string demo_1 = "Otu çek köküne bak!";
            string demo_2 = "bilir!";

           

            // .Length
            Console.WriteLine(demo.Length);                                 // karakter sayısı


            // .ToUpper()                .ToLower()
            Console.WriteLine(demo.ToUpper());                              // bütün harfleri büyük yapar
            Console.WriteLine(demo.ToLower());                              // bütün harfleri büyük yapar


            // String.Contact(,"")
            Console.WriteLine(String.Concat(demo, " Artık"));               // Sonuna ekleme yapar.


            // String.Compare(,,,)        .CompareTo()
            Console.WriteLine(demo.CompareTo(demo_1));                      // -1,0,1   döndürür.   Karakter sayılarını karşılaştırır. ↓
                                                                            // demo > demo_1
            Console.WriteLine(String.Compare(demo, demo_1, false));         // true →   büyük küçük harf duyarsız    false →  büyük küçük harf duyarlı
            
            
            // .Contains()
            Console.WriteLine(demo.Contains(demo_2));                       // içinde "" var mu?        // False     
            Console.WriteLine(demo.EndsWith("bilir."));                     // "" ile bitiyor mu?       // True
            Console.WriteLine(demo.StartsWith("Fare,"));                    // "" ile başlıyor mu?      // True


            // .IndexOf()
            Console.WriteLine(demo.IndexOf("çıktığı"));                     // bu string'de ilk "çıktığı" kaçıncı karakterde başlıyor?
                                                                            // ç karakterinin index'ini verir.
                                                                            // aradığını bulamazsa -1 döndürür.
            Console.WriteLine(demo.LastIndexOf("r"));                       // aramaya sondan başlar bulunca karakter sayısını baştan sayar.
                                                                            // index sayısını verir.

            // .Insert(, "")
            Console.WriteLine(demo.Insert(0, "Derler ki, "));               // 0, cümlenin başına "" ifadesini ekler.


            // .PadLeft(, '')              .PadRight(, '')
            Console.WriteLine(demo + demo_1);
            Console.WriteLine(demo_1.Length);
            Console.WriteLine(demo + demo_1.PadLeft(25, 'a'));              // demo_1 →  kendisi 19
                                                                            // soluna ekleme yaparak 25'e tamamlıyoruz
            Console.WriteLine(demo + demo_1.PadRight(25, 'a'));             // sağına ekleme yaparak 25'e tamamlıyoruz


            // .Remove()(,)            
            Console.WriteLine(demo.Remove(2));                               // birinci index'ten sonrasını sil.
            Console.WriteLine(demo.Remove(5,15));                            // beşinci index'ten onbeşinci index'e kadar sil.


            // .Replace("", "")
            Console.WriteLine(demo.Replace(" ","_"));                        // " ", yerine " " bunu kullan.
            Console.WriteLine(demo.Replace("Fare","Rat"));


            // .Split('')[]
            Console.WriteLine(demo.Split(' ')[3]);                          // boşluklara göre ayır, bir dizi gibi düşün
                                                                            // ve üçüncü index'i getir
            

            // .Substring()(,)
            Console.WriteLine(demo_1.Substring(8));                         // sekizinci(dahil) index'ten başlayarak getir.
            Console.WriteLine(demo_1.Substring(8,3));                       // sekizinci(dahil) index'ten başlayarak üç index getir.
        }
    }
    
}