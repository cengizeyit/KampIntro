using System;

namespace Methotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.productName = "Elma";
            product1.productPrice = 15;
            product1.productDescription = "Amasya Elması";


            Product product2 = new Product();
            product2.productName = "Karpuz";
            product2.productPrice = 80;
            product2.productDescription = "Diyarbakır Karpuzu";

            Product[] products = new Product[] { product1, product2 };

            foreach (var product in products)
            {
                Console.WriteLine(product.productName);
                Console.WriteLine(product.productPrice);
                Console.WriteLine(product.productDescription);
                Console.WriteLine("-------------------------------------");
            }

            Console.WriteLine("------------Metodlar-----------------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(product1);
            sepetManager.Ekle(product2);

            sepetManager.Ekle2("Armut", "Yeşil Armut", 12,10);
            sepetManager.Ekle2("Elma", "Yeşil Elma", 14,9);
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 16,99);

        }
    }
}
