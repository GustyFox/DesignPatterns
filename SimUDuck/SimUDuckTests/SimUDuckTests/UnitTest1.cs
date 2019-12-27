using NUnit.Framework;
using SimUDuck;
using Moq;
using SimUDuck.Interfaces;

namespace SimUDuckTests
{
    public class Tests
    {
        private Duck duck;
        private Mock<IFlyBehavior> _flyBehavior;
        private Mock<IQuackBehavior> _quackBehavior;

        [SetUp]
        public void Setup()
        {
            duck = new MallardDuck();

            _flyBehavior = new Mock<IFlyBehavior>();
            _flyBehavior.Setup(x => x.Fly());

            _quackBehavior = new Mock<IQuackBehavior>();
            _quackBehavior.Setup(x => x.QuackSound());
        }

        [Test]
        public void MallardDuck_WhenPerformFly_CallsFlyOnce()
        {
            duck.setFlyBehavior(_flyBehavior.Object);
            duck.PerformFly();
            _flyBehavior.Verify(x => x.Fly(), Times.Once);
        }

        [Test]
        public void MallardDuck_WhenPerformQuack_CallsQuackOnce()
        {
            duck.setQuackBehavior(_quackBehavior.Object);
            duck.PerformQuack();
            _quackBehavior.Verify(x => x.QuackSound(), Times.Once);
        }
    }
}