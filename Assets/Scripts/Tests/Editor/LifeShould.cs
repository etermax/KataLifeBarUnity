using Core;
using NUnit.Framework;

namespace Tests.Editor
{
    public class LifeShould
    {
        private Life _lifeBar;

        [SetUp]
        public void Setup()
        {
            _lifeBar = new Life();
        }

        [Test]
        public void DecrementWhenReceivesDamage()
        {
            // When
            _lifeBar.ReceiveDamage(10);

            // Then
            Assert.AreEqual(90, _lifeBar.CurrentValue);
        }

        [Test]
        public void NotHaveNegativeValues()
        {
            //When
            _lifeBar.ReceiveDamage(110);

            //Then
            Assert.AreEqual(0, _lifeBar.CurrentValue);
        }

        [Test]
        public void IncrementWhenReceivesHealing()
        {
            //Given
            _lifeBar.ReceiveDamage(10);

            //When
            _lifeBar.ReceiveHeal(10);

            //Then
            Assert.AreEqual(100, _lifeBar.CurrentValue);
        }

        [Test]
        public void NotHealMoreThanMaxLife()
        {
            //When
            _lifeBar.ReceiveHeal(10);

            //Then
            Assert.AreEqual(100, _lifeBar.CurrentValue);
        }
    }
}