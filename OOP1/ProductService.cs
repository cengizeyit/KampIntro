using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductService
    {
        //encapsulation ürünün detaylarını tek tek yazmak yerine 
        //product classındaki nesneyi kümülatif yollamış yolluyoruz.

        //void tanımı emir kipi gibi düşün emri ver ne yaptığına karışma 
        //void değer döndürmez geriye
        public void Add(Product product)//101 bellek yeri
        {
            Console.WriteLine(product.ProductName + " eklendi.");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");

        }





        //Programın içerisinde Topla değerine ihtiyacın var ise 
        //topla çağrılınca int tipinde bir değeri programın içerisinde 
        //kullanmak istediğinde void kullanılmaz 
        // fonksiyon olarak düşün geriye değer döndürür.
        //public int Topla(int sayi1, int sayi2)
        //{
        //    return sayi1 + sayi2;

        //}


        ////Programın içerisinde kullanmak istediğinde void kullanılmaz 
        //public void Topla2(int sayi1, int sayi2)
        //{
        //    Console.WriteLine(sayi1+sayi2);
        //}

        //public void BiseyYap(int sayi)
        //{
        //    sayi = 99;
        //}
    }
}
