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
            var itemTypeId = (int)ItemTypeEnum.AgedGetsBetter;
            var strategy = ItemTypeStrategyMap.GetUpdateStrategyByType(itemTypeId);
            strategy.ShouldBeOfType<AgedGetsBetterStrategy>();
        }

        [Test]
        public void Should_ReturnAgedGetsWorseStrategy()
        {
            var itemTypeId = (int)ItemTypeEnum.AgedGetsWorse;
            var strategy = ItemTypeStrategyMap.GetUpdateStrategyByType(itemTypeId);
            strategy.ShouldBeOfType<AgedGetsWorseStrategy>();
        }

        [Test]
        public void Should_ReturnBackStageStrategy()
        {
            var itemTypeId = (int)ItemTypeEnum.BackStage;
            var strategy = ItemTypeStrategyMap.GetUpdateStrategyByType(itemTypeId);
            strategy.ShouldBeOfType<BackStageStrategy>();
        }

        [Test]
        public void Should_ReturnNoStrategy()
        {
            var itemTypeId = (int)ItemTypeEnum.Legendary;
            var strategy = ItemTypeStrategyMap.GetUpdateStrategyByType(itemTypeId);
            strategy.ShouldBeOfType<NoStrategy>();
        }

        [Test]
        public void Should_ReturnConjuredStrategy()
        {
            var itemTypeId = (int)ItemTypeEnum.Conjured;
            var strategy = ItemTypeStrategyMap.GetUpdateStrategyByType(itemTypeId);
            strategy.ShouldBeOfType<ConjuredStrategy>();
        }
    }
}
