using GildedRose.App.Interfaces;
using Moq;
using NUnit.Framework;

namespace GildedRose.Tests
{
    [TestFixture]
    public abstract class TestBase
    {
        protected readonly IGildedRose GildedRose;

        public TestBase()
        {
            GildedRose = new Mock<App.GildedRose>().Object;
        }
    }
}
