using System;
namespace DaireCizme
{
    class Program
    {
        public static void Main(string[] args)
        {
            Islemler islemler = new Islemler();

        Basla:
            Console.WriteLine("***Girilen yaricapa gore daire cizme***");
            Console.WriteLine("Cizilmesini istediginiz daire yaricapini girin");
            Console.WriteLine("****************");

            double yaricap = Convert.ToDouble(islemler.Kontrol(Console.ReadLine()));
            if (yaricap <= 0)
            {
                Console.WriteLine("Gecerli bir pozitif sayi giriniz");
                return;
                //new Daire(yaricap);
            }

            Daire daireCizim = new Daire();
            daireCizim.DaireCiz(yaricap);

            Console.WriteLine("Devam etmek icin [Enter] tuşuna basin");
            Console.ReadLine();
            goto Basla;
        }
    }
}