using GildedRose.Domain.Entities;
using GildedRose.Domain.Enums;
using NUnit.Framework;
using Shouldly;

namespace GildedRose.Tests.StrategyTests
{
    [TestFixture]
    public class AgedGetsWorseTests : TestBase
    {
        [Test]
        public void Should_CalculateProperly_When_QualityIsAlmostZero()
        {
            // Arrange
            int sellIn = 30;
            int quality = 1;
            var testItem = new Item { Name = "TestItem", ItemTypeId = (int)ItemTypeEnum.AgedGetsWorse, Quality = quality, SellIn = sellIn };
            GildedRose.AddItem(testItem);

            // Act
            for (int i = 0; i < 31; i++)
            {
                GildedRose.UpdateQuality();
            }

            // Assert
            testItem.Quality.ShouldBeGreaterThanOrEqualTo(0);
            testItem.SellIn.ShouldBe(-1);
        }
    }
}
