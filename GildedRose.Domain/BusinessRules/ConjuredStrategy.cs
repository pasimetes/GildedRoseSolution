using GildedRose.Domain.Entities;

namespace GildedRose.Domain.BusinessRules
{
    public class ConjuredStrategy : IStrategy
    {
        public void Apply<TItem>(TItem item) where TItem : Item
        {
            item.SellIn--;
            if (item.Quality > 0)
            {
                item.Quality -= (item.SellIn >= 0) ? 2 : 4;
                if (item.Quality < 0)
                    item.Quality = 0;
            }
        }
    }
}
