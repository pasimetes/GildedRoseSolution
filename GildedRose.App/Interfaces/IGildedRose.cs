using GildedRose.Domain.Entities;

namespace GildedRose.App.Interfaces
{
    public interface IGildedRose
    {
        void AddItem(Item item);

        void UpdateQuality();
    }
}
