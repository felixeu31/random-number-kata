namespace RandomNumberKata.Tests;

public class GuessingNumberGame
{
    private readonly int _numberToGuess;

    public GuessingNumberGame(int numberToGuess)
    {
        _numberToGuess = numberToGuess;
    }

    public static GuessingNumberGame Start(INumberGenerator numberGenerator)
    {
        return new GuessingNumberGame(numberGenerator.GenerateNumber());
    }

    public string GuessNumber(int guessedNumber)
    {
        if (guessedNumber == _numberToGuess)
            return "win";

        return "try-again";
    }
}