using GildedRose.App.Interfaces;
using GildedRose.App.Mappings;
using GildedRose.Domain.Entities;
using System.Collections.Generic;

namespace GildedRose.App
{
    public class GildedRose : IGildedRose
    {
        private IList<Item> _items;

        public void AddItem(Item item)
        {
            if (_items == null)
                _items = new List<Item>() { item };
            else
                _items.Add(item);
        }

        public IEnumerable<Item> GetItems()
        {
            return _items;
        }

        public void UpdateQuality()
        {
            foreach (var item in _items)
            {
                var strategy = ItemTypeStrategyMap.GetUpdateStrategyByType(item.ItemTypeId);
                strategy.Apply(item);
            }
        }
    }
}
