using System;
namespace DaireCizme
{

    class Daire
    {
        public void DaireCiz(double yaricap)
        {
            int daireCapi = (int)Math.Ceiling(2 * yaricap);

            for (int i = 0; i <= daireCapi; i++)
            {
                for (int j = 0; j <= daireCapi; j++)
                {
                    if (MesafeMerkeze(i, j, yaricap) <= yaricap)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }

            double MesafeMerkeze(int x, int y, double yaricap)
            {
                double merkezeUzaklik = Math.Sqrt(Math.Pow(x - yaricap, 2) + Math.Pow(y - yaricap, 2));
                return merkezeUzaklik;

            }
        }



    }
}