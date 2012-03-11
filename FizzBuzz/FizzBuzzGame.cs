namespace FizzBuzz
{
    public class FizzBuzzGame : DrinkingGame
    {
        public FizzBuzzGame()
        {
            TheRules += StartGame();
            TheRules += Substitute(3, "Fizz");
            TheRules += Substitute(5, "Buzz");
            TheRules += NoChange();
        }
    }
}
