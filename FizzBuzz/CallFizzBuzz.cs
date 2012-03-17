using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace FizzBuzz
{
    [TestFixture]
    public class CallFizzBuzz
    {
        [Test]
        public void Enumerate()
        {
            var output = PlayGame().ToList();
            Assert.That(output.Count(s => s == "Fizz"), Is.EqualTo(5));
            Assert.That(output.Count(s => s == "Buzz"), Is.EqualTo(2));
            Assert.That(output.Count(s => s == "FizzBuzz"), Is.EqualTo(1));
        }

        private static IEnumerable<string> PlayGame()
        {
            var game = new FizzBuzzGame();
            for (int i = 1; i < 20; i++)
            {
                yield return game.Translate(i);
            }
        }
    }
}
