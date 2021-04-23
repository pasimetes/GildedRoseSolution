using GildedRose.Domain.BusinessRules;
using GildedRose.Domain.Enums;
using System.Collections.Generic;

namespace GildedRose.App.Mappings
{
    public static class ItemTypeStrategyMap
    {
        private static readonly IDictionary<ItemTypeEnum, IStrategy> _registry;
        
        static ItemTypeStrategyMap()
        {
            _registry = new Dictionary<ItemTypeEnum, IStrategy>
            {
                { ItemTypeEnum.AgedGetsBetter, new AgedGetsBetterStrategy() },
                { ItemTypeEnum.AgedGetsWorse, new AgedGetsWorseStrategy() },
                { ItemTypeEnum.BackStage, new BackStageStrategy() },
                { ItemTypeEnum.Legendary, new NoStrategy() },
                { ItemTypeEnum.Conjured, new ConjuredStrategy() }
            };
        }

        public static IStrategy GetUpdateStrategyByType(int itemTypeId)
        {
            return _registry[(ItemTypeEnum)itemTypeId];
        }
    }
}
