using GildedRose.Extensions;
using System;

namespace GildedRose.App
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var gildedRose = new GildedRose().SeedData();

            Console.WriteLine("OMGHAI!");
            for (var i = 0; i < 31; i++)
            {
                Console.WriteLine("-------- day " + i + " --------");
                Console.WriteLine("name, sellIn, quality");
                foreach (var item in gildedRose.GetItems())
                {
                    Console.WriteLine($"{item.Name}, {item.SellIn}, {item.Quality}");
                }
                Console.WriteLine("");
                gildedRose.UpdateQuality();
            }
            Console.ReadLine();
        }
    }
}
