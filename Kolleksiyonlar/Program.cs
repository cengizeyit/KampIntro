using System;
using System.Collections.Generic;

namespace Kolleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {

            //arraylar (diziler) siz onu oluşturduğunuz sınırlarda çalışır yani 4 elemanlı bir arraya 5.elemanı ekleyemezsiniz.
            //arraylar de sabitlik vardır. 4 eleman oluşunca 5 yapamazsınız yaparsanız eskiyi kaybedersiniz.
            //string[] isimler = new string[] { "Engin", "Murat", "Kerem", "Halil" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);
            ////burada yeni bir isimler diye bellekte alan oluşur ve ekrana 4'e ilker yazar ancak 0.ıncı elemanı boş olarak ekrana getirir

            //isimler = new string[5];
            //isimler[4] = "İlker";
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[0]);

            ////array yerine kolleksyonları kullanırız ve genişleyebilir.

            List<string> isimler2 = new List<string> { "Engin", "Murat", "Kerem", "Halil" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);
        }
    }
}
