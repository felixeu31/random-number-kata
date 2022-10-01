namespace RandomNumberKata.Tests;

public class GuessingNumberGame
{
    private int _numberToGuess;

    public GuessingNumberGame(int numberToGuess)
    {
        _numberToGuess = numberToGuess;
    }

    public static GuessingNumberGame Start(INumberGenerator numberGenerator)
    {
        return new GuessingNumberGame(numberGenerator.GenerateNumber());
    }
}