using GildedRose.App.Mappings;
using GildedRose.Domain.BusinessRules;
using GildedRose.Domain.Enums;
using NUnit.Framework;
using Shouldly;

namespace GildedRose.Tests
{
    [TestFixture]
    public class StrategyMapTests
    {
        [Test]
        public void Should_ReturnAgedGetsBetterStrategy()
        {
            int itemTypeId = (int)ItemTypeEnum.AgedGetsBetter;
            IStrategy strategy = ItemTypeStrategyMap.GetUpdateStrategyByType(itemTypeId);
            strategy.ShouldBeOfType<AgedGetsBetterStrategy>();
        }

        [Test]
        public void Should_ReturnAgedGetsWorseStrategy()
        {
            int itemTypeId = (int)ItemTypeEnum.AgedGetsWorse;
            IStrategy strategy = ItemTypeStrategyMap.GetUpdateStrategyByType(itemTypeId);
            strategy.ShouldBeOfType<AgedGetsWorseStrategy>();
        }

        [Test]
        public void Should_ReturnBackStageStrategy()
        {
            int itemTypeId = (int)ItemTypeEnum.BackStage;
            IStrategy strategy = ItemTypeStrategyMap.GetUpdateStrategyByType(itemTypeId);
            strategy.ShouldBeOfType<BackStageStrategy>();
        }

        [Test]
        public void Should_ReturnNoStrategy()
        {
            int itemTypeId = (int)ItemTypeEnum.Legendary;
            IStrategy strategy = ItemTypeStrategyMap.GetUpdateStrategyByType(itemTypeId);
            strategy.ShouldBeOfType<NoStrategy>();
        }
    }
}
