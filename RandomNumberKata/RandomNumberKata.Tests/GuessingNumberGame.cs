namespace RandomNumberKata.Tests;

public class GuessingNumberGame
{
    public const string WIN = "win";
    public const string LOWER = "lower";
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
            return WIN;

        return LOWER;
    }
}