using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace FizzBuzz
{
    [TestFixture]
    public class CallFizzBuzz
    {
        [Test]
        public void Enumerate()
        {
            foreach (string output in PlayGame())
            {
                Console.WriteLine(output);
            };
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
