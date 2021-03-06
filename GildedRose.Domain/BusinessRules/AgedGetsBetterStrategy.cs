using GildedRose.Domain.Entities;

namespace GildedRose.Domain.BusinessRules
{
    public class AgedGetsBetterStrategy : IStrategy
    {
        public void Apply(Item item)
        {
            item.SellIn--;

            if (item.Quality < 50)
                item.Quality += (item.SellIn >= 0) ? 1 : 2;

            if (item.Quality > 50)
                item.Quality = 50;
        }
    }
}
