using GildedRose.Domain.Entities;
using GildedRose.Domain.Enums;
using NUnit.Framework;
using Shouldly;

namespace GildedRose.Tests.StrategyTests
{
    [TestFixture]
    public class NoStrategyTests : TestBase
    {
        [Test]
        public void Should_NotUpdateItem()
        {
            // Arrange
            int sellIn = 20;
            int quality = 5;
            var testItem = new Item { Name = "TestItem", ItemTypeId = (int)ItemTypeEnum.Legendary, Quality = quality, SellIn = sellIn };
            GildedRose.AddItem(testItem);

            // Act
            for (int i = 0; i < 31; i++)
            {
                GildedRose.UpdateQuality();
            }

            // Assert
            testItem.Quality.ShouldBe(quality);
            testItem.SellIn.ShouldBe(sellIn);
        }
    }
}
