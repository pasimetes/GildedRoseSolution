using GildedRose.Domain.Entities;

namespace GildedRose.Domain.BusinessRules
{
    public class NoStrategy : IStrategy
    {
        public void Apply<TItem>(TItem item)
            where TItem : Item
        {
        }
    }
}
