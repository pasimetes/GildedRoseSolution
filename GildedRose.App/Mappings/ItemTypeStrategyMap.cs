using GildedRose.Domain.BusinessRules;
using GildedRose.Domain.Enums;
using System.Collections.Generic;

namespace GildedRose.App.Mappings
{
    public static class ItemTypeStrategyMap
    {
        private static readonly IDictionary<int, IStrategy> _registry;
        
        static ItemTypeStrategyMap()
        {
            _registry = new Dictionary<int, IStrategy>
            {
                { (int)ItemTypeEnum.AgedGetsBetter, new AgedGetsBetterStrategy() },
                { (int)ItemTypeEnum.AgedGetsWorse, new AgedGetsWorseStrategy() },
                { (int)ItemTypeEnum.BackStage, new BackStageStrategy() },
                { (int)ItemTypeEnum.Legendary, new NoStrategy() }
            };
        }

        public static IStrategy GetUpdateStrategyByType(int itemTypeId)
        {
            return _registry[itemTypeId];
        }
    }
}
