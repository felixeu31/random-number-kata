namespace RandomNumberKata.Tests;

public class GuessingNumberGame
{
    public const string WIN = "win";
    public const string LOWER = "lower";
    public const string HIGHER = "higher";
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

        if (guessedNumber > _numberToGuess)
            return LOWER;

        return HIGHER;
    }
}