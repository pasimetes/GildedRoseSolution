using GildedRose.Domain.Entities;

namespace GildedRose.Domain.BusinessRules
{
    public interface IStrategy
    {
        public void Apply(Item item);
    }
}
