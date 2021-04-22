using GildedRose.Domain.Entities;
using GildedRose.Domain.Enums;
using NUnit.Framework;
using Shouldly;

namespace GildedRose.Tests.StrategyTests
{
    [TestFixture]
    public class ConjuredTests : TestBase
    {
        [Test]
        public void Should_DegrateTwiceAsNormal()
        {
            // Arrange
            int sellIn = 0;
            int quality = 6;
            var testItem = new Item { Name = "TestItem", ItemTypeId = (int)ItemTypeEnum.Conjured, Quality = quality, SellIn = sellIn };
            GildedRose.AddItem(testItem);

            // Act
            GildedRose.UpdateQuality(); // should substract quality by two
            GildedRose.UpdateQuality(); // here by 4

            // Assert
            testItem.Quality.ShouldBe(0);
            testItem.SellIn.ShouldBe(-2);
        }
    }
}
