using System;
namespace DaireCizme
{
    class Islemler
    {
        internal int Kontrol(string yaricap)
        {
            try
            {
                int yariCap = int.Parse(yaricap);
                if (yariCap < 1)
                {
                    throw new Exception();
                }
                return yariCap;
            }
            catch (FormatException)
            {
                Hata("Lutfen pozitif bir tam sayi giriniz.");
            }
            catch (Exception)
            {
                Hata("Lutfen pozitif bir tam sayi giriniz.");
            }
            return 0;
        }

        private void Hata(string bld)
        {
            Console.WriteLine(bld);
            System.Threading.Thread.Sleep(2000);
        }
    }
}