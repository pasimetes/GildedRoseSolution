using GildedRose.Domain.Entities;
using GildedRose.Domain.Enums;
using NUnit.Framework;
using Shouldly;

namespace GildedRose.Tests.StrategyTests
{
    [TestFixture]
    public class BackStageTests : TestBase
    {
        [Test]
        public void Should_SetQualityToZero_When_DateIsPassed()
        {
            // Arrange
            int sellIn = 0;
            int quality = 50;
            var testItem = new Item { Name = "TestItem", ItemTypeId = (int)ItemTypeEnum.BackStage, Quality = quality, SellIn = sellIn };
            GildedRose.AddItem(testItem);

            // Act
            GildedRose.UpdateQuality();

            // Assert
            testItem.Quality.ShouldBe(0);
            testItem.SellIn.ShouldBe(-1);
        }

        [Test]
        public void Should_IncreaseQualityByTwo_When_LessThanTenDaysRemaining()
        {
            // Arrange
            int sellIn = 9;
            int quality = 48;
            var testItem = new Item { Name = "TestItem", ItemTypeId = (int)ItemTypeEnum.BackStage, Quality = quality, SellIn = sellIn };
            GildedRose.AddItem(testItem);

            // Act
            GildedRose.UpdateQuality();

            // Assert
            testItem.Quality.ShouldBe(50);
            testItem.SellIn.ShouldBe(8);
        }

        [Test]
        public void Should_IncreaseQualityByThree_When_LessThanFiveDaysRemaining()
        {
            // Arrange
            int sellIn = 4;
            int quality = 47;
            var testItem = new Item { Name = "TestItem", ItemTypeId = (int)ItemTypeEnum.BackStage, Quality = quality, SellIn = sellIn };
            GildedRose.AddItem(testItem);

            // Act
            GildedRose.UpdateQuality();

            // Assert
            testItem.Quality.ShouldBe(50);
            testItem.SellIn.ShouldBe(3);
        }

        [Test]
        public void ShouldNot_ExceedQualityLimit()
        {
            // Arrange
            int sellIn = 4;
            int quality = 49;
            var testItem = new Item { Name = "TestItem", ItemTypeId = (int)ItemTypeEnum.BackStage, Quality = quality, SellIn = sellIn };
            GildedRose.AddItem(testItem);

            // Act
            GildedRose.UpdateQuality();

            // Assert
            testItem.Quality.ShouldBe(50);
            testItem.SellIn.ShouldBe(3);
        }
    }
}
