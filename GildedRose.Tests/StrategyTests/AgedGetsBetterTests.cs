using GildedRose.Domain.Entities;
using GildedRose.Domain.Enums;
using NUnit.Framework;
using Shouldly;

namespace GildedRose.Tests.StrategyTests
{
    [TestFixture]
    public class AgedGetsBetterTests : TestBase
    {
        [Test]
        public void ShouldNot_ExceedQualityLimit()
        {
            // Arrange
            var sellIn = 20;
            var quality = 49;
            var testItem = new Item { Name = "TestItem", ItemTypeId = (int)ItemTypeEnum.AgedGetsBetter, Quality = quality, SellIn = sellIn };
            GildedRose.AddItem(testItem);

            // Act
            for (int i = 0; i < sellIn; i++)
            {
                GildedRose.UpdateQuality();
            }

            // Assert
            testItem.Quality.ShouldBeLessThanOrEqualTo(50);
            testItem.SellIn.ShouldBe(0);
        }
    }
}
