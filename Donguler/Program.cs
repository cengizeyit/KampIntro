using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            //string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            //string kurs2 = "Programlamaya başlangıç için Temel Kurs";
            //string kurs3 = "Java Kursu";

            //array - diziler
            string[] kurslar = new string[]
            {
                "Yazılım Geliştirici Yetiştirme Kampı",
                "Programlamaya başlangıç için Temel Kurs" ,
                "Java Kursu",
                "Python",
                "Delphi"
            };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For each döngüsü");
            
            //foreach yapısı dizilere uygulanır ve 
            //dizi elemanlarının içini tek tek kolaylıkla dolaşmaya yarar
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa Sonu -footer");


        }
    }
}
