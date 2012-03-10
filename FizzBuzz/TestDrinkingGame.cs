using System;
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
            game = new DrinkingGame();
            game.TheRules += game.Substitute(3, "Fizz");
            game.TheRules += game.Substitute(5, "Buzz");
            game.TheRules += game.NoChange;
        }

        [TestCase(2, "2")]
        [TestCase(3, "Fizz")]
        [TestCase(5, "Buzz")]
        [TestCase(15, "FizzBuzz")]
        public void TestTranslate(int input, string expected)
        {
            Assert.That(game.Translate(input), Is.EqualTo(expected));
        }
    }

    public class DrinkingGame
    {
        public delegate string Rule(int input);

        public event Func<int, string> TheRules;

        private static string result;

        public DrinkingGame()
        {
            result = "";
        }

        public Func<int, string, Func<int, string>> Substitute = (divisor, word) => input =>
        {
            if (input % divisor == 0) result += word;
            return result;
        };

        public Func<int, string> NoChange = x =>
        {
            if (result == "") result += x.ToString();
            return result;
        };

        public string Translate(int input)
        {
            return TheRules(input);
        }
    }

}
