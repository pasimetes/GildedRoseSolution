using GildedRose.Domain.Entities;

namespace GildedRose.Domain.BusinessRules
{
    public interface IStrategy
    {
        public void Apply<TItem>(TItem item) where TItem : Item;
    }
}
