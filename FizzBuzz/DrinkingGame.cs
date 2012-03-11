using System;

namespace FizzBuzz
{
    public class DrinkingGame
    {
        public event Func<int, string> TheRules;
        private string result;

        public Func<int, string> StartGame()
        {
            return input =>
                       {
                           result = "";
                           return result;
                       };
        }

        public Func<int, string> Substitute(int divisor, string word)
        {
            return input =>
                       {
                           if (input%divisor == 0) result += word;
                           return result;
                       };
        }

        public Func<int, string> NoChange()
        {
            return x =>
                       {
                           if (result == "") result += x.ToString();
                           return result;
                       };
        }

        public string Translate(int input)
        {
            return TheRules(input);
        }
    }
}