using System;

namespace Repainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input

            int safetyNylon = int.Parse(Console.ReadLine()) + 2;
            int paint = int.Parse(Console.ReadLine());
            double paintInLitersWhithBonus = paint + (paint * 0.1);
            int thinner = int.Parse(Console.ReadLine()); 
            int hours = int.Parse(Console.ReadLine());

            //calculate

            double Nylonprice = safetyNylon * 1.50;
            double paintPrice = paintInLitersWhithBonus * 14.50;
            double thinnerPrice = thinner * 5.0;

            double total = Nylonprice + paintPrice + thinnerPrice + 0.40;
            double totalWorkersPrice = total * 0.3 * 8;

            //output

            Console.WriteLine(total + totalWorkersPrice);




        }
    }
}
