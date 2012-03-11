using NUnit.Framework;

namespace FizzBuzz
{
    [TestFixture]
    public class TestDrinkingGame
    {
        private DrinkingGame game;

        [SetUp]
        public void Setup()
        {
            game = new FizzBuzzGame();
        }

        [TestCase(2, "2")]
        [TestCase(3, "Fizz")]
        [TestCase(5, "Buzz")]
        [TestCase(15, "FizzBuzz")]
        public void TestTranslate(int input, string expected)
        {
            Assert.That(game.Translate(input), Is.EqualTo(expected));
        }

        [Test]
        public void TestCallSequentially()
        {
            Assert.That(game.Translate(1), Is.EqualTo("1"));
            Assert.That(game.Translate(2), Is.EqualTo("2"));
            Assert.That(game.Translate(3), Is.EqualTo("Fizz"));
        }
    }
}
