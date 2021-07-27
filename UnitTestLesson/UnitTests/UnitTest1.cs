using NUnit.Framework;
using CodeToTest;

namespace UnitTests
{
    public class GreetingsTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(5)]
        [TestCase(8)]
        [TestCase(12)]
        public void GivenATimeBetween5and12Inclusive_Greeting_ReturnsGoodMorning(int time)
        {
            // Arrange
            var expectedGreeting = "Good Morning!";
            // Act
            var result = Program.Greeting(time);
            // Assert
            Assert.That(result, Is.EqualTo(expectedGreeting));
        }

        [TestCase(13)]
        [TestCase(15)]
        [TestCase(18)]
        public void GivenATimeBetween12and18Inclusive_Greeting_ReturnsGoodAfternoon(int time)
        {
            Assert.That(Program.Greeting(time), Is.EqualTo("Good Afternoon!"));
        }

        [TestCase(19)]
        [TestCase(21)]
        [TestCase(24)]
        public void GivenATimeBetween18and24Inclusive_Greeting_ReturnsGoodEvening(int time)
        {
            Assert.That(Program.Greeting(time), Is.EqualTo("Good Evening!"));
        }

        [TestCase(1)]
        [TestCase(3)]
        [TestCase(4)]
        public void GivenATimeBetween24and5_Greeting_ReturnsGoBed(int time)
        {
            Assert.That(Program.Greeting(time), Is.EqualTo("Go to bed!"));
        }
    }
}