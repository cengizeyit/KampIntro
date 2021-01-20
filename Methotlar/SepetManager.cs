using System;
using System.Collections.Generic;
using System.Text;

namespace Methotlar
{
    class SepetManager
    {

        public void Ekle(Product product)
        {
            Console.WriteLine("Tebrikler Sepete Eklendi : " + product.productName);
        }
        public void Ekle2(string urunAdi,string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Ekle2");
            Console.WriteLine("Tebrikler Sepete Eklendi : " + urunAdi);
        }
    }
}
