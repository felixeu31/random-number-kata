namespace RandomNumberKata.Tests;

public class GuessingNumberGame
{
    public const string WIN = "win";
    public const string LOWER = "lower";
    public const string HIGHER = "higher";
    public const string LOSE = "lose";
    private readonly int _numberToGuess;
    private int _tries = 0;

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
        _tries++;

        if (guessedNumber == _numberToGuess)
            return WIN;

        if (_tries == 3)
            return LOSE;

        if (guessedNumber > _numberToGuess)
            return LOWER;

        return HIGHER;
    }
}