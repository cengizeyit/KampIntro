using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();//101 bellek adresi yollanır
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product
            {
                Id = 2,
                CategoryId = 5,
                ProductName = "Kalem",
                UnitPrice = 35,
                UnitsInStock = 5
            };

            //PascalCase    //camelCase
            //case sensitive
            ProductService productService = new ProductService();
            productService.Add(product1);
            Console.WriteLine(product1.ProductName);



            //productService.Topla2(3, 6);

            //int toplamaSonucu = productService.Topla(3, 6);

            //Console.WriteLine(toplamaSonucu * 2);

            //int sayi = 100;
            //productService.BiseyYap(sayi);
            //Console.WriteLine(sayi); //100 kalır bağlantı kopar


            //int, bool, double .... değer tipler - atamalar tamamen değer üzerinden olur ve bütün bağlantı kopar
            //diziler, class, abstract class, interface ---- referans tiplerdir. atamalar referansın bellekteki adresiyle yapılır. - 
            //ref out ders kaynaklarında youtube videosunu izle 3 gün deki (izledim)
            //https://www.youtube.com/watch?v=rSsrJu5dWec&list=PLqG356ExoxZU5keiJwuHDpXqULLffwRYD&index=25



        }
    }
}

