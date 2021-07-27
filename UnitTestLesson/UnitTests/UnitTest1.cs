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
        /*
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
        } */

        public class ClassificationTests
        {
            [TestCase(1)]
            [TestCase(2)]
            [TestCase(3)]
            public void GivenAnAgeYoungerThan4_Result_ReturnsTooYoung(int age)
            {
                Assert.That(Program.AvailableClassifications(age), Is.EqualTo("You are too young to watch films."));
            }

            [TestCase(4)]
            [TestCase(5)]
            [TestCase(7)]
            public void GivenAnAgeBetween4And8_Result_ReturnsWatchU(int age)
            {
                Assert.That(Program.AvailableClassifications(age), Is.EqualTo("U films are available."));
            }

            [TestCase(8)]
            [TestCase(10)]
            [TestCase(11)]
            public void GivenAnAgeBetween8And12_Result_ReturnsWatchUPG(int age)
            {
                Assert.That(Program.AvailableClassifications(age), Is.EqualTo("U & PG films are available."));
            }

            [TestCase(12)]
            [TestCase(13)]
            [TestCase(14)]
            public void GivenAnAgeBetween12And15_Result_ReturnsWatchUPG12(int age)
            {
                Assert.That(Program.AvailableClassifications(age), Is.EqualTo("U, PG & 12 films are available."));
            }

            [TestCase(15)]
            [TestCase(16)]
            [TestCase(17)]
            public void GivenAnAgeBetween15And18_Result_ReturnsWatchUPG1215(int age)
            {
                Assert.That(Program.AvailableClassifications(age), Is.EqualTo("U, PG, 12 & 15 films are available."));
            }

            [TestCase(18)]
            [TestCase(25)]
            [TestCase(40)]
            public void GivenAnAgeBetween15And18_Result_ReturnsWatchAll(int age)
            {
                Assert.That(Program.AvailableClassifications(age), Is.EqualTo("All films are available."));
            }
        }
    }
}