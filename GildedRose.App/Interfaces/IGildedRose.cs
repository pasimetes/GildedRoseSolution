using GildedRose.Domain.Entities;
using System.Collections.Generic;

namespace GildedRose.App.Interfaces
{
    public interface IGildedRose
    {
        void AddItem(Item item);

        void UpdateQuality();

        IEnumerable<Item> GetItems();
    }
}
