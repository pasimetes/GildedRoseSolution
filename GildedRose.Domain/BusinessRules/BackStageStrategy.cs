using GildedRose.Domain.Entities;

namespace GildedRose.Domain.BusinessRules
{
    public class BackStageStrategy : IStrategy
    {
        public void Apply<TItem>(TItem item)
            where TItem : Item
        {
            item.SellIn--;

            if (item.SellIn < 0)
            {
                item.Quality = 0;
                return;
            }

            if (item.Quality < 50)
                item.Quality++;

            if (item.SellIn < 10 && item.Quality < 50)
                item.Quality++;

            if (item.SellIn < 5 && item.Quality < 50)
                item.Quality++;

            if (item.Quality > 50)
                item.Quality = 50;
        }
    }
}
