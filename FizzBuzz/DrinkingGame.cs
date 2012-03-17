using System.Collections.Generic;
using System.Linq;

namespace FizzBuzz
{
    public class FizzBuzzGame : DrinkingGame
    {
        public FizzBuzzGame()
        {
            TheRules.Add(Substitute(3, "Fizz"));
            TheRules.Add(Substitute(5, "Buzz"));
            TheRules.Add(NoChange());
        }
    }

    public class DrinkingGame
    {
        public delegate string Rule(int input, string result);

        public List<Rule> TheRules = new List<Rule>();

        public Rule Substitute(int divisor, string word)
        {
            return (input,result) =>
                       {
                           if (input%divisor == 0) result += word;
                           return result;
                       };
        }

        public Rule NoChange()
        {
            return (input,result) =>
                       {
                           if (result == "") result += input.ToString();
                           return result;
                       };
        }

        public string Translate(int input)
        {
            return TheRules.Aggregate("", (current, rule) => rule(input, current));
        }
    }
}