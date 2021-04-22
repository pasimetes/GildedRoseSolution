using GildedRose.Domain.Entities;
using GildedRose.Domain.Enums;
using System.Collections.Generic;

namespace GildedRose.Extensions
{
    public static class ItemSeedExtensions
    {
        public static IList<Item> SeedData(this IList<Item> items)
        {
            items.Add(new Item { Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20, ItemTypeId = (int)ItemTypeEnum.AgedGetsWorse });
            
            items.Add(new Item { Name = "Aged Brie", SellIn = 2, Quality = 0, ItemTypeId = (int)ItemTypeEnum.AgedGetsBetter });
            items.Add(new Item { Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7, ItemTypeId = (int)ItemTypeEnum.AgedGetsWorse });
            items.Add(new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80, ItemTypeId = (int)ItemTypeEnum.Legendary });
            items.Add(new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = -1, Quality = 80, ItemTypeId = (int)ItemTypeEnum.Legendary });

            items.Add(new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 15, Quality = 20, ItemTypeId = (int)ItemTypeEnum.BackStage });
            items.Add(new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 10, Quality = 49, ItemTypeId = (int)ItemTypeEnum.BackStage });
            items.Add(new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 5, Quality = 49, ItemTypeId = (int)ItemTypeEnum.BackStage });

            items.Add(new Item { Name = "Conjured Mana Cake", SellIn = 3, Quality = 6, ItemTypeId = (int)ItemTypeEnum.Conjured });

            return items;
        }
    }
}
