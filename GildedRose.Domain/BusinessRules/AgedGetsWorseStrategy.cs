using GildedRose.Domain.Entities;

namespace GildedRose.Domain.BusinessRules
{
    public class AgedGetsWorseStrategy : IStrategy
    {
        public void Apply(Item item)
        {
            item.SellIn--;

            if (item.Quality > 0)
                item.Quality -= (item.SellIn >= 0) ? 1 : 2;

            if (item.Quality < 0)
                item.Quality = 0;
        }
    }
}
