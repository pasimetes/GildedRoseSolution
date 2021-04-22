using GildedRose.App.Interfaces;
using GildedRose.Domain.Entities;
using GildedRose.Extensions;
using System;
using System.Collections.Generic;

namespace GildedRose.App
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IGildedRose gildedRose;
            IList<Item> items;

            items = new List<Item>().SeedData();
            gildedRose = new GildedRose(items);

            Console.WriteLine("OMGHAI!");
            for (var i = 0; i < 31; i++)
            {
                Console.WriteLine("-------- day " + i + " --------");
                Console.WriteLine("name, sellIn, quality");
                for (var j = 0; j < items.Count; j++)
                {
                    Console.WriteLine($"{items[j].Name}, {items[j].SellIn}, {items[j].Quality}");
                }
                Console.WriteLine("");
                gildedRose.UpdateQuality();
            }
            Console.ReadLine();
        }
    }
}
