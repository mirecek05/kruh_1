using System;

namespace KRUH_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double vyber;
            double polomer;
            double prumer;
            double obsah;
            double obvod;
            string str_obsah;
            string str_obvod;


            while (true)
            {
                Console.Clear();
                Console.WriteLine("KRUH");
                Console.WriteLine("------");
                Console.WriteLine("1- zadání poloměru");
                Console.WriteLine("2- zadání průměru");
                double.TryParse(Console.ReadLine(), out vyber);
                if (vyber is 1)
                {
                    Console.WriteLine("Zadej poloměr");
                    double.TryParse(Console.ReadLine(), out polomer);               
                    obsah = 3.14 * polomer * polomer;
                    obvod = 2 * 3.14 * polomer;
                    str_obsah = obsah.ToString();
                    str_obvod = obvod.ToString();
                    Console.WriteLine("Obsah je " + str_obsah);
                    Console.WriteLine("Obvod je " + str_obvod);
                }

                if (vyber is 2)
                {
                    Console.WriteLine("Zadej průměr");
                    double.TryParse(Console.ReadLine(), out prumer);
                    obsah = 3.14 * ((prumer * prumer) / 4); ;
                    obvod = 3.14 * prumer;
                    str_obsah = obsah.ToString();
                    str_obvod = obvod.ToString();
                    Console.WriteLine("Obsah je " + str_obsah);
                    Console.WriteLine("Obvod je " + str_obvod);
                }
                Console.ReadLine();
            }
               
                  
               
            
            
            



            
            


        }
    }
}
