using Choco_O_Holic;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ChocolateBoiler_HasOnlyOneInstance()
        {
            var boiler1 = ChocolateBoiler.getInstance();
            var boiler2 = ChocolateBoiler.getInstance();

            Assert.AreEqual(boiler1, boiler2); 
        }
    }
}