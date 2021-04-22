using GildedRose.App.Interfaces;
using Moq;
using NUnit.Framework;

namespace GildedRose.Tests.StrategyTests
{
    [TestFixture]
    public abstract class TestBase
    {
        protected IGildedRose GildedRose;

        [SetUp]
        public void SetUp()
        {
            GildedRose = new Mock<App.GildedRose>().Object;
        }
    }
}
